using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowballs : MonoBehaviour
{
    Rigidbody body;
    public Rigidbody snowballPrefab;
    public Transform spawner;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
        body = GetComponent<Rigidbody>();
        body.useGravity = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Player"||collision.transform.tag=="Snowball")
        {
            
            collision.transform.parent = collision.transform;
            Rigidbody snowballInstance;
            snowballInstance = Instantiate(snowballPrefab, spawner.position, spawner.rotation * Random.rotation) as Rigidbody;
            snowballInstance = Instantiate(snowballPrefab, spawner.position, spawner.rotation * Random.rotation) as Rigidbody;
            snowballInstance = Instantiate(snowballPrefab, spawner.position, spawner.rotation * Random.rotation) as Rigidbody;

            
            Debug.Log(spawner.childCount);
            
            Destroy(this.gameObject, .03f);

            




            body.useGravity=true;
            
        }
       

    }
    private void OnCollisionStay(Collision coll)
    {
        if (coll.gameObject.tag == "Ground" && body.velocity.magnitude > 0)
        {   
            
            transform.localScale += new Vector3(0.001f, 0.001f, 0.001f);
        }
    }
}
