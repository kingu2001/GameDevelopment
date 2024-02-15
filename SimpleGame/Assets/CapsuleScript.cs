using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScript : MonoBehaviour
{
    public Rigidbody2D myRigidBody2;
    public LogicScript logic;
    public bool pillIsAlive = true; 
    // Start is called before the first frame update
    void Start()
    {
        gameObject.name = "Blue pill";
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && pillIsAlive == true)
        {
            myRigidBody2.velocity = Vector2.up * 5;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        pillIsAlive = false; 
    }
}
