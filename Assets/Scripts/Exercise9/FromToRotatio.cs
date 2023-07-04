using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FromToRotatio : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation = Quaternion.Euler(30, 30, 30);
    }

    // Update is called once per frame

    
    void Update()
    {
        Vector3  directionToCamera = Camera.main.transform.position - transform.position;
        Quaternion rotationToCamera = Quaternion.FromToRotation(Vector3.forward, directionToCamera);

        transform.rotation = rotationToCamera;
    }
}
