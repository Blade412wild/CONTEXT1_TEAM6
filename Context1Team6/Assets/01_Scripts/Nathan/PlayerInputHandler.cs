using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    public GameObject PlayerPrefab;
    PlayerMovement playerMovement;

    private void Awake()
    {
        if(PlayerPrefab != null)
        {
            playerMovement = PlayerPrefab.GetComponent<PlayerMovement>();
        }
    }

    void OnMove(InputAction.CallbackContext context)
    {
        PlayerMovement.OnMove(context);
    }

}
