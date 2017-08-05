using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPortalScript : MonoBehaviour {
    public GameObject exit;

    void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.position = exit.transform.position;
    }

}
