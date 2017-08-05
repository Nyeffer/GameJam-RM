using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrendmillFunction : MonoBehaviour {

    private bool grounded = true;
    private Rigidbody2D rb2d;
    public Transform groundCheck;
    public float moveSpeed;

	// Use this for initialization
	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        grounded = Physics2D.Linecast(transform.position, groundCheck.position, 1 << LayerMask.NameToLayer("Trendmill"));
        if (grounded)
            rb2d.AddForce(Vector2.right  * 1 * moveSpeed);
    }
}
