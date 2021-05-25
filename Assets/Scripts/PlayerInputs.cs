// GENERATED AUTOMATICALLY FROM 'Assets/Inputs/PlayerInputs.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputs : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""PlayerMovement"",
            ""id"": ""4d9813fd-46ec-4db5-abb1-c4e529473eda"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""90ae34dd-5a57-4603-a528-7ddeb35a7d85"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""3d643419-74db-47d7-97f3-b33a0ff84531"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WSAD"",
                    ""id"": ""4600be91-0545-4325-96e7-96538423fd3c"",
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
                    ""id"": ""336d519e-41da-4dfb-ac08-dbefda0ff4d0"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e5c97b97-ffe8-4897-a03d-a29b76eee63d"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b0287556-eeaf-4b05-8dc7-82dda865ecbf"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c283bd05-3be6-44e9-a42b-93bffef0173f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Analog"",
                    ""id"": ""14797868-d0a9-403f-ab25-c7f9c9b93c2f"",
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
                    ""id"": ""7e96744c-fc03-4145-9512-6a7b287007b0"",
                    ""path"": ""<Gamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""21794d9f-d860-466d-865b-7a6eadf31920"",
                    ""path"": ""<Gamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""63d98844-69a8-44cd-827a-7100d192d440"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""d75debff-663d-4bf8-8370-9a1f65818cf9"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""87222ca4-b877-4082-963d-4573e07a5389"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c13fe322-b21b-4b90-8826-8b10ac893058"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""MiniGame"",
            ""id"": ""325564b5-e530-43c4-b9cc-e2787cd655c9"",
            ""actions"": [
                {
                    ""name"": ""Controls"",
                    ""type"": ""Button"",
                    ""id"": ""c49c0b10-bcb5-42e6-905b-79dee296e4b1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Q"",
                    ""type"": ""Button"",
                    ""id"": ""db1a3a4f-4231-48a9-8d9d-4d35b06a1ab6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""A"",
                    ""type"": ""Button"",
                    ""id"": ""50ad1d56-18ec-4cce-aa49-efa342a98196"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""W"",
                    ""type"": ""Button"",
                    ""id"": ""db963a8e-a84f-4c4a-acb4-96cea1dd561a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""S"",
                    ""type"": ""Button"",
                    ""id"": ""fc4f8d08-cf09-44ec-814b-874d246a530e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""16160dc1-6aad-4f74-859e-a6958f2efcf9"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Controls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c27e80a9-c0ab-41c8-873e-6f32f027cdbd"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Controls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""28a39538-9d00-4cba-a0af-13c9f25c27e5"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Controls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86ca7fe3-5dd8-427e-808f-b33083cd009f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Controls"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2060113b-0b6d-4840-b892-380f8bad6fd3"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Q"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a0f07b3b-4287-4beb-aaa6-b626f9938f98"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""A"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3ee2e2ad-c0cd-4044-9489-ea5769bdafb6"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""W"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""09e07404-617d-4f6e-96d4-b7c3bd60458f"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""S"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Interaction"",
            ""id"": ""bcb51f10-96ff-44e0-8df4-1280cd85ddff"",
            ""actions"": [
                {
                    ""name"": ""Interaction"",
                    ""type"": ""Button"",
                    ""id"": ""9dcb8228-b4de-49bb-9b8d-85ed04bb7b29"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""3d1f52b0-e150-43e0-9fb5-f70db7cd6408"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""723d0cf9-5baa-4fa4-b859-995d4ba95ad5"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7b5f1837-dacb-4798-b201-8c1a0752f21b"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""adf9e945-fef5-4c5f-a5ac-ab5dcdd53885"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Gamepad"",
                    ""action"": ""Interaction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": []
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": []
        }
    ]
}");
        // PlayerMovement
        m_PlayerMovement = asset.FindActionMap("PlayerMovement", throwIfNotFound: true);
        m_PlayerMovement_Movement = m_PlayerMovement.FindAction("Movement", throwIfNotFound: true);
        m_PlayerMovement_Look = m_PlayerMovement.FindAction("Look", throwIfNotFound: true);
        // MiniGame
        m_MiniGame = asset.FindActionMap("MiniGame", throwIfNotFound: true);
        m_MiniGame_Controls = m_MiniGame.FindAction("Controls", throwIfNotFound: true);
        m_MiniGame_Q = m_MiniGame.FindAction("Q", throwIfNotFound: true);
        m_MiniGame_A = m_MiniGame.FindAction("A", throwIfNotFound: true);
        m_MiniGame_W = m_MiniGame.FindAction("W", throwIfNotFound: true);
        m_MiniGame_S = m_MiniGame.FindAction("S", throwIfNotFound: true);
        // Interaction
        m_Interaction = asset.FindActionMap("Interaction", throwIfNotFound: true);
        m_Interaction_Interaction = m_Interaction.FindAction("Interaction", throwIfNotFound: true);
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

    // PlayerMovement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_Movement;
    private readonly InputAction m_PlayerMovement_Look;
    public struct PlayerMovementActions
    {
        private @PlayerInputs m_Wrapper;
        public PlayerMovementActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_PlayerMovement_Movement;
        public InputAction @Look => m_Wrapper.m_PlayerMovement_Look;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMovement;
                @Look.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // MiniGame
    private readonly InputActionMap m_MiniGame;
    private IMiniGameActions m_MiniGameActionsCallbackInterface;
    private readonly InputAction m_MiniGame_Controls;
    private readonly InputAction m_MiniGame_Q;
    private readonly InputAction m_MiniGame_A;
    private readonly InputAction m_MiniGame_W;
    private readonly InputAction m_MiniGame_S;
    public struct MiniGameActions
    {
        private @PlayerInputs m_Wrapper;
        public MiniGameActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Controls => m_Wrapper.m_MiniGame_Controls;
        public InputAction @Q => m_Wrapper.m_MiniGame_Q;
        public InputAction @A => m_Wrapper.m_MiniGame_A;
        public InputAction @W => m_Wrapper.m_MiniGame_W;
        public InputAction @S => m_Wrapper.m_MiniGame_S;
        public InputActionMap Get() { return m_Wrapper.m_MiniGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MiniGameActions set) { return set.Get(); }
        public void SetCallbacks(IMiniGameActions instance)
        {
            if (m_Wrapper.m_MiniGameActionsCallbackInterface != null)
            {
                @Controls.started -= m_Wrapper.m_MiniGameActionsCallbackInterface.OnControls;
                @Controls.performed -= m_Wrapper.m_MiniGameActionsCallbackInterface.OnControls;
                @Controls.canceled -= m_Wrapper.m_MiniGameActionsCallbackInterface.OnControls;
                @Q.started -= m_Wrapper.m_MiniGameActionsCallbackInterface.OnQ;
                @Q.performed -= m_Wrapper.m_MiniGameActionsCallbackInterface.OnQ;
                @Q.canceled -= m_Wrapper.m_MiniGameActionsCallbackInterface.OnQ;
                @A.started -= m_Wrapper.m_MiniGameActionsCallbackInterface.OnA;
                @A.performed -= m_Wrapper.m_MiniGameActionsCallbackInterface.OnA;
                @A.canceled -= m_Wrapper.m_MiniGameActionsCallbackInterface.OnA;
                @W.started -= m_Wrapper.m_MiniGameActionsCallbackInterface.OnW;
                @W.performed -= m_Wrapper.m_MiniGameActionsCallbackInterface.OnW;
                @W.canceled -= m_Wrapper.m_MiniGameActionsCallbackInterface.OnW;
                @S.started -= m_Wrapper.m_MiniGameActionsCallbackInterface.OnS;
                @S.performed -= m_Wrapper.m_MiniGameActionsCallbackInterface.OnS;
                @S.canceled -= m_Wrapper.m_MiniGameActionsCallbackInterface.OnS;
            }
            m_Wrapper.m_MiniGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Controls.started += instance.OnControls;
                @Controls.performed += instance.OnControls;
                @Controls.canceled += instance.OnControls;
                @Q.started += instance.OnQ;
                @Q.performed += instance.OnQ;
                @Q.canceled += instance.OnQ;
                @A.started += instance.OnA;
                @A.performed += instance.OnA;
                @A.canceled += instance.OnA;
                @W.started += instance.OnW;
                @W.performed += instance.OnW;
                @W.canceled += instance.OnW;
                @S.started += instance.OnS;
                @S.performed += instance.OnS;
                @S.canceled += instance.OnS;
            }
        }
    }
    public MiniGameActions @MiniGame => new MiniGameActions(this);

    // Interaction
    private readonly InputActionMap m_Interaction;
    private IInteractionActions m_InteractionActionsCallbackInterface;
    private readonly InputAction m_Interaction_Interaction;
    public struct InteractionActions
    {
        private @PlayerInputs m_Wrapper;
        public InteractionActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Interaction => m_Wrapper.m_Interaction_Interaction;
        public InputActionMap Get() { return m_Wrapper.m_Interaction; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InteractionActions set) { return set.Get(); }
        public void SetCallbacks(IInteractionActions instance)
        {
            if (m_Wrapper.m_InteractionActionsCallbackInterface != null)
            {
                @Interaction.started -= m_Wrapper.m_InteractionActionsCallbackInterface.OnInteraction;
                @Interaction.performed -= m_Wrapper.m_InteractionActionsCallbackInterface.OnInteraction;
                @Interaction.canceled -= m_Wrapper.m_InteractionActionsCallbackInterface.OnInteraction;
            }
            m_Wrapper.m_InteractionActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Interaction.started += instance.OnInteraction;
                @Interaction.performed += instance.OnInteraction;
                @Interaction.canceled += instance.OnInteraction;
            }
        }
    }
    public InteractionActions @Interaction => new InteractionActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IPlayerMovementActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
    public interface IMiniGameActions
    {
        void OnControls(InputAction.CallbackContext context);
        void OnQ(InputAction.CallbackContext context);
        void OnA(InputAction.CallbackContext context);
        void OnW(InputAction.CallbackContext context);
        void OnS(InputAction.CallbackContext context);
    }
    public interface IInteractionActions
    {
        void OnInteraction(InputAction.CallbackContext context);
    }
}
