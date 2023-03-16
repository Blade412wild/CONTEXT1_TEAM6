using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class puzzel1Input : MonoBehaviour
{
    public bool Passed;

    [Header("vragen")]
    [SerializeField]
    private TMPro.TMP_Dropdown vraag1;

    [SerializeField]
    private TMPro.TMP_Dropdown vraag2;

    [SerializeField]
    private TMPro.TMP_Dropdown vraag3;

    [SerializeField]
    private TMPro.TMP_Dropdown vraag4;

    [SerializeField]
    private TMPro.TMP_Dropdown vraag5;

    [Header("antwoorden")]
    [SerializeField]
    private int antwoord1Index;

    [SerializeField] 
    private int antwoord2Index;

    [SerializeField]
    private int antwoord3Index;

    [SerializeField]
    private int antwoord4Index;

    [SerializeField]
    private int antwoord5Index;

    private void Start()
    {
        Passed =  false;
    }

    private void Update()
    {
        if(vraag1.value == antwoord1Index && vraag2.value == antwoord2Index && vraag3.value == antwoord3Index && vraag4.value == antwoord4Index && vraag5.value == antwoord5Index)
        {
            Debug.Log("passed");
            Passed = true;
            vraag1.value = antwoord1Index + 1;
        }
        
    }

}
