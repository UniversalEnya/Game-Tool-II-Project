using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{
    public GameObject enemy;
    public int s;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Fire"))
        {
            Destroy(enemy, s); //This object is destroyed when it enters the area of the players fire attack
        }
    }

}

