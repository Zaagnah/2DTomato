using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurmMovePlatfOn : MonoBehaviour
{
    public GameObject obj;

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("adawd");
            obj.GetComponent<Oscillator>().gameObject.SetActive(true);
            
        }
    }
}
