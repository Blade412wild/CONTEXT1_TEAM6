using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DesignerCube : MonoBehaviour
{
    public bool IsOcuppied;
    private GameObject player;

    public bool Change;
    private void OnTriggerEnter(Collider other)
    {
        if (IsOcuppied == false)
        {
            IsOcuppied = true;
            player = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        IsOcuppied = false;

    }
    private void Update()
    {
        if (Change == true)
        {
            Debug.Log("Changed to designer");
            CharacterChange();

        }
    }

    public void CharacterChange()
    {
        var Developer = player.GetComponent<Developer>();
        var Artist = player.GetComponent<Artist>();
        var Designer = player.GetComponent <Designer>();

        if (Developer == true || Artist == true || Designer == true)
        {
            Destroy(Developer);
            Destroy(Artist);
            Destroy(Designer);
            player.AddComponent<Designer>();
        }
        else
        {
            player.AddComponent<Designer>();
        }

        IsOcuppied = false;


    }

}
