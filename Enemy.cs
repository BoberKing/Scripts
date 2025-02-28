using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float damage;
    public Transform direction;


    void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Player>()!=null)
        {
            other.GetComponent<Player>().LoseHealth(damage);
        }
        
    }


    public void Move()
    {
        transform.position = Vector3.MoveTowards(transform.position , direction.position , speed* Time.deltaTime);
        transform.LookAt(direction.position);
    }

    void Update()
    {
        Move();
    }
}
