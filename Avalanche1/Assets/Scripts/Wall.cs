using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    GameObject pauseObjects;
    

    // Start is called before the first frame update
    void Start()
    {
        pauseObjects = GameObject.FindGameObjectWithTag("ShowOnPaused");
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collided");
        pauseObjects.SetActive(true);
    }
}
