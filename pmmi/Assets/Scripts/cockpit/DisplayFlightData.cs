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
    private FlyJoystick flyJoystick;

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
        string speedInfo = "Speed: " + Math.Round((airspeed*10 + 200), 0) + "km/h";

        textHeight.text = altInfo;
        textSpeed.text = speedInfo;
        
        warnImage.SetActive((altitude <= warningHeight));
    }
}
