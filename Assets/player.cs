using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{ 
    // Start is called before the first frame update
  
    public float speed = 30;
    public string axis;
    private void FixedUpdate()
    {
        //This is our GetAxisRaw input 
        float v = Input.GetAxisRaw(axis) * speed;
        //Just calling the Rigidbody2D component to change its Velocity value
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, v);
    }

    // Update is called once per frame
  
}
