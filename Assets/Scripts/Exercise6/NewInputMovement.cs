using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewInputMovement : MonoBehaviour
{

    Player_FPS input_control;
    private float speed = 10f;
    private float jumpForce = 2f;
    Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        input_control = new Player_FPS();
        input_control.PlayerMap.Enable();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = input_control.PlayerMap.Movement.ReadValue<Vector2>();
        float jumpInput = input_control.PlayerMap.Jump.ReadValue<float>();

        transform.Translate(move.x * Time.deltaTime * speed, 0f, move.y * Time.deltaTime * speed);
        
        if(jumpInput > 0f)
        {
            Jump();
        }
        /*
        if(transform.position.y > 0f)
        {
            transform.Translate(0f, -9.81f * Time.deltaTime, 0f);
        }
        */
        Debug.Log(transform.position.y);
    }
    private void Jump()
    {
        rb.AddForce(0f, jumpForce, 0f, ForceMode.Impulse);
    }
}
