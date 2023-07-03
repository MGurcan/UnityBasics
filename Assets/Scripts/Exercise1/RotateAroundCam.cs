using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAroundCam : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 100;

    public GameObject mevlanaObject;
    // Update is called once per frame

    private Vector3[] rotation = new Vector3[3];
    private int rotationType = 0;

        private void Start()
    {
        rotation[0] = Vector3.up;
        rotation[1] = Vector3.right;
        rotation[2] = Vector3.forward;
    }
    void Update()
    {
        if(Input.GetKey(KeyCode.Space)){
            rotationType = (rotationType + 1) % rotation.Length;
        }
        mevlanaObject.transform.RotateAround(Camera.main.transform.position, rotation[rotationType], speed * Time.deltaTime);

    }
}
