using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using DG.Tweening;
using System;
using Unity.VisualScripting;

public class DragDrop : MonoBehaviour
{
    [SerializeField] 
    private GameObject dragDropPrefab;
    [SerializeField]
    private bool isDragAble;
    private GamepadCursor gamepadCursor;

    private void OnEnable()
    {
        isDragAble = false; 
        gamepadCursor = new GamepadCursor();
    }

    void Update()
    {
        Debug.Log(gamepadCursor.anchoredPostion + "drag");
    }

    public void PickUpObject(Vector2 anchoredPostion)
    {
        IsDragAble(anchoredPostion);
        OnDrag();

    }

    private void OnDrag()
    {
    }

    private void IsDragAble(Vector2 anchoredPostion)
    {

        // schiet een raycast op zijn posititie  en dat wordt dan de de dragDropPrefab;

        if (dragDropPrefab.GetComponent<DragObject>())
        {
            isDragAble = true;
        }
        else
        {
            isDragAble = false;
        }
    }
}



