using TMPro;
using UnityEngine;

public class ZombieHealth : MonoBehaviour
{
    [SerializeField] private int health = 30;
    private Animator animator;

    [Header("UI")]
    [SerializeField] private Transform canvasTransform;
    [SerializeField] private GameObject damageTextObject;

    void Awake(){
        animator = GetComponentInChildren<Animator>();
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bullet"){
            // for now, just default -10 damage 
            health-=10;
            Debug.Log(string.Format("Zombie shot: {0}", health));

            DamageSelfText(10);

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
    //User damage feedback on zombies
    private void DamageSelfText(int amountOfDamage) {
        GameObject damageObjectInstance = Instantiate(damageTextObject, canvasTransform);

        //damageObjectInstance.GetComponentInChildren<TMP_Text>().text = "-" + amountOfDamage;
    }
}
