﻿using UnityEngine;
using System.Collections;

public class Rotator : MonoBehaviour {

    void Update () 
    {
        transform.Rotate (new Vector3 (0, 180, 0) * Time.deltaTime);
    }
}