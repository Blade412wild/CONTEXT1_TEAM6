using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerControls input;

    // Start is called before the first frame update
    void Awake()
    {
        input = new PlayerControls();
        input.Player.MiniMenu.performed += ctx => { OpenMiniMenu(); };
        input.MiniMenu.Playing.performed += ctx => { PlayTime(); };
        //input.Player.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OpenMiniMenu()
    {
        input.Player.Disable();
        input.MiniMenu.Enable();

        Debug.Log("openMenu amd inputPlayer disabled");
    }

    public void PlayTime()
    {
        input.Player.Enable();
        input.MiniMenu.Disable();

        Debug.Log("Playing amd inputPlayer enabled");

    }






}
