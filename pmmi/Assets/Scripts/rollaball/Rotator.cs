using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{

    float timeCounter = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Rotieren des Würfels
        //     - Vector3 enthält die Euler-Winkel der Rotation
        //     - Multipliziert mit Time.deltaTime damit unabhängig von der Frame Rate
        transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
    }
}
