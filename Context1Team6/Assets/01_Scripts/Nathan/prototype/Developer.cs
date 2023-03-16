using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Developer : PlayerMovement
{  
    void Start()
    {
        SetCharacter();    }

    private void SetCharacter()
    {
        //alle skills uitzetten
        this.transform.GetChild(0).gameObject.SetActive(false);
        this.transform.GetChild(1).gameObject.SetActive(false);
        this.transform.GetChild(2).gameObject.SetActive(false);
        this.transform.GetChild(3).gameObject.SetActive(false);

        // Artist aanzetten
        this.transform.GetChild(1).gameObject.SetActive(true);

    }


}
