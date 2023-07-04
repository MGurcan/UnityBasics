using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindRotateWay : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform tank;
    public Transform target;

    // Update is called once per frame
    void Update()
    {
        Vector3 tankForward = tank.forward;
        Vector3 tankToTarget = target.position - tank.forward;

        Vector3 cross = Vector3.Cross(tankForward, tankToTarget);

        float dot = Vector3.Dot(cross, tank.up);

        if(dot > 0.0f)
        {
            Debug.Log("Sola çevir");
        }
        else
        {
            Debug.Log("Saga çevir");
        }
    }
}
