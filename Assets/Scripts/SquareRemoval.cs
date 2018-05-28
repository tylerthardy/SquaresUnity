using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareRemoval : MonoBehaviour {

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "square")
        {

            float x = collision.bounds.center.x;
            float y = collision.bounds.center.y;

            SquareMovement movement = collision.gameObject.GetComponent<SquareMovement>();
            int axis = movement.axis;
            int moveDirection = movement.moveDirection;

            if ((axis == 0 && ((y > 0 && moveDirection == 0) || (y < 0 && moveDirection == 1))) ||
               (axis == 1 && ((x > 0 && moveDirection == 0) || (x < 0 && moveDirection == 1))) )
            {
                Destroy(collision.gameObject);
                return;
            }
        }
    }
}
