using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBoundry : MonoBehaviour
{
    //public static float leftSide = -3.5f;
    //public static float rightSide = 3.5f;

    public static float leftSide = -2f;
    public static float rightSide = 6f;
    public float internalLeft;
    public float internalRight;

    void Update()
    {
        internalLeft = leftSide;
        internalRight = rightSide;
    }
}
