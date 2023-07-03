using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateSelfWorld : MonoBehaviour
{
    float m_Speed;
    public bool m_WorldSpace;

    void Start()
    {
        //Set the speed of the rotation
        m_Speed = 20.0f;
        //Rotate the GameObject a little at the start to show the difference between Space and Local
        
        transform.Rotate(30, 0, 0, Space.World);
    }

    void Update()
    {
        /*
        //Rotate the GameObject in World Space if in the m_WorldSpace state
        if (m_WorldSpace)
            transform.Rotate(Vector3.up * m_Speed * Time.deltaTime, Space.World);
        //Otherwise, rotate the GameObject in local space
        else
            transform.Rotate(Vector3.up * m_Speed * Time.deltaTime, Space.Self);

        //Press the Space button to switch between world and local space states
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //Make the current state switch to the other state
            m_WorldSpace = !m_WorldSpace;
            //Output the Current state to the console
            Debug.Log("World Space : " + m_WorldSpace.ToString());
        }
        */

        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(30, 0, 0, Space.World);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Rotate(30, 0, 0, Space.Self);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(0, 30, 0, Space.World);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            transform.Rotate(0, 30, 0, Space.Self);
        }
    }

}
