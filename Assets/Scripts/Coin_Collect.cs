using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin_Collect : MonoBehaviour
{
    public static int totalCoins = 0;
    public AudioClip coinSound;

    void Awake()
    {
        GetComponent<Collider2D>().isTrigger = true;    
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.CompareTag("Player"))
        {
            totalCoins++;
            Debug.Log("You currently have " + Coin_Collect.totalCoins + "Coins.");

            AudioSource.PlayClipAtPoint(coinSound, transform.position);
            Destroy(gameObject);
        }  

    }
}
