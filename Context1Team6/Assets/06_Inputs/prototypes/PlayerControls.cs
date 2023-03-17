//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/06_Inputs/prototypes/PlayerControls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PlayerControls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""c19fecdb-fe6d-477d-bd2a-b020b0adec3a"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""29ad960c-9112-4f64-b863-10420d959021"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""PassThrough"",
                    ""id"": ""24635b37-b5ad-47a9-9d49-fd21d4a788a5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""abde9e10-89db-4438-9f2a-21a2ea09a9f1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""8f5cce36-b1f0-46dd-96b2-f77d069afdb4"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB + M"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""adc22214-ab28-40e5-bb56-a3986a283ad0"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB + M"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""3a61198c-28b9-4bd7-8536-01ed3e719e9e"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB + M"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5321da00-2f22-4f29-9037-39bc47bdc145"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB + M"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c5970780-3a21-41c0-81f8-737a5e819284"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""abd0cdb7-8320-4876-a2f7-30f308306227"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GamePad"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a41445b0-52c1-4ba0-84f1-566694bef1ae"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB + M"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Designer"",
            ""id"": ""f38c239a-150d-473b-a0bc-51392e1f4708"",
            ""actions"": [
                {
                    ""name"": ""GravityCycle"",
                    ""type"": ""Button"",
                    ""id"": ""df828f88-ef44-490c-8046-4852ca8872db"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""MovementSpeedCycle"",
                    ""type"": ""Button"",
                    ""id"": ""ea3bfcce-f266-4ec4-981f-b39f47427885"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""JumpHeightCycle"",
                    ""type"": ""Button"",
                    ""id"": ""54cb2c83-c9d3-4cc0-91e6-c51d1ea3d722"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""978fc59f-22c9-4035-815b-289c2ba78e27"",
                    ""path"": ""<Keyboard>/g"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB + M"",
                    ""action"": ""GravityCycle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""29c7ab81-f5f2-4c59-a814-7eebd7a61ec9"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB + M"",
                    ""action"": ""MovementSpeedCycle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19aa33c3-bd0d-4558-925d-dea8494af93c"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""KB + M"",
                    ""action"": ""JumpHeightCycle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""KB + M"",
            ""bindingGroup"": ""KB + M"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""GamePad"",
            ""bindingGroup"": ""GamePad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Jump = m_Player.FindAction("Jump", throwIfNotFound: true);
        // Designer
        m_Designer = asset.FindActionMap("Designer", throwIfNotFound: true);
        m_Designer_GravityCycle = m_Designer.FindAction("GravityCycle", throwIfNotFound: true);
        m_Designer_MovementSpeedCycle = m_Designer.FindAction("MovementSpeedCycle", throwIfNotFound: true);
        m_Designer_JumpHeightCycle = m_Designer.FindAction("JumpHeightCycle", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Player
    private readonly InputActionMap m_Player;
    private IPlayerActions m_PlayerActionsCallbackInterface;
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Jump;
    public struct PlayerActions
    {
        private @PlayerControls m_Wrapper;
        public PlayerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Jump => m_Wrapper.m_Player_Jump;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnMovement;
                @Jump.started -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_PlayerActionsCallbackInterface.OnJump;
            }
            m_Wrapper.m_PlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
            }
        }
    }
    public PlayerActions @Player => new PlayerActions(this);

    // Designer
    private readonly InputActionMap m_Designer;
    private IDesignerActions m_DesignerActionsCallbackInterface;
    private readonly InputAction m_Designer_GravityCycle;
    private readonly InputAction m_Designer_MovementSpeedCycle;
    private readonly InputAction m_Designer_JumpHeightCycle;
    public struct DesignerActions
    {
        private @PlayerControls m_Wrapper;
        public DesignerActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @GravityCycle => m_Wrapper.m_Designer_GravityCycle;
        public InputAction @MovementSpeedCycle => m_Wrapper.m_Designer_MovementSpeedCycle;
        public InputAction @JumpHeightCycle => m_Wrapper.m_Designer_JumpHeightCycle;
        public InputActionMap Get() { return m_Wrapper.m_Designer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(DesignerActions set) { return set.Get(); }
        public void SetCallbacks(IDesignerActions instance)
        {
            if (m_Wrapper.m_DesignerActionsCallbackInterface != null)
            {
                @GravityCycle.started -= m_Wrapper.m_DesignerActionsCallbackInterface.OnGravityCycle;
                @GravityCycle.performed -= m_Wrapper.m_DesignerActionsCallbackInterface.OnGravityCycle;
                @GravityCycle.canceled -= m_Wrapper.m_DesignerActionsCallbackInterface.OnGravityCycle;
                @MovementSpeedCycle.started -= m_Wrapper.m_DesignerActionsCallbackInterface.OnMovementSpeedCycle;
                @MovementSpeedCycle.performed -= m_Wrapper.m_DesignerActionsCallbackInterface.OnMovementSpeedCycle;
                @MovementSpeedCycle.canceled -= m_Wrapper.m_DesignerActionsCallbackInterface.OnMovementSpeedCycle;
                @JumpHeightCycle.started -= m_Wrapper.m_DesignerActionsCallbackInterface.OnJumpHeightCycle;
                @JumpHeightCycle.performed -= m_Wrapper.m_DesignerActionsCallbackInterface.OnJumpHeightCycle;
                @JumpHeightCycle.canceled -= m_Wrapper.m_DesignerActionsCallbackInterface.OnJumpHeightCycle;
            }
            m_Wrapper.m_DesignerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @GravityCycle.started += instance.OnGravityCycle;
                @GravityCycle.performed += instance.OnGravityCycle;
                @GravityCycle.canceled += instance.OnGravityCycle;
                @MovementSpeedCycle.started += instance.OnMovementSpeedCycle;
                @MovementSpeedCycle.performed += instance.OnMovementSpeedCycle;
                @MovementSpeedCycle.canceled += instance.OnMovementSpeedCycle;
                @JumpHeightCycle.started += instance.OnJumpHeightCycle;
                @JumpHeightCycle.performed += instance.OnJumpHeightCycle;
                @JumpHeightCycle.canceled += instance.OnJumpHeightCycle;
            }
        }
    }
    public DesignerActions @Designer => new DesignerActions(this);
    private int m_KBMSchemeIndex = -1;
    public InputControlScheme KBMScheme
    {
        get
        {
            if (m_KBMSchemeIndex == -1) m_KBMSchemeIndex = asset.FindControlSchemeIndex("KB + M");
            return asset.controlSchemes[m_KBMSchemeIndex];
        }
    }
    private int m_GamePadSchemeIndex = -1;
    public InputControlScheme GamePadScheme
    {
        get
        {
            if (m_GamePadSchemeIndex == -1) m_GamePadSchemeIndex = asset.FindControlSchemeIndex("GamePad");
            return asset.controlSchemes[m_GamePadSchemeIndex];
        }
    }
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
    }
    public interface IDesignerActions
    {
        void OnGravityCycle(InputAction.CallbackContext context);
        void OnMovementSpeedCycle(InputAction.CallbackContext context);
        void OnJumpHeightCycle(InputAction.CallbackContext context);
    }
}
