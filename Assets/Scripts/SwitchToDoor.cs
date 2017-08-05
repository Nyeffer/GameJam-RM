using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchToDoor : MonoBehaviour {

    private bool hitWithPlayer = false;
    private bool doorActive = true;
    private bool IsCreated = false;
    private Renderer rend;
    public Transform collisionCheck;
    public Material switchOn;
    public Material switchOff;
    public GameObject reaction;
    public GameObject replacement;



	// Use this for initialization
	void Start ()
    {
        rend = GetComponent<Renderer>();
        
	}
	
	// Update is called once per frame
	void Update ()
    {
        hitWithPlayer = Physics2D.Linecast(transform.position, collisionCheck.position, 1 << LayerMask.NameToLayer("Player"));
        if(hitWithPlayer)
        {
            
            rend.material = switchOn;
            Destroy(reaction);
            doorActive = false;
        }
        if (!hitWithPlayer && !doorActive && !IsCreated)
        {
            Instantiate(replacement);
            IsCreated = true;
            rend.material = switchOff;
        }


    }
}