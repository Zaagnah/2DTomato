using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTrigger : MonoBehaviour
{
     public Rigidbody2D rig2d;

    //private void Start()
    //{
    //    rig2d = GetComponent<Rigidbody2D>();
    //}

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if(collision.gameObject.tag == "Player")
    //    {
    //        rig2d.isKinematic = false;
    //    }

    //    //if(collision.gameObject.tag == "Spike")
    //    //{
    //    //    Destroy(gameObject);
    //    //}
    //}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rig2d.isKinematic = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            rig2d.isKinematic = false;
        }
    }

}
