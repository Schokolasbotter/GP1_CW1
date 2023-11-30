//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Input System/InputActions.inputactions
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

public partial class @InputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Character"",
            ""id"": ""41a7a449-b623-4553-9dea-83d074c8229f"",
            ""actions"": [
                {
                    ""name"": ""Walking"",
                    ""type"": ""Value"",
                    ""id"": ""606ac5fa-dd21-451a-b357-cc901437223f"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Looking"",
                    ""type"": ""Value"",
                    ""id"": ""70441f5e-9be6-4419-a26e-723726522d8d"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""53a111de-e1c3-42aa-bc23-7b94494899bb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""bbfb219a-9bd3-4869-a2c6-30cc0c2b530a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""WeaponSwap"",
                    ""type"": ""Button"",
                    ""id"": ""3fead96e-42c0-4796-a233-7aead01802e6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Aiming"",
                    ""type"": ""Button"",
                    ""id"": ""7da992eb-ecb8-42d1-a948-b331b0832835"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Shooting"",
                    ""type"": ""Button"",
                    ""id"": ""2ad31026-035f-4b2e-bed4-b3450ad2099b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""6e43a0f1-5014-4e1e-a059-3a9b8da93a67"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MenuConfirm"",
                    ""type"": ""Button"",
                    ""id"": ""c86a7fd6-35b2-46c3-82c3-d13e76973a4f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""6ad45249-60ca-4f31-a840-0b27781e1206"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""a54d7dee-c905-41a0-ac2d-2d20e0ab8405"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Walking"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""18868a3f-4638-4253-a98b-e1ea316a8af3"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Character"",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""55f7a4af-ac13-4337-ad30-9bd0e332ccd4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Character"",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d7649dbc-7d3e-4499-9f7a-6e5f2058a56c"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Character"",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""5cfd6550-4bee-46b3-a4ea-7d8a0af30698"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Character"",
                    ""action"": ""Walking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""1829ac87-18c8-4ddc-91ac-a0e9b82016b9"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Character"",
                    ""action"": ""Looking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e830c071-fd37-4540-b873-a8bda6e3e79d"",
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
                    ""id"": ""b4c115d3-5f95-4b93-8b46-fdfc7fe7a4f7"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a70bd4e4-d105-4b55-a527-6c54eda93a2f"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""WeaponSwap"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8bbc9e13-1dc2-4e12-87c0-04c5212c2644"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Aiming"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e44242ba-9acb-4534-9c30-e0f69e1a7b7a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shooting"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""74026357-eb60-4b36-864d-04caa187e29c"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4fac9539-0105-452e-a286-8c172fc5e4ed"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuConfirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9067e34f-d4f1-4a81-b544-fc0da86b6d15"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Car"",
            ""id"": ""f48a434c-9e14-4cae-ab13-6319bd3a693f"",
            ""actions"": [
                {
                    ""name"": ""Driving"",
                    ""type"": ""Value"",
                    ""id"": ""cbb494be-b499-4373-9adc-119e7881d54c"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Pause"",
                    ""type"": ""Button"",
                    ""id"": ""fea08289-588d-493f-932c-46eba24fdf54"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""MenuConfirm"",
                    ""type"": ""Button"",
                    ""id"": ""1f76e926-408e-40ed-a72d-c137264da57a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Boost"",
                    ""type"": ""Button"",
                    ""id"": ""68d5f31b-f4b5-4273-b37e-84729cb87d28"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""ExitCar"",
                    ""type"": ""Button"",
                    ""id"": ""e6dfac7f-e2de-499b-b14b-7947a70e90f6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""de3dd963-fb96-49e5-a271-635ebbe0618e"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Driving"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""26bc815f-1fac-484d-8e6e-665bc887ca13"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Character"",
                    ""action"": ""Driving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ab5803e1-a73a-437d-9791-c2b43222e98e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Character"",
                    ""action"": ""Driving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""32f3b2ef-274b-4c64-85e1-26dd4e7ff7ac"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Character"",
                    ""action"": ""Driving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b3f42b48-80ed-42ed-b6a6-04c4140c3a3c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Character"",
                    ""action"": ""Driving"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""6ec55c2a-9f5c-41d1-86eb-8d6cfa30a24c"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Boost"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""de437123-5c14-4abb-a2fa-a09b009c18c0"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ExitCar"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2c06a3e0-5e30-4d0a-aefc-6443e300a061"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""MenuConfirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bdf601b9-03fe-4ccc-b9c7-370dd12e8f87"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Pause"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Character"",
            ""bindingGroup"": ""Character"",
            ""devices"": []
        }
    ]
}");
        // Character
        m_Character = asset.FindActionMap("Character", throwIfNotFound: true);
        m_Character_Walking = m_Character.FindAction("Walking", throwIfNotFound: true);
        m_Character_Looking = m_Character.FindAction("Looking", throwIfNotFound: true);
        m_Character_Jump = m_Character.FindAction("Jump", throwIfNotFound: true);
        m_Character_Sprint = m_Character.FindAction("Sprint", throwIfNotFound: true);
        m_Character_WeaponSwap = m_Character.FindAction("WeaponSwap", throwIfNotFound: true);
        m_Character_Aiming = m_Character.FindAction("Aiming", throwIfNotFound: true);
        m_Character_Shooting = m_Character.FindAction("Shooting", throwIfNotFound: true);
        m_Character_Interact = m_Character.FindAction("Interact", throwIfNotFound: true);
        m_Character_MenuConfirm = m_Character.FindAction("MenuConfirm", throwIfNotFound: true);
        m_Character_Pause = m_Character.FindAction("Pause", throwIfNotFound: true);
        // Car
        m_Car = asset.FindActionMap("Car", throwIfNotFound: true);
        m_Car_Driving = m_Car.FindAction("Driving", throwIfNotFound: true);
        m_Car_Pause = m_Car.FindAction("Pause", throwIfNotFound: true);
        m_Car_MenuConfirm = m_Car.FindAction("MenuConfirm", throwIfNotFound: true);
        m_Car_Boost = m_Car.FindAction("Boost", throwIfNotFound: true);
        m_Car_ExitCar = m_Car.FindAction("ExitCar", throwIfNotFound: true);
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

    // Character
    private readonly InputActionMap m_Character;
    private List<ICharacterActions> m_CharacterActionsCallbackInterfaces = new List<ICharacterActions>();
    private readonly InputAction m_Character_Walking;
    private readonly InputAction m_Character_Looking;
    private readonly InputAction m_Character_Jump;
    private readonly InputAction m_Character_Sprint;
    private readonly InputAction m_Character_WeaponSwap;
    private readonly InputAction m_Character_Aiming;
    private readonly InputAction m_Character_Shooting;
    private readonly InputAction m_Character_Interact;
    private readonly InputAction m_Character_MenuConfirm;
    private readonly InputAction m_Character_Pause;
    public struct CharacterActions
    {
        private @InputActions m_Wrapper;
        public CharacterActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Walking => m_Wrapper.m_Character_Walking;
        public InputAction @Looking => m_Wrapper.m_Character_Looking;
        public InputAction @Jump => m_Wrapper.m_Character_Jump;
        public InputAction @Sprint => m_Wrapper.m_Character_Sprint;
        public InputAction @WeaponSwap => m_Wrapper.m_Character_WeaponSwap;
        public InputAction @Aiming => m_Wrapper.m_Character_Aiming;
        public InputAction @Shooting => m_Wrapper.m_Character_Shooting;
        public InputAction @Interact => m_Wrapper.m_Character_Interact;
        public InputAction @MenuConfirm => m_Wrapper.m_Character_MenuConfirm;
        public InputAction @Pause => m_Wrapper.m_Character_Pause;
        public InputActionMap Get() { return m_Wrapper.m_Character; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterActions set) { return set.Get(); }
        public void AddCallbacks(ICharacterActions instance)
        {
            if (instance == null || m_Wrapper.m_CharacterActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CharacterActionsCallbackInterfaces.Add(instance);
            @Walking.started += instance.OnWalking;
            @Walking.performed += instance.OnWalking;
            @Walking.canceled += instance.OnWalking;
            @Looking.started += instance.OnLooking;
            @Looking.performed += instance.OnLooking;
            @Looking.canceled += instance.OnLooking;
            @Jump.started += instance.OnJump;
            @Jump.performed += instance.OnJump;
            @Jump.canceled += instance.OnJump;
            @Sprint.started += instance.OnSprint;
            @Sprint.performed += instance.OnSprint;
            @Sprint.canceled += instance.OnSprint;
            @WeaponSwap.started += instance.OnWeaponSwap;
            @WeaponSwap.performed += instance.OnWeaponSwap;
            @WeaponSwap.canceled += instance.OnWeaponSwap;
            @Aiming.started += instance.OnAiming;
            @Aiming.performed += instance.OnAiming;
            @Aiming.canceled += instance.OnAiming;
            @Shooting.started += instance.OnShooting;
            @Shooting.performed += instance.OnShooting;
            @Shooting.canceled += instance.OnShooting;
            @Interact.started += instance.OnInteract;
            @Interact.performed += instance.OnInteract;
            @Interact.canceled += instance.OnInteract;
            @MenuConfirm.started += instance.OnMenuConfirm;
            @MenuConfirm.performed += instance.OnMenuConfirm;
            @MenuConfirm.canceled += instance.OnMenuConfirm;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
        }

        private void UnregisterCallbacks(ICharacterActions instance)
        {
            @Walking.started -= instance.OnWalking;
            @Walking.performed -= instance.OnWalking;
            @Walking.canceled -= instance.OnWalking;
            @Looking.started -= instance.OnLooking;
            @Looking.performed -= instance.OnLooking;
            @Looking.canceled -= instance.OnLooking;
            @Jump.started -= instance.OnJump;
            @Jump.performed -= instance.OnJump;
            @Jump.canceled -= instance.OnJump;
            @Sprint.started -= instance.OnSprint;
            @Sprint.performed -= instance.OnSprint;
            @Sprint.canceled -= instance.OnSprint;
            @WeaponSwap.started -= instance.OnWeaponSwap;
            @WeaponSwap.performed -= instance.OnWeaponSwap;
            @WeaponSwap.canceled -= instance.OnWeaponSwap;
            @Aiming.started -= instance.OnAiming;
            @Aiming.performed -= instance.OnAiming;
            @Aiming.canceled -= instance.OnAiming;
            @Shooting.started -= instance.OnShooting;
            @Shooting.performed -= instance.OnShooting;
            @Shooting.canceled -= instance.OnShooting;
            @Interact.started -= instance.OnInteract;
            @Interact.performed -= instance.OnInteract;
            @Interact.canceled -= instance.OnInteract;
            @MenuConfirm.started -= instance.OnMenuConfirm;
            @MenuConfirm.performed -= instance.OnMenuConfirm;
            @MenuConfirm.canceled -= instance.OnMenuConfirm;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
        }

        public void RemoveCallbacks(ICharacterActions instance)
        {
            if (m_Wrapper.m_CharacterActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICharacterActions instance)
        {
            foreach (var item in m_Wrapper.m_CharacterActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CharacterActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CharacterActions @Character => new CharacterActions(this);

    // Car
    private readonly InputActionMap m_Car;
    private List<ICarActions> m_CarActionsCallbackInterfaces = new List<ICarActions>();
    private readonly InputAction m_Car_Driving;
    private readonly InputAction m_Car_Pause;
    private readonly InputAction m_Car_MenuConfirm;
    private readonly InputAction m_Car_Boost;
    private readonly InputAction m_Car_ExitCar;
    public struct CarActions
    {
        private @InputActions m_Wrapper;
        public CarActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Driving => m_Wrapper.m_Car_Driving;
        public InputAction @Pause => m_Wrapper.m_Car_Pause;
        public InputAction @MenuConfirm => m_Wrapper.m_Car_MenuConfirm;
        public InputAction @Boost => m_Wrapper.m_Car_Boost;
        public InputAction @ExitCar => m_Wrapper.m_Car_ExitCar;
        public InputActionMap Get() { return m_Wrapper.m_Car; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CarActions set) { return set.Get(); }
        public void AddCallbacks(ICarActions instance)
        {
            if (instance == null || m_Wrapper.m_CarActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_CarActionsCallbackInterfaces.Add(instance);
            @Driving.started += instance.OnDriving;
            @Driving.performed += instance.OnDriving;
            @Driving.canceled += instance.OnDriving;
            @Pause.started += instance.OnPause;
            @Pause.performed += instance.OnPause;
            @Pause.canceled += instance.OnPause;
            @MenuConfirm.started += instance.OnMenuConfirm;
            @MenuConfirm.performed += instance.OnMenuConfirm;
            @MenuConfirm.canceled += instance.OnMenuConfirm;
            @Boost.started += instance.OnBoost;
            @Boost.performed += instance.OnBoost;
            @Boost.canceled += instance.OnBoost;
            @ExitCar.started += instance.OnExitCar;
            @ExitCar.performed += instance.OnExitCar;
            @ExitCar.canceled += instance.OnExitCar;
        }

        private void UnregisterCallbacks(ICarActions instance)
        {
            @Driving.started -= instance.OnDriving;
            @Driving.performed -= instance.OnDriving;
            @Driving.canceled -= instance.OnDriving;
            @Pause.started -= instance.OnPause;
            @Pause.performed -= instance.OnPause;
            @Pause.canceled -= instance.OnPause;
            @MenuConfirm.started -= instance.OnMenuConfirm;
            @MenuConfirm.performed -= instance.OnMenuConfirm;
            @MenuConfirm.canceled -= instance.OnMenuConfirm;
            @Boost.started -= instance.OnBoost;
            @Boost.performed -= instance.OnBoost;
            @Boost.canceled -= instance.OnBoost;
            @ExitCar.started -= instance.OnExitCar;
            @ExitCar.performed -= instance.OnExitCar;
            @ExitCar.canceled -= instance.OnExitCar;
        }

        public void RemoveCallbacks(ICarActions instance)
        {
            if (m_Wrapper.m_CarActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(ICarActions instance)
        {
            foreach (var item in m_Wrapper.m_CarActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_CarActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public CarActions @Car => new CarActions(this);
    private int m_CharacterSchemeIndex = -1;
    public InputControlScheme CharacterScheme
    {
        get
        {
            if (m_CharacterSchemeIndex == -1) m_CharacterSchemeIndex = asset.FindControlSchemeIndex("Character");
            return asset.controlSchemes[m_CharacterSchemeIndex];
        }
    }
    public interface ICharacterActions
    {
        void OnWalking(InputAction.CallbackContext context);
        void OnLooking(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnWeaponSwap(InputAction.CallbackContext context);
        void OnAiming(InputAction.CallbackContext context);
        void OnShooting(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnMenuConfirm(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
    }
    public interface ICarActions
    {
        void OnDriving(InputAction.CallbackContext context);
        void OnPause(InputAction.CallbackContext context);
        void OnMenuConfirm(InputAction.CallbackContext context);
        void OnBoost(InputAction.CallbackContext context);
        void OnExitCar(InputAction.CallbackContext context);
    }
}
