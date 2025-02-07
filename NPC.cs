using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    int level = 1;
    public int speed = 5 ;
    public int health = 20;
    
    void Start()
    {
        health += level;
        print("Здоровье:" + health);

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z +=speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
