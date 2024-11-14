//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.11.2
//     from Assets/PlayerActions.inputactions
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

public partial class @PlayerActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerActions"",
    ""maps"": [
        {
            ""name"": ""Heavy Character Inputs"",
            ""id"": ""bd9dc52f-d7a7-4534-bea9-d4695af05e18"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""fe7de953-041a-4e87-9950-a306927480d3"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""785d7719-2ebf-4095-b7f1-8fd97974d99e"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Attacks"",
                    ""type"": ""Button"",
                    ""id"": ""327c40c6-1da8-45b2-ace7-b858091a45b3"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""5ae26ad6-78ac-424a-a817-9d0d70103eeb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Dash"",
                    ""type"": ""Button"",
                    ""id"": ""8430ab90-ee2f-447f-a664-b4acb6c47d58"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""W+ Left click"",
                    ""type"": ""Button"",
                    ""id"": ""d12cd696-d0ac-431f-aba0-8671f6913ba5"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""WOnly"",
                    ""type"": ""Value"",
                    ""id"": ""069460fa-cf60-4df9-9685-660221c2e96e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Keyboard/gamepad Basic Movement"",
                    ""id"": ""37728131-0864-4d58-980b-86fa355bc98e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""Up"",
                    ""id"": ""d1e44a96-d8e6-41e8-b664-268226da3f87"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ac06798a-e5b7-4638-aba9-ca6a31cfd816"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""e440ff84-077c-44fc-87db-9a3b05b69a21"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""ae3c5dd6-446b-4566-9d16-f13ed2da9df9"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""d6429310-849e-4e15-a2f2-4a251e90c320"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c567bbbe-85da-4aeb-91f2-7cf018ba4972"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a8ca4636-b3c3-4d95-ba7f-10561bd4ee9b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37af45e1-857e-4aee-9c58-dc09e72d72c9"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attacks"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95a3ed57-7462-4912-ab8c-1129bcdbc679"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attacks"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c8c0a711-7ec5-4d11-b8a0-bf7ae1674c24"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Attacks"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""247cfbce-d737-4c11-9fa3-6d2575b1b4bf"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5adf0643-46a3-4ca6-aa1c-9986f9a60658"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""41030311-eb9c-4998-b990-b0edfde2044a"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""One Modifier"",
                    ""id"": ""03602490-d10d-4b19-9685-3f57a789dc4e"",
                    ""path"": ""OneModifier"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""W+ Left click"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""modifier"",
                    ""id"": ""3995bd7e-5b20-49bc-871e-d1f03ccfab1f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""W+ Left click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""binding"",
                    ""id"": ""69d328f9-c9ab-4d97-b483-9560498d6c46"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""W+ Left click"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fb15e4e0-a02c-4d0e-b70a-ceb20e5aca06"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WOnly"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Heavy Character Inputs
        m_HeavyCharacterInputs = asset.FindActionMap("Heavy Character Inputs", throwIfNotFound: true);
        m_HeavyCharacterInputs_Movement = m_HeavyCharacterInputs.FindAction("Movement", throwIfNotFound: true);
        m_HeavyCharacterInputs_Jump = m_HeavyCharacterInputs.FindAction("Jump", throwIfNotFound: true);
        m_HeavyCharacterInputs_Attacks = m_HeavyCharacterInputs.FindAction("Attacks", throwIfNotFound: true);
        m_HeavyCharacterInputs_Camera = m_HeavyCharacterInputs.FindAction("Camera", throwIfNotFound: true);
        m_HeavyCharacterInputs_Dash = m_HeavyCharacterInputs.FindAction("Dash", throwIfNotFound: true);
        m_HeavyCharacterInputs_WLeftclick = m_HeavyCharacterInputs.FindAction("W+ Left click", throwIfNotFound: true);
        m_HeavyCharacterInputs_WOnly = m_HeavyCharacterInputs.FindAction("WOnly", throwIfNotFound: true);
    }

    ~@PlayerActions()
    {
        UnityEngine.Debug.Assert(!m_HeavyCharacterInputs.enabled, "This will cause a leak and performance issues, PlayerActions.HeavyCharacterInputs.Disable() has not been called.");
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

    // Heavy Character Inputs
    private readonly InputActionMap m_HeavyCharacterInputs;
    private List<IHeavyCharacterInputsActions> m_HeavyCharacterInputsActionsCallbackInterfaces = new List<IHeavyCharacterInputsActions>();
    private readonly InputAction m_HeavyCharacterInputs_Movement;
    private readonly InputAction m_HeavyCharacterInputs_Jump;
    private readonly InputAction m_HeavyCharacterInputs_Attacks;
    private readonly InputAction m_HeavyCharacterInputs_Camera;
    private readonly InputAction m_HeavyCharacterInputs_Dash;
    private readonly InputAction m_HeavyCharacterInputs_WLeftclick;
    private readonly InputAction m_HeavyCharacterInputs_WOnly;
    public struct HeavyCharacterInputsActions
    {
        private @PlayerActions m_Wrapper;
        public HeavyCharacterInputsActions(@PlayerActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_HeavyCharacterInputs_Movement;
        public InputAction @Jump => m_Wrapper.m_HeavyCharacterInputs_Jump;
        public InputAction @Attacks => m_Wrapper.m_HeavyCharacterInputs_Attacks;
        public InputAction @Camera => m_Wrapper.m_HeavyCharacterInputs_Camera;
        public InputAction @Dash => m_Wrapper.m_HeavyCharacterInputs_Dash;
        public InputAction @WLeftclick => m_Wrapper.m_HeavyCharacterInputs_WLeftclick;
        public InputAction @WOnly => m_Wrapper.m_HeavyCharacterInputs_WOnly;
        public InputActionMap Get() { return m_Wrapper.m_HeavyCharacterInputs; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(HeavyCharacterInputsActions set) { return set.Get(); }
        public void AddCallbacks(IHeavyCharacterInputsActions instance)
        {
            if (instance == null || m_Wrapper.m_HeavyCharacterInputsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_HeavyCharacterInputsActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Attacks.started += instance.OnAttacks;
            @Attacks.performed += instance.OnAttacks;
            @Attacks.canceled += instance.OnAttacks;
            @Camera.started += instance.OnCamera;
            @Camera.performed += instance.OnCamera;
            @Camera.canceled += instance.OnCamera;
            @Dash.started += instance.OnDash;
            @Dash.performed += instance.OnDash;
            @Dash.canceled += instance.OnDash;
            @WLeftclick.started += instance.OnWLeftclick;
            @WLeftclick.performed += instance.OnWLeftclick;
            @WLeftclick.canceled += instance.OnWLeftclick;
            @WOnly.started += instance.OnWOnly;
            @WOnly.performed += instance.OnWOnly;
            @WOnly.canceled += instance.OnWOnly;
        }

        private void UnregisterCallbacks(IHeavyCharacterInputsActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Attacks.started -= instance.OnAttacks;
            @Attacks.performed -= instance.OnAttacks;
            @Attacks.canceled -= instance.OnAttacks;
            @Camera.started -= instance.OnCamera;
            @Camera.performed -= instance.OnCamera;
            @Camera.canceled -= instance.OnCamera;
            @Dash.started -= instance.OnDash;
            @Dash.performed -= instance.OnDash;
            @Dash.canceled -= instance.OnDash;
            @WLeftclick.started -= instance.OnWLeftclick;
            @WLeftclick.performed -= instance.OnWLeftclick;
            @WLeftclick.canceled -= instance.OnWLeftclick;
            @WOnly.started -= instance.OnWOnly;
            @WOnly.performed -= instance.OnWOnly;
            @WOnly.canceled -= instance.OnWOnly;
        }

        public void RemoveCallbacks(IHeavyCharacterInputsActions instance)
        {
            if (m_Wrapper.m_HeavyCharacterInputsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IHeavyCharacterInputsActions instance)
        {
            foreach (var item in m_Wrapper.m_HeavyCharacterInputsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_HeavyCharacterInputsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public HeavyCharacterInputsActions @HeavyCharacterInputs => new HeavyCharacterInputsActions(this);
    public interface IHeavyCharacterInputsActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnAttacks(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnWLeftclick(InputAction.CallbackContext context);
        void OnWOnly(InputAction.CallbackContext context);
    }
}
