using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CottageExplode : MonoBehaviour
{
    public Rigidbody wood1;
    public Rigidbody wood2;
    public Transform spawner;
    public bool interactable = false;
    public AudioClip destroy;
    new AudioSource audio;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (interactable)
        {
            
            Rigidbody woodInstance1;
            Rigidbody woodInstance2;
            woodInstance2 = Instantiate(wood2, spawner.position, spawner.rotation*Random.rotation) as Rigidbody;
            woodInstance1 = Instantiate(wood1, spawner.position, spawner.rotation*Random.rotation) as Rigidbody;
            woodInstance1.AddExplosionForce(100f,spawner.position, 50f,10f);
            woodInstance1.AddExplosionForce(100f, spawner.position, 50f, 10f);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player"|| other.gameObject.tag == "Snowball")
        {
            AudioSource.PlayClipAtPoint(destroy, transform.position);
            
            Destroy(this.gameObject, .03f);
            interactable = true;
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            interactable = false;
        }
    }
}
