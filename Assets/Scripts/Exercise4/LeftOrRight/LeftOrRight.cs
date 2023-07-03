using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftOrRight : MonoBehaviour
{
    public Transform youTrans;
    public Transform wayPointTrans;

    // Update is called once per frame
    void Update()
    {
        Vector3 forward = youTrans.forward;
        Vector3 direction = wayPointTrans.position - youTrans.position;

        Vector3 cross = Vector3.Cross(forward, direction);
        float dot = Vector3.Dot(cross, youTrans.up);

        if(dot > 0f)
        {
            Debug.Log("Go Left");
        }
        else
        {
            Debug.Log("Go Right");
        }
    }
}
