using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DeveloperCube : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        var Developer = other.GetComponent<Developer>();
        var Artist = other.GetComponent<Artist>();
        var Designer = other.GetComponent<Designer>();

        if (Developer == true || Artist == true || Designer == true)
        {
            Destroy(Developer);
            Destroy(Artist);
            Destroy(Designer);
            other.AddComponent<Developer>();
        }
        else
        {
            other.AddComponent<Developer>();

        }


    }
}
