﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoltLogic : MonoBehaviour
{
    public Rigidbody rb;
    public float speed;
    void Start ()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }
}
