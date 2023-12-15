using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_spawn : MonoBehaviour
{
    public GameObject Pipe;
    public float spawnRate = 2;
    private float timer = 0;
    public float heighOffset = 1;

    // Start is called before the first frame update
    void Start()
    {
        spawnPipe();   
    }

    // Update is called once per frame
    void Update()
    {
         if (!logic_manager.instance.isGameStart) { return; }
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
        float lowestPoint = transform.position.y - heighOffset;
        float highestPoint = transform.position.y + heighOffset;
        Instantiate(Pipe, new Vector2(transform.position.x, Random.Range(lowestPoint, highestPoint)), transform.rotation);


    }
}
