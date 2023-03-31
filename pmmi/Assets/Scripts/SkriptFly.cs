using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkriptFly : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)) {
            this.transform.Translate (Vector3.forward * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A)) {
            this.transform.Rotate(0.0f, 1.0f, 0.0f);
        }
        if(Input.GetKey(KeyCode.S)) {
            this.transform.Translate (Vector3.back * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D)) {
            this.transform.Rotate(0.0f, -1.0f, 0.0f);
        }
        if(Input.GetKey(KeyCode.Q)) {
            this.transform.Translate (Vector3.down * speed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A)) {
            this.transform.Translate (Vector3.up * speed * Time.deltaTime);
        }
    }
}
