using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnowballPrefab : MonoBehaviour
{   
    Rigidbody rb;
    
   
    


    // Start is called before the first frame update
    void Start()
    {   
      rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionStay(Collision coll)
    {
        if (coll.gameObject.tag == "Ground"&&rb.velocity.magnitude > 0)
        {
            transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
        }
       
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Snowball")
        {
            rb.AddForce(100f, 0f, 0f);
        }
    }

}
