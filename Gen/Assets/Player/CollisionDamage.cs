﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDamage : MonoBehaviour
{
    public int damage = 10;
    public string collisionTag;

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == collisionTag)
        {
            Health health = collision.gameObject.GetComponent<Health>();
            Debug.Log("Error");
            gameObject.GetComponent<Health>().TakeHit(damage);
        }
    }
}