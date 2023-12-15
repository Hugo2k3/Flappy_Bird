using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe_mid : MonoBehaviour
{
    public logic_manager logic_manager;
    // Start is called before the first frame update
    void Start()
    {
        logic_manager=GameObject.FindGameObjectWithTag("logic").GetComponent<logic_manager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
    }
}
