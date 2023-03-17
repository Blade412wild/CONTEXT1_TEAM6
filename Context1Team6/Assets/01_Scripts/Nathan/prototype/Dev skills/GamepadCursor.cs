using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.LowLevel;
using UnityEngine.InputSystem.Users;

public class GamepadCursor : MonoBehaviour
{
    [SerializeField]
    private PlayerInput playerInput;
    [SerializeField]
    private RectTransform cursorTransform;
    [SerializeField]
    private float cursorSpeed = 1000f;
    [SerializeField]
    private RectTransform canvasRectTransform;
    [SerializeField]
    private Canvas canvas;
    [SerializeField]
    private float padding = 0f;

    public Vector2 anchoredPostion;

    private bool previousMouseState;
    private Mouse virtualMouse;
    private Camera mainCamera;
    private void OnEnable()
    {
        Cursor.visible = false;

        mainCamera = Camera.main;

        if(virtualMouse == null)
        {
            virtualMouse = (Mouse) InputSystem.AddDevice("VirtualMouse");
        }
        else if(!virtualMouse.added)
        {
            InputSystem.AddDevice(virtualMouse);
        }

        InputUser.PerformPairingWithDevice(virtualMouse, playerInput.user);

        if(cursorTransform != null)
        {
            Vector2 position = cursorTransform.anchoredPosition;
            InputState.Change(virtualMouse.position, position);
        }
        InputSystem.onAfterUpdate += UpdateMotion;
    }

    private void OnDisable()
    {
        InputSystem.RemoveDevice(virtualMouse);
        InputSystem.onAfterUpdate -= UpdateMotion;
    }
    private void UpdateMotion()
    {
        if (virtualMouse == null || Gamepad.current == null)
        {

            return;
        }

        Vector2 deltaValue = Gamepad.current.leftStick.ReadValue();
        deltaValue *= cursorSpeed * Time.deltaTime;

        Vector2 currentPostion = virtualMouse.position.ReadValue();
        Vector2 newPosition = currentPostion + deltaValue;

        newPosition.x = Mathf.Clamp(newPosition.x, padding, Screen.width - padding);
        newPosition.y = Mathf.Clamp(newPosition.y, padding, Screen.height - padding);

        InputState.Change(virtualMouse.position, newPosition);
        InputState.Change(virtualMouse.delta, deltaValue);

        bool abuttonIsPressed = Gamepad.current.aButton.IsPressed();

        if(previousMouseState != abuttonIsPressed)
        {
            virtualMouse.CopyState<MouseState>(out var mouseState);
            mouseState.WithButton(MouseButton.Left, Gamepad.current.aButton.IsPressed());
            InputState.Change(virtualMouse, mouseState);
            previousMouseState = abuttonIsPressed;
        }
        AnchorCursor(newPosition);
    }
    private void AnchorCursor(Vector2 position)
    {
        RectTransformUtility.ScreenPointToLocalPointInRectangle(canvasRectTransform, position, canvas.renderMode == RenderMode.ScreenSpaceOverlay ? null : mainCamera, out anchoredPostion);
        cursorTransform.anchoredPosition = anchoredPostion;    }
}
