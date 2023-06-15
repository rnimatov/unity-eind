using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotationbackground : MonoBehaviour
{
    public float rotatespeed = 1;
    void Update()
    {
        this.transform.Rotate(0, 0, rotatespeed, Space.World);
    }
}
