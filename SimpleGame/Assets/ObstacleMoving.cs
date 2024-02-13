using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMoving : MonoBehaviour
{
    public float movementSpeed = 5;
    public float deadZone = -15;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * movementSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
        {
            Debug.Log("Obstacle has been deleted!");
            Destroy(gameObject);
        }
    }
}
