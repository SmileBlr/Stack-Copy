﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePart : MonoBehaviour
{
    public float moveSpeed;



    void Update()
    {
        transform.position += transform.forward * Time.deltaTime * moveSpeed;
    }
}
