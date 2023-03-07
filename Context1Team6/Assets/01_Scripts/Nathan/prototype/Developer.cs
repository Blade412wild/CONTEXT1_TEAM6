using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Developer : MonoBehaviour
{
    //Material DeveloperMaterial = GameAssets.Instance.Developer;
    Renderer PlayerRenderer;
    GameObject CurrentPlayer;
    GameObject DeveloperPrefab;

    // Start is called before the first frame update
    void Start()
    {
        //PlayerRenderer= gameObject.GetComponentInChildren<Renderer>();
        // PlayerRenderer.material= DeveloperMaterial;
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
        this.transform.GetChild(1).gameObject.SetActive(true);

    }


}
