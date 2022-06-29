using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    public ParticleSystem particles;

    public Rigidbody2D body;

    public float moveSpeed = 10;
    public float jumpForce = 10;

    float horizontal;

    private Vector3 respawnPoint;

    public AudioClip deathSound;

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        respawnPoint = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");

        if(Input.GetKeyDown(KeyCode.Space))
        {
            body.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);

            particles.Play();
            
            Debug.Log("Is jumping");
        }

        else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow))
        {
            body.velocity = new Vector2(horizontal * moveSpeed, 0);
        }

        if(Input.GetKeyUp(KeyCode.Space))
        {
            particles.Stop();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "deathly_star")
        {
            transform.position = respawnPoint;
            AudioSource.PlayClipAtPoint(deathSound, transform.position);
        }
    }

}
