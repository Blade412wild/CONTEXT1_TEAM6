using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerControls input;


    // Start is called before the first frame update
    void Start()
    {
        input = new PlayerControls();

        input.Player.MiniMenu.performed += ctx => { MiniMenuActive(); };
        input.MiniMenu.Playing.performed += ctx => { Playing(); };
        input.Player.Enable();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MiniMenuActive()
    {
        input.Player.Disable();
        input.MiniMenu.Enable();

        Debug.Log("open Menu");
    }

    public void Playing()
    {
        input.Player.Enable();
        input.MiniMenu.Disable();
        Debug.Log("Back to Playing");
    }
}
