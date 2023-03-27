using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.InputSystem;

public class LoadDeveloperPuzzle : MonoBehaviour
{
    [SerializeField] private Canvas _canvas;

    public PlayerInput playerInput;

    private void Start()
    {
        _canvas.gameObject.SetActive(false);
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Developer>())
        {
            _canvas.gameObject.SetActive(true);
            playerInput = other.gameObject.GetComponentInChildren<PlayerInput>();
            Debug.Log(playerInput);

            playerInput.SwitchCurrentActionMap("UI");

            Debug.Log(playerInput.currentActionMap);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Developer>())
        {
            _canvas.gameObject.SetActive(false);
            playerInput.SwitchCurrentActionMap("Player");

            Debug.Log(playerInput.currentActionMap);

        }
    }
}