using UnityEngine;

public class RunnerMovement : MonoBehaviour
{
    private float speed = 100f;
    CharacterController characterController;

    Rigidbody rb;
    void Start()
    {
        characterController = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = new Vector3 (x*speed, 0f,  z*speed);



        // Transform Position
        //transform.position += move * Time.deltaTime;

        // Character Controller
        //characterController.Move(move * Time.deltaTime);

        // Transform Translate
        transform.Translate(move * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.T))
            transform.Translate(new Vector3(10, 0, 0), Space.Self);
            //transform.Translate(new Vector3(10, 0, 0), Space.World);

        if (Input.GetKey(KeyCode.Space))
            rb.AddForce(new Vector3(0, 1, 0), ForceMode.Impulse);

        if(Input.GetKey(KeyCode.Alpha1))
            rb.AddForce(new Vector3(1, 0, 0), ForceMode.Impulse);
        if (Input.GetKey(KeyCode.Alpha2))
            rb.AddForce(new Vector3(0, 1, 0), ForceMode.Impulse);
        if (Input.GetKey(KeyCode.Alpha3))
            rb.AddForce(new Vector3(0, 0, 1), ForceMode.Impulse);
        if (Input.GetKey(KeyCode.Alpha4))
            rb.AddForce(new Vector3(1, 0, 0), ForceMode.Force);

          
        if (Input.GetKeyDown(KeyCode.X))
            transform.Translate(new Vector3(1, 0, 0), Space.Self);
        if (Input.GetKeyDown(KeyCode.C))
            transform.Translate(new Vector3(1, 0, 0), Space.World);
    }
}
