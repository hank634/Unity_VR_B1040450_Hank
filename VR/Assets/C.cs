﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class C : MonoBehaviour
{

    private Rigidbody rd;//刚体变量
    private int force = 5;//力量
                          // Use this for initialization
    void Start()
    {
        rd = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        rd.AddForce(new Vector3(h, 0, v) * 5);
    }

}
