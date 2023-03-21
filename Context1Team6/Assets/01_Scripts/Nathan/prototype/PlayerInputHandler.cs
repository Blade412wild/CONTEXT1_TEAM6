using System.Collections;
using System.Collections.Generic;
using _01_Scripts.Bryan;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    public GameObject PlayerPrefab;
    PlayerMovement playerMovement;

    private DesignerSkill _designerSkill;

    Vector3 startPos = new Vector3(0, 0, 0);

    private void Awake()
    {
        var GameManager = GameObject.FindAnyObjectByType<GameManager>();
        PlayerInputManager PlayerManager = GameManager.GetComponent<PlayerInputManager>();

        int PlayerIndex = PlayerManager.playerCount - 1;
        SpawnPlayers(PlayerIndex);

    }

    public void OnMove(InputAction.CallbackContext context)
    {
        playerMovement.OnMove(context);
    }

    public void Jump(InputAction.CallbackContext context)
    {

        playerMovement.Jump(context);

    }

    private void SpawnPlayers(int index)
    {
        if (PlayerPrefab != null)
        {
            playerMovement = GameObject.Instantiate(PlayerPrefab, GameManager.Instance.SpawnPoints[index].transform.position, transform.rotation).GetComponent<PlayerMovement>();
            transform.parent = playerMovement.transform;
            transform.position = playerMovement.transform.position;
        }
    }

}
