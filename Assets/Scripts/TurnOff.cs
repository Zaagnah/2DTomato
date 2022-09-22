using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class TurnOff : MonoBehaviour
{
    
    public Animator anim;
    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    public GameObject box4;
    public GameObject box5;
    public GameObject box6;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        anim.Play("CrankAnim");
        box1.SetActive(false);
        box2.SetActive(false);
        box3.SetActive(false);
        box4.SetActive(false);
        box5.SetActive(false);
        box6.SetActive(false);
        

    }

}


