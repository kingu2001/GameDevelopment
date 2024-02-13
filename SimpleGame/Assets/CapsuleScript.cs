using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody2;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Blue pill";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidBody2.velocity = Vector2.up * 5;
        }
    }
}
