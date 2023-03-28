using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
//using UnityEditor.PackageManager;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public GameObject[] SpawnPoints;

    public List<PlayerInput> PlayerList = new List<PlayerInput>();

    [SerializeField] private InputAction joinAction;
    [SerializeField] private InputAction leaveAction;

    //events
    public event System.Action<PlayerInput> PlayerJoinedGame;
    public event System.Action<PlayerInput> PlayerLeftGame;

    public int PlayerIndex;

    //instances 
    public static GameManager Instance = null;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != null)
        {
            Destroy(gameObject);
        }

        joinAction.Enable();
        joinAction.performed += context => JoinAction(context);

        leaveAction.Enable();
        leaveAction.performed += context => LeaveAction(context);

    }

    private void Start()
    {
        //SpawnPlayers();
    }

    void OnPlayerJoined(PlayerInput playerInput)
    {
        Debug.Log("onPlayerJoined");
        PlayerList.Add(playerInput);

        if (PlayerJoinedGame != null)
        {
            Debug.Log("PlayerJoinedGame != null");
            PlayerJoinedGame(playerInput);
        }
    }
    void OnPlayerleave(PlayerInput playerInput)
    {
        Debug.Log("Goodbye PLayer");
    }

    void JoinAction(InputAction.CallbackContext context)
    {
        PlayerInputManager.instance.JoinPlayerFromActionIfNotAlreadyJoined(context);
        Debug.Log("joined the game");
    }
    void LeaveAction(InputAction.CallbackContext context)
    {
        PlayerInputManager.instance.JoinPlayerFromActionIfNotAlreadyJoined(context);
        Debug.Log("left the game");

    }

    private void SpawnPlayers()
    {
        for (int i = 0; i < SpawnPoints.Length; i++)
        {
            Debug.Log(PlayerIndex + " PlayerIndex manager");
            PlayerInputManager.instance.JoinPlayer(PlayerIndex, -1, null);
            PlayerIndex++;
        }
    }


}
