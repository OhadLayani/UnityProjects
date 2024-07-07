﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    // This script is place on a projectile GameObject

    void Start()
    {
         // The projectile is deleted after 10 seconds, whether
         // or not it collided with anything (to prevent lost
         // instances sticking around in the scene forever)
         Destroy(gameObject,5);
    }
    void OnCollisionEnter()
    {
        Destroy(gameObject);
    }
}
