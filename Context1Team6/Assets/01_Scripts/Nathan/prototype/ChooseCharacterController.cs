using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChooseCharacterController : MonoBehaviour
{
    private DeveloperCube developerCube;
    private DesignerCube desingerCube;
    private ArtistCube artistCube;

    void Start()
    {
        desingerCube = this.gameObject.GetComponentInChildren<DesignerCube>();
        artistCube = this.gameObject.GetComponentInChildren<ArtistCube>();
        developerCube = this.gameObject.GetComponentInChildren<DeveloperCube>();

        developerCube.Change = false;
        desingerCube.Change = false;
        artistCube.Change = false;
    }

    void Update()
    {
        if (developerCube.IsOcuppied == true && desingerCube.IsOcuppied == true && artistCube.IsOcuppied == true)
        {
            Debug.Log("change Characters");

            developerCube.Change = true;
            desingerCube.Change = true;
            artistCube.Change = true;
        }
        else
        {
            //Debug.Log("Don't Change Characters");

            developerCube.Change = false;
            desingerCube.Change = false;
            artistCube.Change = false;
        }
    }
}