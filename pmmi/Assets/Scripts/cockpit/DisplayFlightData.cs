using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DisplayFlightData : MonoBehaviour
{
    public TextMeshProUGUI textSpeed;
    public TextMeshProUGUI textHeight;
    public GameObject player;
    public float warningHeight;
    public GameObject warnImage;
    public AudioSource warnSound;
    private FlyJoystick flyJoystick;
    private bool warnImageState = false;
    private bool blinkActive = false;

    // Start is called before the first frame update
    void Start()
    {
        flyJoystick = player.GetComponent<FlyJoystick>();
    }

    // Update is called once per frame
    void Update()
    {
        float altitude = transform.position.y;
        float airspeed = flyJoystick.speed;

        string altInfo = "Alt: " + Math.Round(altitude, 0) + "m";
        string speedInfo = "Speed: " + Math.Round((airspeed * 10 + 200), 0) + "km/h";

        textHeight.text = altInfo;
        textSpeed.text = speedInfo;

        if (altitude <= warningHeight)
        {
            if (!blinkActive)
            {
                warnSound.Play();
                StopAllCoroutines();
                StartCoroutine("Blink");
                textHeight.color = Color.red;
                blinkActive = true;
            }
        }
        else
        {
            if (blinkActive)
            {
                warnSound.Stop();
                StopAllCoroutines();
                warnImage.SetActive(false);
                textHeight.color = Color.white;
                blinkActive = false;
            }
        }
    }


    IEnumerator Blink()
    {
        while (true)
        {
            warnImageState = !warnImageState;
            warnImage.SetActive(warnImageState);

            yield return new WaitForSeconds(0.5f);
        }
    }
}
