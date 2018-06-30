using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareSpawner : MonoBehaviour {
    public GameObject badSquare;
    public GameObject goodSquare;
    public float minSize = 0.2f;
    public float maxSize = 1.0f;
    public float spawnRate;
    public float badSpawnRate;

    private float nextSpawn;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Time.time > nextSpawn)
        {
            nextSpawn = Time.time + (1 / spawnRate);

            float pos = Random.Range(-1.0f, 1.0f);
            int axis = Random.Range(0, 2); // 0 = X, 1 = Y
            int side = Random.Range(0, 2); // location on the axis
            bool bad = Random.Range(0.0f, 1.0f) <= badSpawnRate;
            float size = Random.Range(minSize, maxSize);

            float x = (axis == 0 ? GameMaster.width * pos : (side == 1 ? GameMaster.width : -GameMaster.width));
            float y = (axis == 1 ? GameMaster.height * pos : (side == 1 ? GameMaster.height : -GameMaster.height));
            Vector3 spawnLocation = new Vector3(x, y, 0.0f);

            GameObject square = bad ? badSquare : goodSquare;
            square.GetComponent<SquareMovement>().moveDirection = side;
            square.GetComponent<SquareMovement>().axis = axis;
            square.GetComponent<SquareProperties>().bad = bad;
            square.transform.localScale = new Vector3(size, size, size);
            Instantiate(square, spawnLocation, Quaternion.identity);
        }
    }
}
