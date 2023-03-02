using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private Transform player1;
    private Vector3 gizmoPos;
    public float SmoothSpeed = 0.2f;
    public Vector3 Offset;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CameraStartDelay());
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(player1 != null && GameManager.Instance.PlayerList.Count < 2)
        {
            Vector3 desiredPosition = player1.transform.position + Offset;
            Vector3 SmoothPostion = Vector3.Lerp(transform.position, desiredPosition, SmoothSpeed * Time.deltaTime);
            transform.position = SmoothPostion;
            Debug.Log(gizmoPos);

        }

        else if(GameManager.Instance.PlayerList.Count >= 2)
        {
            Vector3 desiredPosition = FindCentroit() + Offset;
            Vector3 SmoothPostion = Vector3.Lerp(transform.position, desiredPosition, SmoothSpeed * Time.deltaTime);
            transform.position = SmoothPostion;
            gizmoPos = FindCentroit();
            Debug.Log(gizmoPos);
        }
    }
    IEnumerator CameraStartDelay()
    {
        yield return new WaitForSeconds(0.1f);
        player1 = GameManager.Instance.PlayerList[0].gameObject.transform;
        transform.position = player1.transform.position + Offset;
    }

    Vector3 FindCentroit()
    {
         var totalX = 0f;
         var totalY = 0f;    
         var totalZ = 0f;

        foreach(var player in GameManager.Instance.PlayerList)
        {
            totalX += player.transform.parent.transform.position.x;
            totalY += player.transform.parent.transform.position.y;
            totalZ += player.transform.parent.transform.position.z;
        }

        var centerX = totalX / GameManager.Instance.PlayerList.Count;
        var centerY = totalY / GameManager.Instance.PlayerList.Count;
        var centerZ = totalZ / GameManager.Instance.PlayerList.Count;

        return new Vector3(centerX, centerY, centerZ);

    }

    private void OnDrawGizmos()
    {
        Gizmos.DrawCube(gizmoPos, new Vector3(1, 1, 1));
    }

}
