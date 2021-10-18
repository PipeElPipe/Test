// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/NewInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @NewInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @NewInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""NewInput"",
    ""maps"": [
        {
            ""name"": ""Combat"",
            ""id"": ""94d822f8-cafb-4c15-9010-9588fc2cdcf6"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""6a2b45cc-7961-49f9-bd7c-c54ee29d3dcb"",
                    ""expectedControlType"": ""Stick"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Fire"",
                    ""type"": ""Button"",
                    ""id"": ""088708cd-6087-46ac-b4b9-d592c9177a7f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Defense"",
                    ""type"": ""Button"",
                    ""id"": ""de3592d3-a85c-42cc-86f6-46a8b979cc16"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Super"",
                    ""type"": ""Button"",
                    ""id"": ""d742aeec-e044-48a5-9c57-2c50cf4e98b2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""8276cf1a-dae2-48d3-9842-a301ab3c27b6"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4435fcf9-f464-4b75-8efd-0e538b1bddcd"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c22bc65f-e172-4a9c-a9c4-2a7ea00cbb70"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Defense"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43763e91-0f98-4504-b5a7-0cf065f0e45e"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Super"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6aef943c-29d0-4e06-9850-a83ddc840289"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Super"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Combat
        m_Combat = asset.FindActionMap("Combat", throwIfNotFound: true);
        m_Combat_Move = m_Combat.FindAction("Move", throwIfNotFound: true);
        m_Combat_Fire = m_Combat.FindAction("Fire", throwIfNotFound: true);
        m_Combat_Defense = m_Combat.FindAction("Defense", throwIfNotFound: true);
        m_Combat_Super = m_Combat.FindAction("Super", throwIfNotFound: true);
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

    // Combat
    private readonly InputActionMap m_Combat;
    private ICombatActions m_CombatActionsCallbackInterface;
    private readonly InputAction m_Combat_Move;
    private readonly InputAction m_Combat_Fire;
    private readonly InputAction m_Combat_Defense;
    private readonly InputAction m_Combat_Super;
    public struct CombatActions
    {
        private @NewInput m_Wrapper;
        public CombatActions(@NewInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Combat_Move;
        public InputAction @Fire => m_Wrapper.m_Combat_Fire;
        public InputAction @Defense => m_Wrapper.m_Combat_Defense;
        public InputAction @Super => m_Wrapper.m_Combat_Super;
        public InputActionMap Get() { return m_Wrapper.m_Combat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CombatActions set) { return set.Get(); }
        public void SetCallbacks(ICombatActions instance)
        {
            if (m_Wrapper.m_CombatActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnMove;
                @Fire.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnFire;
                @Fire.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnFire;
                @Fire.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnFire;
                @Defense.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnDefense;
                @Defense.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnDefense;
                @Defense.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnDefense;
                @Super.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnSuper;
                @Super.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnSuper;
                @Super.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnSuper;
            }
            m_Wrapper.m_CombatActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Fire.started += instance.OnFire;
                @Fire.performed += instance.OnFire;
                @Fire.canceled += instance.OnFire;
                @Defense.started += instance.OnDefense;
                @Defense.performed += instance.OnDefense;
                @Defense.canceled += instance.OnDefense;
                @Super.started += instance.OnSuper;
                @Super.performed += instance.OnSuper;
                @Super.canceled += instance.OnSuper;
            }
        }
    }
    public CombatActions @Combat => new CombatActions(this);
    public interface ICombatActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnFire(InputAction.CallbackContext context);
        void OnDefense(InputAction.CallbackContext context);
        void OnSuper(InputAction.CallbackContext context);
    }
}
