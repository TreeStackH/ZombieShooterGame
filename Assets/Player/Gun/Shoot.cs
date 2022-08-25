using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] public GameObject bullet;
    [SerializeField] public float bulletPower = 5.0f;
    [SerializeField] public GameObject barrel;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1")){
            // 375 is needed to offset the 15 degree angle of the barrel relative to the camera
            float projectileAngle = (360-transform.eulerAngles.x+15)%90;
            Debug.Log(string.Format("Projectile angle: {0}", projectileAngle));

            // create a sphere/cannonball
            GameObject firedProj;
            firedProj = Instantiate(bullet, barrel.transform.position+barrel.transform.up*2, transform.rotation) as GameObject;

            // add force and direction
            Vector3 projectileForce = (barrel.transform.up.normalized) * bulletPower;
            firedProj.GetComponent<Rigidbody>().AddForce(projectileForce, ForceMode.Impulse);
        }
    }
}
