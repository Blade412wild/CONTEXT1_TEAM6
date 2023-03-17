using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadDeveloperPuzzle : MonoBehaviour
{
    [SerializeField] private Canvas _canvas;

    private void Start()
    {
        _canvas.gameObject.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<Developer>())
        {
            _canvas.gameObject.SetActive(true);
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