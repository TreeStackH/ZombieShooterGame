using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private int health = 100;

    void Update(){

    }

    void OnCollisionStay(Collision collision)
    {
        if((collision.gameObject.tag == "Zombies") && (health>0)){
            // for now, just default -1 damage
            // TODO: make 'damage' an attribute on the zombies
            health-=1;

            Debug.Log(string.Format("Player damaged: {0}", health));

            // trigger UI change
            UIManager.Instance.UpdateHealth(health);

            if(health <= 0){
                Death();
            }
        }
        //hit heart
        if((collision.gameObject.tag == "Item") && (health <= 100))
        {
            if (health > 90)
            {
                health = 100;
            }
            else
            {
                health += 10;
            }
            Destroy(collision.gameObject);
            UIManager.Instance.UpdateHealth(health);
        }

    }

    void Death(){
        Debug.Log("Died");
        // trigger death animation

        // trigger gameover sequence
        GameManager.Instance.GameOver();
                
        // deletes player
        // Destroy(this.gameObject);
    }
}
