using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    public int health = 10;

    public int level = 1;
    // Start is called before the first frame update
    void Start()
    {
        health+=level;
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 1.2f; 
        Vector3 newPosition= transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position=newPosition;
    }
}
