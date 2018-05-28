using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animation : MonoBehaviour {
    public float rotationSpeed = 1.0f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Rotation();
    }

    private void Rotation()
    {
        // Automatic rotation
        transform.Rotate(new Vector3(0, 0, 1 * rotationSpeed), Space.World);
    }
}
