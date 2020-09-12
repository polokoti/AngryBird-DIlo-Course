﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    public float Health = 50f;
    public UnityAction<GameObject> onEnemyDestroyed = delegate { };
    private bool _isHit = false;


    private void OnDestroy()
    {
        if(_isHit)
        {
            onEnemyDestroyed(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.GetComponent<Rigidbody2D>() == null) return;

        if (collision.gameObject.tag == "Bird")
        {
            _isHit = true;
            Destroy(gameObject);
        }

        else if (collision.gameObject.tag == "Obstacle")
        {
            // hitung damage yg diperoleh
            float damage = collision.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude * 10;
            Health -= damage;

            if (Health <= 0)
            {
                _isHit = true;
                Destroy(gameObject);
            }
        }
    }
}
