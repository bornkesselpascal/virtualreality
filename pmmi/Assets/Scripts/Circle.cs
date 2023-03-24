using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : MonoBehaviour
{
    Vector3 pointA;
    Vector3 pointB;
    public float speed = 0.5f;
    public bool x_movement = false;

    // Start is called before the first frame update
    void Start()
    {
        pointA = transform.localPosition;
        pointB = transform.localPosition;
        if(x_movement)
        {
            pointB.x = -pointB.x;
        }
        else
        {
            pointB.z = -pointB.z;
        }
    }

    // Update is called once per frame
    void Update()
    {
        // Instead of doing a circle, we move the object back and forth
        // TODO - Rename Script
        float time = Mathf.PingPong(Time.time * speed, 1);
        transform.localPosition = Vector3.Lerp(pointA, pointB, time);
    }
}
