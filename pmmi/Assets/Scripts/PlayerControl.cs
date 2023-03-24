using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
    public bool keyboard;
    public GameObject pick_ups;
    private Rigidbody rb;
    private int count;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
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
            count += 1;
        }

                // Prüfung auf das Tag "Pick Up"
        if (other.gameObject.CompareTag("No Pick Up"))
        {
            // Dekativieren aller Pick Ups
            pick_ups.SetActive(false);
        }
    }
}
