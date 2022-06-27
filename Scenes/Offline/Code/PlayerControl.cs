//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.3.0
//     from Assets/Scenes/Scenes/Offline/Code/PlayerControl.inputactions
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

public partial class @PlayerControl : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControl()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControl"",
    ""maps"": [
        {
            ""name"": ""Movement"",
            ""id"": ""d5986c46-1036-4088-be05-3fb8b0c3e9b2"",
            ""actions"": [
                {
                    ""name"": ""Player1"",
                    ""type"": ""Value"",
                    ""id"": ""94e8a1b7-36dd-4799-a331-b32033f09145"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Player2"",
                    ""type"": ""Value"",
                    ""id"": ""5324d368-bb74-4783-ada5-7b40b4ab06e3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Esc "",
                    ""type"": ""Button"",
                    ""id"": ""a6e3ee68-d16f-41fc-971f-1cb0c25057b8"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""afe864f1-935a-4b04-884e-9a1fc27ea5e1"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""7e29473e-8a09-4718-89a3-b00da810f272"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""19eadad9-4fcf-4a84-a73b-10e2e13dc4e8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""8e72f05b-41f3-4262-9f16-a41139fc9290"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""c931b561-983c-43a3-b926-00810bf41ab1"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""7443a507-3ec3-4e9c-bc75-edba4a8cc243"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Player2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""3ae5411b-f91a-4e54-a972-5e55dc1ad5be"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Esc "",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movement
        m_Movement = asset.FindActionMap("Movement", throwIfNotFound: true);
        m_Movement_Player1 = m_Movement.FindAction("Player1", throwIfNotFound: true);
        m_Movement_Player2 = m_Movement.FindAction("Player2", throwIfNotFound: true);
        m_Movement_Esc = m_Movement.FindAction("Esc ", throwIfNotFound: true);
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

    // Movement
    private readonly InputActionMap m_Movement;
    private IMovementActions m_MovementActionsCallbackInterface;
    private readonly InputAction m_Movement_Player1;
    private readonly InputAction m_Movement_Player2;
    private readonly InputAction m_Movement_Esc;
    public struct MovementActions
    {
        private @PlayerControl m_Wrapper;
        public MovementActions(@PlayerControl wrapper) { m_Wrapper = wrapper; }
        public InputAction @Player1 => m_Wrapper.m_Movement_Player1;
        public InputAction @Player2 => m_Wrapper.m_Movement_Player2;
        public InputAction @Esc => m_Wrapper.m_Movement_Esc;
        public InputActionMap Get() { return m_Wrapper.m_Movement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovementActions set) { return set.Get(); }
        public void SetCallbacks(IMovementActions instance)
        {
            if (m_Wrapper.m_MovementActionsCallbackInterface != null)
            {
                @Player1.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnPlayer1;
                @Player1.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnPlayer1;
                @Player1.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnPlayer1;
                @Player2.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnPlayer2;
                @Player2.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnPlayer2;
                @Player2.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnPlayer2;
                @Esc.started -= m_Wrapper.m_MovementActionsCallbackInterface.OnEsc;
                @Esc.performed -= m_Wrapper.m_MovementActionsCallbackInterface.OnEsc;
                @Esc.canceled -= m_Wrapper.m_MovementActionsCallbackInterface.OnEsc;
            }
            m_Wrapper.m_MovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Player1.started += instance.OnPlayer1;
                @Player1.performed += instance.OnPlayer1;
                @Player1.canceled += instance.OnPlayer1;
                @Player2.started += instance.OnPlayer2;
                @Player2.performed += instance.OnPlayer2;
                @Player2.canceled += instance.OnPlayer2;
                @Esc.started += instance.OnEsc;
                @Esc.performed += instance.OnEsc;
                @Esc.canceled += instance.OnEsc;
            }
        }
    }
    public MovementActions @Movement => new MovementActions(this);
    public interface IMovementActions
    {
        void OnPlayer1(InputAction.CallbackContext context);
        void OnPlayer2(InputAction.CallbackContext context);
        void OnEsc(InputAction.CallbackContext context);
    }
}