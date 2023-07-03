using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontOrBehind : MonoBehaviour
{
    public Transform youTrans;
    public Transform enemyTrans;

    void Update()
    {
        //Your forward vector
        Vector3 youForward = youTrans.forward;

        //The vector from you to the enemy
        Vector3 youToEnemy = enemyTrans.position - youTrans.position;

        //Now we need to figure out if these vectors are pointing in the opposite direction, if so
        //the enemy is behind you. To do that we will use the dot product
        //Unity's built in version:
        //float dotProduct = Vector3.Dot(youForward.normalized, youToEnemy.normalized);
        //Our own version, which is the same:
        float dotProduct = DotProduct(youForward, youToEnemy);

        //For normalized vectors the dot product returns: 
        // 1 if they point in exactly the same direction, 
        //-1 if they point in completely opposite directions 
        // 0 if the vectors are perpendicular
        //But normalization takes some computer time, so you can ignore it if you are just interested
        //in knowing if the enemy is behind you and your field-of-view is 90 degrees
        //Otherwise you have to normalize the vectors and define "in front" as something like > 0.5
        if (dotProduct >= 0f)
        {
            Debug.Log("In front");
        }
        else
        {
            Debug.Log("Behind");
        }
    }

    float DotProduct(Vector3 vec1, Vector3 vec2)
    {
        float dotProduct = vec1.x * vec2.x + vec1.y * vec2.y + vec1.z * vec2.z;

        return dotProduct;
    }
}

