using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public bool keyboard;
    public GameObject ball;
    private Rigidbody rb;
    private int fail_count;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        fail_count = 0;
    }

    // FixedUpdate is better for physics simulation
    void FixedUpdate()
    {
        if (keyboard)
        {
            // Abfrage der Eingaben der Pfeiltasten
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");

            // Vektor der gerichteten Kraft auf das Objekt
            var movement = new Vector3(moveHorizontal, 0f, moveVertical);

            // Anwendung der Kraft auf GameObject
            rb.AddForce(movement * speed, ForceMode.Force);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        // Prüfung auf das Tag "Pick Up"
        if (other.gameObject.CompareTag("Pick Up"))
        {
            // Dekativieren des jeweiligen Pick Up
            other.gameObject.SetActive(false);
            fail_count = 0;
        }

        // Prüfung auf das Tag "No Pick Up"
        if (other.gameObject.CompareTag("No Pick Up"))
        {
            fail_count += 1;

            // 2x hintereinander ein "Non-Pick Up" berührt
            // -> Board verloren (Ball wegnehmen)
            if(fail_count >= 2)
            {
                ball.SetActive(false);
            }
        }
    }
}
