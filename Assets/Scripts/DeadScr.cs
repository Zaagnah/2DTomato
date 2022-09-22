using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeadScr : MonoBehaviour
{
    public Animation anim;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Spike":
                anim.Play("Dead");
                break;
        }

        
    }
}
