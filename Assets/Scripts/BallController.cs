using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D _ballRigidbody2D;

    [SerializeField] private LayerMask _deathLayer;
    // Start is called before the first frame update
    void Start()
    {
        _ballRigidbody2D.velocity = Vector2.down * 10;
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (1 << other.gameObject.layer == _deathLayer)
        {
            GameManager.Instance.InvokeDeathState();
        }
    }
}
