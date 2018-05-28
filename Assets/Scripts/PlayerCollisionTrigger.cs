using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollisionTrigger : MonoBehaviour
{
    public float growthPerSquare = 0.01f;
    public float speedPerSquare = 0.01f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject square = collision.gameObject;
        
        bool bad = square.GetComponent<SquareProperties>().bad;
        if (bad)
        {
            if (!GameMaster.invincible)
            {
                GameMaster.Lose();
            }
        }
        else
        {
            Destroy(square);
            GameMaster.AddToScore(10);
            this.transform.localScale += new Vector3(growthPerSquare, growthPerSquare, growthPerSquare);
            GameMaster.AddToSpeed(speedPerSquare);
        }
    }
}