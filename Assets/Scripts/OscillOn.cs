using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OscillOn : MonoBehaviour
{

    public Animator anim;
    public GameObject obj;
    public Oscillator script_1;

    void Start()
    {
        script_1 = obj.GetComponent<Oscillator>();

    }

   
    private void OnCollisionEnter2D(Collision2D collision)
    {
        anim.Play("CrankAnim");
        script_1.enabled = true;
    }
}
