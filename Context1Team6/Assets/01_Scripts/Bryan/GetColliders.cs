using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetColliders : MonoBehaviour
{
    [SerializeField] private List<GameObject> _list = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetCollidersOnGameobject();
    }

    private void GetCollidersOnGameobject()
    {
        var colls = gameObject.GetComponentsInChildren<Collider>();

        foreach (var collider in colls)
        {
            Debug.Log(collider);
            collider.enabled = false;
            
        }
    }
}
