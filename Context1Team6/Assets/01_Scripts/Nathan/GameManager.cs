using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public GameObject[] SpawnPoints; 


    //instances 
    public static GameManager Instance = null;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
        else if(Instance != null)
        {
            Destroy(gameObject);
        }

        SpawnPoints = GameObject.FindGameObjectsWithTag("SpawnPoint");

    }

    private void Start()
    {
        PlayerInputManager.instance.JoinPlayer(0, -1, null);
    }

    void OnPlayerJoined(PlayerInput playerInput)
    {
        Debug.Log("Hello PLayer");
    }
    void OnPlayerLeft(PlayerInput playerInput)
    {
        Debug.Log("Goodbye PLayer");
    }



}
