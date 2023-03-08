using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine;

public class Artist : PlayerMovement
{
    private void Start()
    {
        SetCharacter();
    }

    private void SetCharacter()
    {
        //alle skills uitzetten
        this.transform.GetChild(0).gameObject.SetActive(false);
        this.transform.GetChild(1).gameObject.SetActive(false);
        this.transform.GetChild(2).gameObject.SetActive(false);
        this.transform.GetChild(3).gameObject.SetActive(false);

        // Artist aanzetten
        this.transform.GetChild(3).gameObject.SetActive(true);

    }

}
