using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class incl_update : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.rotation = player.transform.rotation;
        transform.Rotate(-90, 0, 90);
    }
}
