using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryPortalScript : MonoBehaviour {
    public GameObject exit;
    public Vector3 offset = new Vector3(2, 0, 0);

    void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.position = exit.transform.position + offset;
    }

}
