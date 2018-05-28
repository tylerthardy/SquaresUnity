using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    [SerializeField]
    private float horizMoveThreshold;
    private float vertMoveThreshold;

    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update ()
    {
        PlayerMovement();
    }

    private void PlayerMovement()
    {
        if (Input.GetAxisRaw("Horizontal") > horizMoveThreshold || Input.GetAxisRaw("Horizontal") < -horizMoveThreshold)
        {
            transform.Translate(new Vector3(Input.GetAxisRaw("Horizontal") * moveSpeed * Time.deltaTime, 0, 0), Space.World);

        }

        if (Input.GetAxisRaw("Vertical") > vertMoveThreshold || Input.GetAxisRaw("Vertical") < -vertMoveThreshold)
        {
            transform.Translate(new Vector3(0, Input.GetAxisRaw("Vertical") * moveSpeed * Time.deltaTime, 0), Space.World);
        }
    }
}
