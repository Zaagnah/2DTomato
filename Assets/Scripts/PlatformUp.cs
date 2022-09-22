using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformUp : MonoBehaviour
{
    private Rigidbody2D rb2D;
    [SerializeField]
    private float thrust = 100.0f;

    private void Start()
    {
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rb2D.AddForce(transform.up * thrust, ForceMode2D.Impulse);
        }
        if (collision.gameObject.tag == "Spike")
        {
            Destroy(gameObject);
        }
    }
    
}
