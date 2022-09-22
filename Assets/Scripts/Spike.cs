﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag=="Player")
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        if (collision.gameObject.tag == "TriggerForSpikes")
        {
            Destroy(gameObject);
        }
    }

}
