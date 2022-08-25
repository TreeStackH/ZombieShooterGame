using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float MOVE_SPEED = 20.0f;
    [SerializeField] private float ROTATE_SPEED = 80.0f;

    // Update is called once per frame
    void Update()
    {
        float moveZ = Input.GetAxis("Vertical") * Time.deltaTime * MOVE_SPEED;
        float ang = Input.GetAxis("Horizontal") * Time.deltaTime * ROTATE_SPEED;

        transform.Rotate(0, ang, 0);
        transform.Translate(0, 0, moveZ);
    }
}
