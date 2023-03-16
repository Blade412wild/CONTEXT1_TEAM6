using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class TestingIputSystem : MonoBehaviour
{
    private Rigidbody rigidbody;
    private PlayerInput playerInput;
    Test playerActions;
    


    private void Awake()
    {
        rigidbody = GetComponent<Rigidbody>();
        playerInput = GetComponent<PlayerInput>();

        playerActions = new Test();
        playerActions.Player.Enable();
        // voeg de events op de input
        playerActions.Player.Jump.performed += Jump;
        playerActions.Player.Switchtomenu.performed += UISwitch;
        playerActions.UI.Submit.performed += Submit;
        playerActions.UI.SwitchToPlaying.performed += PlayingSwitch;
    }

    private void Update()
    {
        
    }

    private void FixedUpdate()
    {

        //PlayerMovement();
    }

    private void PlayerMovement()
    {
        Vector2 inputVector = playerActions.Player.Movement.ReadValue<Vector2>();
        Debug.Log(inputVector);
        float speed = 20f;
        rigidbody.AddForce(new Vector3(inputVector.x, 0, inputVector.y) * speed, ForceMode.Force);
    }

    public void Jump(InputAction.CallbackContext context)
    {
        if(context.performed)
        {
            Debug.Log(playerInput.currentActionMap);
            Debug.Log("jump " + context.phase );
            rigidbody.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
    }

    public void UISwitch(InputAction.CallbackContext context)
    {   
        playerActions.UI.Enable();
        playerActions.Player.Disable();
        playerInput.SwitchCurrentActionMap("UI");
        Debug.Log(playerInput.currentActionMap);
    }

    public void PlayingSwitch(InputAction.CallbackContext context)
    {
        playerActions.UI.Disable();
        playerActions.Player.Enable();
        playerInput.SwitchCurrentActionMap("Player");
        Debug.Log(playerInput.currentActionMap);

    }
    public void Submit(InputAction.CallbackContext context)
    {
        Debug.Log("dit werkt");
        if (context.performed)
        {
            Debug.Log("Submit " + context);
        }
    }
}
