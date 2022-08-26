using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    [SerializeField] private int health = 100;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet"){
            // for now, just default -10 damage 
            health-=10;
            Debug.Log(string.Format("Zombie shot: {0}", health));

            // trigger animation saying "-10"
        }
    }    
}
