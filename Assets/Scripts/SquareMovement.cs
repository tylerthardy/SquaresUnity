using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareMovement : MonoBehaviour {
    
    public int moveDirection;
    public int axis;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {  
        Move();
    }

    private void Move()
    {
        float x = axis == 1 ? (GameMaster.speed * (moveDirection == 0 ? 1 : -1) * Time.deltaTime) : 0;
        float y = axis == 0 ? (GameMaster.speed * (moveDirection == 0 ? 1 : -1) * Time.deltaTime) : 0;
        transform.Translate(new Vector3(x, y, 0), Space.World);
    }
}
