using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject DoorPrefab;
    public puzzel1Input Puzzel1Input;


    [SerializeField] private float _heightChangeForLerp;

    private Vector3 _startPos;
    private Vector3 _endPos;
    private float _moveOverSeconds = 3f;
    private float _elapsedTime;
    private bool isOccupied;

    // Start is called before the first frame update
    void Start()
    {
        _startPos = DoorPrefab.transform.position; //Transform van waar dit script aan vast zit.
    }

    // Update is called once per frame
    void Update()
    {
        if (Puzzel1Input.Passed == true && isOccupied == true)
        {
            MoveGameObject();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        isOccupied = true;
    }

    private void OnTriggerExit(Collider other)
    {
        isOccupied = false;
    }

    private void MoveGameObject()
    {
        //Verander de Y-waarde naar hoeveel "afstand" het gameObject moet bewegen in de Y-as.
        //Voor X en Z moet je hetzelfde doen, mocht je de deur niet willen laten openen langs de y-as.
        Vector3 _endPos = new Vector3(transform.position.x, _heightChangeForLerp, transform.position.z);

        _elapsedTime = _elapsedTime + Time.deltaTime;

        float percentageComplete = _elapsedTime / _moveOverSeconds;

        DoorPrefab.transform.position = Vector3.Lerp(_startPos, _endPos, percentageComplete);
    }
}
