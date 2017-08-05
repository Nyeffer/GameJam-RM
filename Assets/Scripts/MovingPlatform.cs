using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private float useSpeed;
    private float speed;
    public float directSpeed = 9.0f;
    float origY;
    public float distance = 10.0f;

    private Rigidbody2D rb2d;

    // Use this for initialization
    void Start()
    {
        origY = transform.position.y;
        useSpeed = -directSpeed;

        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (origY - transform.position.y > distance)
        {
            useSpeed = directSpeed;
        }
        else if (origY - transform.position.y < -distance)
        {
            useSpeed = -directSpeed;
        }
        new Vector3(transform.position.x, speed, transform.position.z);

    }
}