using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balll : MonoBehaviour

{
    private Rigidbody2D rb2d;
    public int speed = 30;
    public void Start()
    {
        // Initial Velocity
        GetComponent<Rigidbody2D>().velocity = Vector2.right * speed;
    }
    void GoBall()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb2d.AddForce(new Vector2(20, -15));
        }
        else
        {
            rb2d.AddForce(new Vector2(-20, -15));
        }
    }
}
