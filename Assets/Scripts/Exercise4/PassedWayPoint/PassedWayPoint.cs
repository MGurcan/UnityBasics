using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassedWayPoint : MonoBehaviour
{
        public Transform youTrans;
        public Transform waypointFromTrans;
        public Transform waypointToTrans;

        void Update()
        {
            //The vector between the character and the waypoint we are going from
            Vector3 a = youTrans.position - waypointFromTrans.position;

            //The vector between the waypoints
            Vector3 b = waypointToTrans.position - waypointFromTrans.position;

        //To know if we have passed the upcoming waypoint we need to find out how much of b is a1
        //a1 = (a.b / |b|^2) * b
        //a1 = progress * b -> progress = a1 / b -> progress = (a.b / |b|^2)


        Vector3 unitVectorB = b / b.magnitude;
        float aProjectileBLength = DotProduct(a, unitVectorB);


        if(aProjectileBLength > b.magnitude)
        {
            Debug.Log("Change waypoint mine");
        }
        else
        {
            Debug.Log("Move on mine");
        }
        
            float progress = (a.x * b.x + a.y * b.y + a.z * b.z) / (b.x * b.x + b.y * b.y + b.z * b.z);

            //If progress is above 1 we know we have passed the waypoint
            if (progress > 1.0f)
            {
                Debug.Log("Change waypoint");
            }
            else
            {
                Debug.Log("Move on");
            }

        }

        float DotProduct(Vector3 vec1, Vector3 vec2)
        {
            float dotProduct = vec1.x * vec2.x + vec1.y * vec2.y + vec1.z * vec2.z;

            return dotProduct;
        }
}

