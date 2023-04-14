using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyJoystick : MonoBehaviour
{
    public float speed;
    public float speedAmplifier;
    public float rotationSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float inputRoll = Input.GetAxis("Roll");
        float rollAngle = inputRoll * Time.deltaTime * rotationSpeed;

        float inputPitch = Input.GetAxis("Pitch");
        float pitchAngle = inputPitch * Time.deltaTime * rotationSpeed;
        
        float inputYaw = Input.GetAxis("Yaw");
        float yawAngle = inputYaw * Time.deltaTime * rotationSpeed;

        this.transform.Rotate(pitchAngle, yawAngle, rollAngle);


        float inputThrottle = Input.GetAxis("Throttle");
        speed = (2-(inputThrottle+1)) * speedAmplifier + 5;

        this.transform.Translate (Vector3.forward * speed * Time.deltaTime);
    }
}
