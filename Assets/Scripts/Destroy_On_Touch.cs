using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_On_Touch : MonoBehaviour
{
    public AudioClip deathSound;
     void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == "Player")
        {
            Destroy(collider.gameObject);
            AudioSource.PlayClipAtPoint(deathSound, transform.position);
        }
    }
}
