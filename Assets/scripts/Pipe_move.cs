using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipe_move : MonoBehaviour
{
   
    // Start is called before the first frame update
    public float moveSpeed = 5f;
    public float Point_destroy_pipo = -10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!logic_manager.instance.isGameStart) { return; }
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x<Point_destroy_pipo)
        {
            Destroy(gameObject);
        }
    }
    
}
