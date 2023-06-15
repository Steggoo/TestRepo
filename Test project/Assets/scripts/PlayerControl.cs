using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControl : MonoBehaviour
{
    // Rigidbody for physics control
    private Rigidbody2D rb;

    // doubles for speed
    private float speed = 1.5f;
    private Vector2 movementVec;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Called everytime the input manager gets an input
    private void OnMove(InputValue input) {
        movementVec = input.Get<Vector2>();
    }

    // Updater is not based on framerate
    void FixedUpdate()
    {
        rb.AddForce(movementVec * speed);
    }
}
