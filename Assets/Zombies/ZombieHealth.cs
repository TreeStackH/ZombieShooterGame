using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    [SerializeField] private int health = 30;
    [SerializeField] private Animator animator;

    void Start(){
        animator = GetComponentInChildren<Animator>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet"){
            // for now, just default -10 damage 
            health-=10;
            Debug.Log(string.Format("Zombie shot: {0}", health));

            // trigger animation saying "-10"

            if(health <= 0){
                Death();
            }
        }
    }

    void Death(){
        Debug.Log("Died");
        
        // trigger death animation
        animator.SetTrigger("dead");

        // deletes zombie
        // Destroy(this.gameObject);

        // stop the zombie moving
        GetComponent<ZombieMovement>().StopMovement();

        GameManager.Instance.IncreaseKills();
    }
}
