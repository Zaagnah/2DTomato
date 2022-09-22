using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformLeft : MonoBehaviour
{
    public Rigidbody2D rb2D;
    [SerializeField]
    private float thrust = 100.0f;

    

    //private void OnCollisionEnter2D (Collision2D collision)
    //{
    //    if (collision.gameObject.tag == "Player")
    //    {
    //        rb2D.AddForce(transform.forward * thrust, ForceMode2D.Impulse);
    //    }
    //    if (collision.gameObject.tag == "Spike")
    //    {
    //        Destroy(gameObject);
    //    }
    //}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rb2D.AddForce((transform.right * thrust)*-1, ForceMode2D.Impulse);
        }
        if (collision.gameObject.tag == "Spike")
        {
            Destroy(gameObject);
        }
    }
}
