using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloudsMove : MonoBehaviour
{
    public float moveSpeed = 5;
    static public bool canMove = false;


    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime, Space.World);
        if (canMove == true)
        {
            transform.Translate(Vector3.left * Time.deltaTime);
        }
    }
            
        
    
}
