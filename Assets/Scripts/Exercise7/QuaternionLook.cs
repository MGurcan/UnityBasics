using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionLook : MonoBehaviour
{

    public Transform camTransform;
    // Start is called before the first frame update
    void Start()
    {
        camTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 directionToCamera = camTransform.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(directionToCamera, Vector3.up);

        transform.rotation = rotation;

        Quaternion rotation2 = Quaternion.Euler(0, 90, 0);

       // transform.rotation = rotation2;
    }
}
