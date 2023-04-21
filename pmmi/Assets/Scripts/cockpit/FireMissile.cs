using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireMissile : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject missile;
    public GameObject bordkanone;

    private bool toggle = false;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject current_missile = Instantiate(missile, missile.transform.position, missile.transform.rotation);
            GameObject flamethrower = current_missile.transform.Find("FlameThrower").gameObject;
            flamethrower.SetActive(true);

            current_missile.GetComponent<Rigidbody>().useGravity = true;
        }
        
        if (Input.GetButtonDown("Fire2"))
        {
            toggle = !toggle;
            bordkanone.SetActive(toggle);
        }
    }
}
