﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }
}
