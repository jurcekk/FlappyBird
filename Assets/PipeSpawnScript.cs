using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 3;
    private float timer = 0;
    public float spawnOffset = 10;
    void Start()
    {
        spawnPipe();
    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            spawnPipe();
            timer = 0;
        }
    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - spawnOffset;
        float highestPoint = transform.position.y + spawnOffset;

        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint)), transform.rotation);
    }
}
