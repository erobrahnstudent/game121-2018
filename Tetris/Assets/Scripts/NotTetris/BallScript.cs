using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour {
    // Assume per second for all Speed variables
    public float maxSpeed = 6.0f;
    public float minSpeed = 3.0f;
    public float decelRate = 2.0f;
    public float cutoff = 0.0001f;
    public float currentSpeed;
    private float speedTime;

    private bool charging = false;
    private bool moving = true;
    private Vector3 direction = new Vector3(0,0,0);
    public float constrainDistance = 5;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (charging)
        {
            speedTime += Time.deltaTime;
            speedTime = Mathf.Clamp(speedTime, 0.0f, 1.0f);
        }
		if (Input.GetKeyDown(KeyCode.W) && !charging)
        {
            charging = true;
            moving = false;
            speedTime = 0.0f;
            direction = new Vector3(0, 0, 1);
        }
        if (Input.GetKeyDown(KeyCode.S) && !charging)
        {
            charging = true;
            moving = false;
            speedTime = 0.0f;
            direction = new Vector3(0, 0, -1);
        }
        if (Input.GetKeyDown(KeyCode.A) && !charging)
        {
            charging = true;
            moving = false;
            speedTime = 0.0f;
            direction = new Vector3(-1, 0, 0);
        }
        if (Input.GetKeyDown(KeyCode.D) && !charging)
        {
            charging = true;
            moving = false;
            speedTime = 0.0f;
            direction = new Vector3(1, 0, 0);
        }

        if (Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.D))
        {
            moving = true;
            charging = false;
            currentSpeed = ((maxSpeed - minSpeed) * speedTime) + minSpeed;
            // print("key held for" + speedTime + "seconds"); // (DEBUG)
        }

        if (moving)
        {
            transform.position = transform.position + direction * Time.deltaTime * currentSpeed;
            if (transform.position.x > constrainDistance || transform.position.x < -constrainDistance || transform.position.z > constrainDistance || transform.position.z < -constrainDistance)
            {
                Vector3 clampedPosition = new Vector3(Mathf.Clamp(transform.position.x, -constrainDistance, constrainDistance),
                                                      transform.position.y, 
                                                      Mathf.Clamp(transform.position.z, -constrainDistance, constrainDistance));
                transform.position = clampedPosition;
                moving = false;
            }
            // TODO = slowdown (COMPLETE)
            if (moving)
            {
                currentSpeed += -decelRate * Time.deltaTime;
                if (currentSpeed < cutoff)
                {
                    moving = false;
                    currentSpeed = 0.0f;
                }
            }
        }
	}
}
