// GENERATED AUTOMATICALLY FROM 'Assets/Input/Player.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class Player : IInputActionCollection, IDisposable
{
    private InputActionAsset asset;
    public Player()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Player"",
    ""maps"": [
        {
            ""name"": ""Gameplay"",
            ""id"": ""f1653a23-7f61-4082-b651-bcd4186f67c2"",
            ""actions"": [
                {
                    ""name"": ""Shoot"",
                    ""type"": ""Button"",
                    ""id"": ""c418b845-99d3-4f0f-8999-064faf9a0666"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""MoveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""b81cb9e3-f060-44bb-856b-23a5a2478f66"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""cb62629c-7936-4d97-ba01-d0ce0d76b66c"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""ReleaseLeft"",
                    ""type"": ""Button"",
                    ""id"": ""84b06a99-4407-453f-9e50-839cc6042834"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""ReleaseRight"",
                    ""type"": ""Button"",
                    ""id"": ""da2873f4-0ed5-4cea-bc3d-58920b4af5b2"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""ReleaseJump"",
                    ""type"": ""Button"",
                    ""id"": ""e231b652-4a8d-4df6-aa25-8072d6e62f1f"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""ReleaseShoot"",
                    ""type"": ""Button"",
                    ""id"": ""0c53ee15-f571-4eb5-8f5e-0adb14bcfb12"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press(behavior=1)""
                },
                {
                    ""name"": ""Escape"",
                    ""type"": ""Button"",
                    ""id"": ""00f3901c-801e-40e8-b7b6-c0b2f1191296"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""MoveRight"",
                    ""type"": ""Button"",
                    ""id"": ""aa83ffc2-08e0-4b8a-9efd-56f09a86fa36"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""33bc5433-ff6c-4a2e-9849-28fefb125378"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_1"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""11831034-e170-4056-81a1-e77232fe040f"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_2"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ace50ee5-207a-400f-8b57-03216e86f4e3"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_3"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4479c6f2-3fab-492f-95b8-e2cac606f7ae"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ShootButtonSwitched"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8b19afe-76f0-491d-837f-bd6072f2b2f3"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""RightHanded"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""33892e07-06b0-4b71-b50f-0f27e0c4f435"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard"",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""72d9a81a-d14f-492d-9d87-66ad5f15acd0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard;ShootButtonSwitched;RightHanded"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9dea5196-19d1-40d7-9df1-55f05e6fb89b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_1"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fcfd3fcc-5c53-4049-b762-09e9b32234bf"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_2"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b1c93cc-208b-42cf-8d0c-e22313f383b7"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_3"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""920b2a6d-50e8-4ff8-a54b-8c71fbd2af94"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Standard;ShootButtonSwitched;RightHanded"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f030b449-bde7-4059-8bb3-a379b0eaed45"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_1;Keyboard_3"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a1e0c0cf-34d2-4e2a-964b-5ee9a1f9b7cc"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_2"",
                    ""action"": ""MoveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""940850f9-386e-40b7-9553-516b84d84e68"",
                    ""path"": ""<Gamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard;ShootButtonSwitched;RightHanded"",
                    ""action"": ""ReleaseLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0d4a258d-e517-454b-8169-8ee4d775985f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_1;Keyboard_3"",
                    ""action"": ""ReleaseLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""99ffd46e-c0ff-49ff-9b87-522ccca99d02"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_2"",
                    ""action"": ""ReleaseLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ae1400ee-3ffb-4030-8efd-8a37e92eae6c"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard;ShootButtonSwitched;RightHanded"",
                    ""action"": ""ReleaseRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c9f0b001-2009-4889-82ec-b72fb42b3f0e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_1"",
                    ""action"": ""ReleaseRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57648b1f-283c-4067-bfa4-b878fe793de5"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_2"",
                    ""action"": ""ReleaseRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""19991851-7611-4886-ba9a-cc1940ca786f"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_3"",
                    ""action"": ""ReleaseRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2e926427-d854-445d-86fd-676f0f5046d6"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard;ShootButtonSwitched;RightHanded"",
                    ""action"": ""ReleaseJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c6023777-0018-4ada-8cdb-02a6d6b37f6b"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_1"",
                    ""action"": ""ReleaseJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b862b6da-c42e-4687-be79-fbfaf79bab18"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_2"",
                    ""action"": ""ReleaseJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""317af2e0-c78e-4b5a-88ff-024ba8127f38"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_3"",
                    ""action"": ""ReleaseJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6802526-28a5-49b7-b3e1-2471f779853e"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_1"",
                    ""action"": ""ReleaseShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1a4f1423-2529-486f-a29a-37885a56c849"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_2"",
                    ""action"": ""ReleaseShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ab6e70b8-0dfc-4c9c-b95c-121089fa3c5a"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_3"",
                    ""action"": ""ReleaseShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f8d2475e-1df3-4e48-9c86-e67940da1a67"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ShootButtonSwitched"",
                    ""action"": ""ReleaseShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b359f873-33b6-481e-8b73-7b28f4df6ff7"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""RightHanded"",
                    ""action"": ""ReleaseShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d85afcb7-1764-4b4f-b51a-5b488ec260b0"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard"",
                    ""action"": ""ReleaseShoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""88a9037d-9a30-4f29-ba82-69f1ba4ab89d"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Standard;ShootButtonSwitched;RightHanded"",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e49070fe-0b1e-4e06-a60a-9a229e656e9a"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_1;Keyboard_2;Keyboard_3"",
                    ""action"": ""Escape"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c883c9c1-ae25-476d-ac6c-b92755de9747"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ShootButtonSwitched"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""64c99302-597f-4187-bbe6-30ff808d5ad0"",
                    ""path"": ""<Gamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""ShootButtonSwitched;Standard;RightHanded"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""deb9dd98-74dc-40d9-934c-cc64de8ab93e"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_1;Keyboard_3"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58958f92-c676-4bf9-ada2-8b62b02ef10f"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard_2"",
                    ""action"": ""MoveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""77636fdb-b123-41fc-ab8d-da04fbd2dc30"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Value"",
                    ""id"": ""550a5c1b-9370-479f-b4ea-3a0e3acc0142"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""193e4dbf-47da-4996-8a5d-212873411c65"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""74bfcc01-71a7-40c5-87f4-de6983e27d71"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""UI_Keyboard"",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""9ef23fe1-b198-4b8c-8469-19c8ecaa44c8"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""UI_Keyboard"",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d61c684c-952d-4d2e-8aa9-f9805b090c87"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""UI_Keyboard"",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a7ee0d4f-c19c-4d91-8bbe-7f99ea60859c"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""UI_Keyboard"",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Standard"",
            ""bindingGroup"": ""Standard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""ShootButtonSwitched"",
            ""bindingGroup"": ""ShootButtonSwitched"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard_1"",
            ""bindingGroup"": ""Keyboard_1"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard_2"",
            ""bindingGroup"": ""Keyboard_2"",
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
            ""name"": ""Keyboard_3"",
            ""bindingGroup"": ""Keyboard_3"",
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
            ""name"": ""RightHanded"",
            ""bindingGroup"": ""RightHanded"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""UI_Keyboard"",
            ""bindingGroup"": ""UI_Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Gameplay
        m_Gameplay = asset.FindActionMap("Gameplay", throwIfNotFound: true);
        m_Gameplay_Shoot = m_Gameplay.FindAction("Shoot", throwIfNotFound: true);
        m_Gameplay_MoveLeft = m_Gameplay.FindAction("MoveLeft", throwIfNotFound: true);
        m_Gameplay_Jump = m_Gameplay.FindAction("Jump", throwIfNotFound: true);
        m_Gameplay_ReleaseLeft = m_Gameplay.FindAction("ReleaseLeft", throwIfNotFound: true);
        m_Gameplay_ReleaseRight = m_Gameplay.FindAction("ReleaseRight", throwIfNotFound: true);
        m_Gameplay_ReleaseJump = m_Gameplay.FindAction("ReleaseJump", throwIfNotFound: true);
        m_Gameplay_ReleaseShoot = m_Gameplay.FindAction("ReleaseShoot", throwIfNotFound: true);
        m_Gameplay_Escape = m_Gameplay.FindAction("Escape", throwIfNotFound: true);
        m_Gameplay_MoveRight = m_Gameplay.FindAction("MoveRight", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_Newaction = m_UI.FindAction("New action", throwIfNotFound: true);
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

    // Gameplay
    private readonly InputActionMap m_Gameplay;
    private IGameplayActions m_GameplayActionsCallbackInterface;
    private readonly InputAction m_Gameplay_Shoot;
    private readonly InputAction m_Gameplay_MoveLeft;
    private readonly InputAction m_Gameplay_Jump;
    private readonly InputAction m_Gameplay_ReleaseLeft;
    private readonly InputAction m_Gameplay_ReleaseRight;
    private readonly InputAction m_Gameplay_ReleaseJump;
    private readonly InputAction m_Gameplay_ReleaseShoot;
    private readonly InputAction m_Gameplay_Escape;
    private readonly InputAction m_Gameplay_MoveRight;
    public struct GameplayActions
    {
        private Player m_Wrapper;
        public GameplayActions(Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Shoot => m_Wrapper.m_Gameplay_Shoot;
        public InputAction @MoveLeft => m_Wrapper.m_Gameplay_MoveLeft;
        public InputAction @Jump => m_Wrapper.m_Gameplay_Jump;
        public InputAction @ReleaseLeft => m_Wrapper.m_Gameplay_ReleaseLeft;
        public InputAction @ReleaseRight => m_Wrapper.m_Gameplay_ReleaseRight;
        public InputAction @ReleaseJump => m_Wrapper.m_Gameplay_ReleaseJump;
        public InputAction @ReleaseShoot => m_Wrapper.m_Gameplay_ReleaseShoot;
        public InputAction @Escape => m_Wrapper.m_Gameplay_Escape;
        public InputAction @MoveRight => m_Wrapper.m_Gameplay_MoveRight;
        public InputActionMap Get() { return m_Wrapper.m_Gameplay; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameplayActions set) { return set.Get(); }
        public void SetCallbacks(IGameplayActions instance)
        {
            if (m_Wrapper.m_GameplayActionsCallbackInterface != null)
            {
                Shoot.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                Shoot.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                Shoot.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnShoot;
                MoveLeft.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveLeft;
                MoveLeft.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveLeft;
                MoveLeft.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveLeft;
                Jump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                Jump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                Jump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnJump;
                ReleaseLeft.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReleaseLeft;
                ReleaseLeft.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReleaseLeft;
                ReleaseLeft.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReleaseLeft;
                ReleaseRight.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReleaseRight;
                ReleaseRight.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReleaseRight;
                ReleaseRight.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReleaseRight;
                ReleaseJump.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReleaseJump;
                ReleaseJump.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReleaseJump;
                ReleaseJump.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReleaseJump;
                ReleaseShoot.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReleaseShoot;
                ReleaseShoot.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReleaseShoot;
                ReleaseShoot.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnReleaseShoot;
                Escape.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEscape;
                Escape.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEscape;
                Escape.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnEscape;
                MoveRight.started -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveRight;
                MoveRight.performed -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveRight;
                MoveRight.canceled -= m_Wrapper.m_GameplayActionsCallbackInterface.OnMoveRight;
            }
            m_Wrapper.m_GameplayActionsCallbackInterface = instance;
            if (instance != null)
            {
                Shoot.started += instance.OnShoot;
                Shoot.performed += instance.OnShoot;
                Shoot.canceled += instance.OnShoot;
                MoveLeft.started += instance.OnMoveLeft;
                MoveLeft.performed += instance.OnMoveLeft;
                MoveLeft.canceled += instance.OnMoveLeft;
                Jump.started += instance.OnJump;
                Jump.performed += instance.OnJump;
                Jump.canceled += instance.OnJump;
                ReleaseLeft.started += instance.OnReleaseLeft;
                ReleaseLeft.performed += instance.OnReleaseLeft;
                ReleaseLeft.canceled += instance.OnReleaseLeft;
                ReleaseRight.started += instance.OnReleaseRight;
                ReleaseRight.performed += instance.OnReleaseRight;
                ReleaseRight.canceled += instance.OnReleaseRight;
                ReleaseJump.started += instance.OnReleaseJump;
                ReleaseJump.performed += instance.OnReleaseJump;
                ReleaseJump.canceled += instance.OnReleaseJump;
                ReleaseShoot.started += instance.OnReleaseShoot;
                ReleaseShoot.performed += instance.OnReleaseShoot;
                ReleaseShoot.canceled += instance.OnReleaseShoot;
                Escape.started += instance.OnEscape;
                Escape.performed += instance.OnEscape;
                Escape.canceled += instance.OnEscape;
                MoveRight.started += instance.OnMoveRight;
                MoveRight.performed += instance.OnMoveRight;
                MoveRight.canceled += instance.OnMoveRight;
            }
        }
    }
    public GameplayActions @Gameplay => new GameplayActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private IUIActions m_UIActionsCallbackInterface;
    private readonly InputAction m_UI_Newaction;
    public struct UIActions
    {
        private Player m_Wrapper;
        public UIActions(Player wrapper) { m_Wrapper = wrapper; }
        public InputAction @Newaction => m_Wrapper.m_UI_Newaction;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void SetCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterface != null)
            {
                Newaction.started -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                Newaction.performed -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
                Newaction.canceled -= m_Wrapper.m_UIActionsCallbackInterface.OnNewaction;
            }
            m_Wrapper.m_UIActionsCallbackInterface = instance;
            if (instance != null)
            {
                Newaction.started += instance.OnNewaction;
                Newaction.performed += instance.OnNewaction;
                Newaction.canceled += instance.OnNewaction;
            }
        }
    }
    public UIActions @UI => new UIActions(this);
    private int m_StandardSchemeIndex = -1;
    public InputControlScheme StandardScheme
    {
        get
        {
            if (m_StandardSchemeIndex == -1) m_StandardSchemeIndex = asset.FindControlSchemeIndex("Standard");
            return asset.controlSchemes[m_StandardSchemeIndex];
        }
    }
    private int m_ShootButtonSwitchedSchemeIndex = -1;
    public InputControlScheme ShootButtonSwitchedScheme
    {
        get
        {
            if (m_ShootButtonSwitchedSchemeIndex == -1) m_ShootButtonSwitchedSchemeIndex = asset.FindControlSchemeIndex("ShootButtonSwitched");
            return asset.controlSchemes[m_ShootButtonSwitchedSchemeIndex];
        }
    }
    private int m_Keyboard_1SchemeIndex = -1;
    public InputControlScheme Keyboard_1Scheme
    {
        get
        {
            if (m_Keyboard_1SchemeIndex == -1) m_Keyboard_1SchemeIndex = asset.FindControlSchemeIndex("Keyboard_1");
            return asset.controlSchemes[m_Keyboard_1SchemeIndex];
        }
    }
    private int m_Keyboard_2SchemeIndex = -1;
    public InputControlScheme Keyboard_2Scheme
    {
        get
        {
            if (m_Keyboard_2SchemeIndex == -1) m_Keyboard_2SchemeIndex = asset.FindControlSchemeIndex("Keyboard_2");
            return asset.controlSchemes[m_Keyboard_2SchemeIndex];
        }
    }
    private int m_Keyboard_3SchemeIndex = -1;
    public InputControlScheme Keyboard_3Scheme
    {
        get
        {
            if (m_Keyboard_3SchemeIndex == -1) m_Keyboard_3SchemeIndex = asset.FindControlSchemeIndex("Keyboard_3");
            return asset.controlSchemes[m_Keyboard_3SchemeIndex];
        }
    }
    private int m_RightHandedSchemeIndex = -1;
    public InputControlScheme RightHandedScheme
    {
        get
        {
            if (m_RightHandedSchemeIndex == -1) m_RightHandedSchemeIndex = asset.FindControlSchemeIndex("RightHanded");
            return asset.controlSchemes[m_RightHandedSchemeIndex];
        }
    }
    private int m_UI_KeyboardSchemeIndex = -1;
    public InputControlScheme UI_KeyboardScheme
    {
        get
        {
            if (m_UI_KeyboardSchemeIndex == -1) m_UI_KeyboardSchemeIndex = asset.FindControlSchemeIndex("UI_Keyboard");
            return asset.controlSchemes[m_UI_KeyboardSchemeIndex];
        }
    }
    public interface IGameplayActions
    {
        void OnShoot(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnReleaseLeft(InputAction.CallbackContext context);
        void OnReleaseRight(InputAction.CallbackContext context);
        void OnReleaseJump(InputAction.CallbackContext context);
        void OnReleaseShoot(InputAction.CallbackContext context);
        void OnEscape(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnNewaction(InputAction.CallbackContext context);
    }
}
