﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformDown : MonoBehaviour
{
    

    private void Update()
    {
        if(transform.position.y < -5f)
        {
            Destroy(gameObject);
        }
    }


}
