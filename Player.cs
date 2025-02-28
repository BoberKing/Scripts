using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float health;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public int coin;
 

    public void LoseHealth(float damage)
    {
        health -= damage;
        print("Текущее здоровье:" + health);
        
    }

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab,attackPoint.position, attackPoint.rotation);
        }
    }

    public void CollectCoins()
    {
        coin++;
        print("Количество монет: " + coin);
        
    }
}
