using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    public GameObject PlayerPrefab;
    PlayerMovement playerMovement;

    Vector3 startPos = new Vector3(0, 0, 0);    

    private void Awake()
    {
        if(PlayerPrefab != null)
        {
            playerMovement = GameObject.Instantiate(PlayerPrefab, startPos, transform.rotation).GetComponent<PlayerMovement>();
            transform.parent = playerMovement.transform;
        }
    }

    public void OnMove(InputAction.CallbackContext context)
    {
        playerMovement.OnMove(context);
    }

}
