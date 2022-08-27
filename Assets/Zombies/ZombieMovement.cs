using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMovement : MonoBehaviour
{
    private Transform playerTransf;
    // private Animator botAnimator;
    private bool stop = false;

    void Start(){
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerTransf = player.GetComponent<Transform>();
        // botAnimator = GetComponent<Animator>();
    }

    void Update(){
        if(!stop){
            Vector3 direction = playerTransf.position - this.transform.position;

            direction.y = 0;

            this.transform.rotation = Quaternion.LookRotation(direction);

            if(direction.magnitude < 1){
                // botAnimator.SetTrigger("attack");
                this.transform.Translate(0, 0, 0.004F);
            } else {
                // botAnimator.SetTrigger("walk");
                this.transform.Translate(0, 0, 0.02F);
            }
        }
    }

    public void StopMovement(){
        stop = true;
    }
}