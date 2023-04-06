using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchScene : MonoBehaviour
{
    public string scene;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.rotation.x > 0.12)
        {
            Debug.Log("Now I switch the scene...");
            SceneManager.LoadScene(scene);
        }
    }
}
