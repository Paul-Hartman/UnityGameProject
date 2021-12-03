using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public Transform ball;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
       

    
    
        transform.position = new Vector3(ball.localPosition.x, ball.localPosition.y + ball.localScale.y / 1.9f, ball.localPosition.z);
    }
    

}
