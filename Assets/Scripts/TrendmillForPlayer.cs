using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrendmillForPlayer : MonoBehaviour
{

    private bool collided = true;  
    private Rigidbody2D rigidb2d;
    public Transform collisionCheck;
    public float move;

    // Use this for initialization
    void Start()
    {
        rigidb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        collided = Physics2D.Linecast(transform.position, collisionCheck.position, 1 << LayerMask.NameToLayer("Trendmill"));
        
        if (collided)
            rigidb2d.AddForce(Vector2.right * 1 * move);
        
    }
}