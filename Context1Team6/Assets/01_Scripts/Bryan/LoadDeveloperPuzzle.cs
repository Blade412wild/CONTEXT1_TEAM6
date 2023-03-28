using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using _01_Scripts.Nathan.prototype.Dev_skills;

public class LoadDeveloperPuzzle : MonoBehaviour
{
    [SerializeField] private Canvas _canvas;
    private PlayerMovement devmovement;
    private puzzel1Input puzzel1;

    public GameObject GamepadCursorDoor;

    private void Start()
    {
        _canvas.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Developer>())
        {
            Debug.Log(other);
            devmovement = other.GetComponent<PlayerMovement>();
            Debug.Log("ontrigger " + devmovement);
            puzzel1 = _canvas.GetComponent<puzzel1Input>();
            Debug.Log(puzzel1);

            puzzel1.CanvasPlayermovement = devmovement;
            Debug.Log("puzzel1 " + puzzel1.CanvasPlayermovement);
            devmovement.enabled = false;

            _canvas.gameObject.SetActive(true);
            GamepadCursorDoor.SetActive(true);

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<Developer>())
        {
            _canvas.gameObject.SetActive(false);
        }
    }
}