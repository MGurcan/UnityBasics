using UnityEngine;

public class FollowTargetObject : MonoBehaviour
{
    public GameObject targetObject;
    private float speed = 10f;

    private float wayLength;
    private float currentWayLength;

    private float totalTime= 0;

    private Vector3 startPosition;
    private Vector3 targetPosition;
    private void Start()
    {
        startPosition = transform.position;
        targetPosition = targetObject.transform.position;
        Vector3 startDirection = targetObject.transform.position - transform.position;
        wayLength = startDirection.magnitude;
    }
    void Update()
    {

        /*
        Vector3 direction = targetObject.transform.position - transform.position;

        if(direction.magnitude > 3)
            transform.position += direction.normalized * speed * Time.deltaTime;
        else
            transform.RotateAround(targetObject.transform.position, Vector3.up, 10 * speed * Time.deltaTime);
        */

        // Using LERP
        totalTime += Time.deltaTime;
        currentWayLength = totalTime * speed;

        float ratio = currentWayLength / wayLength;
        if(ratio < 1/9)
            transform.position = Vector3.Lerp(startPosition, targetPosition, ratio);



    }
}
