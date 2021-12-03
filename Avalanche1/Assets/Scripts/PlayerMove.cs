using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public float speed;
    Rigidbody rb;
    GameObject Player;
    public AudioClip collect;
    GameObject[] Wall;
    
    new AudioSource audio;
    
    
    

    void Start()
    {
        Wall = GameObject.FindGameObjectsWithTag("Wall");
        audio = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        
    }
    private void Update()
    {
        float moveH = Input.GetAxis("Horizontal");
        float moveV = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(-moveV, 0.0f, moveH);
        

        rb.AddForce(movement * speed);


    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag == "Ground" && rb.velocity.magnitude > 0)
        {
            transform.localScale += new Vector3(0.02f, 0.02f, 0.02f);
        }


    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Trigger")
        {
            audio.clip = collect;
            audio.Play();
        }
       
        
            
        


    }

    private void OnTriggerEnter(Collider other)
    {
        if (gameObject.tag == "Wall")
        {
            Debug.Log("Collided");
            

        }
    }





}

