using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoBetweenWayPoints : MonoBehaviour
{
    public Transform[] wayPoints;
    private int currentWayPoint = 0;
    private int forwardBackward = 0; //0 for forward, 1 for backward
    private float speed = 10f;

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = wayPoints[currentWayPoint].position - transform.position;

        if(direction.magnitude < 1)
        {
            findIndex();
        }
        transform.position += direction.normalized * speed * Time.deltaTime;
    }

    private void findIndex()
    {
        if(forwardBackward == 0)
        {
            if (currentWayPoint == wayPoints.Length - 1)
            {
                forwardBackward = 1;
                currentWayPoint -= 1;
            }
            else
                currentWayPoint += 1;
        }
        else
        {
            if (currentWayPoint == 0)
            {
                forwardBackward = 0;
                currentWayPoint += 1;
            }
            else
                currentWayPoint -= 1;
        }
    }
}
