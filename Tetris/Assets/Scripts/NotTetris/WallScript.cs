using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallScript : MonoBehaviour {
    public GameObject ball;
    public bool vert;
    public Material onMat;
    public Material offMat;
    void Update()
    {
        if (vert)
        {
            if (ball.transform.position.x < transform.position.x + transform.localScale.z &&
                ball.transform.position.x > transform.position.x - transform.localScale.z &&
                ball.transform.position.z > transform.position.z - transform.localScale.x &&
                ball.transform.position.z < transform.position.z + transform.localScale.x)
            {
                print("ball is in the court of " + gameObject.name);
                this.GetComponent<Renderer>().material = onMat;
            }
            else
            {
                this.GetComponent<Renderer>().material = offMat;
            }
        }
        else
        {
            if (ball.transform.position.x < transform.position.x + transform.localScale.x &&
                ball.transform.position.x > transform.position.x - transform.localScale.x &&
                ball.transform.position.z > transform.position.z - transform.localScale.z &&
                ball.transform.position.z < transform.position.z + transform.localScale.z)
            {
                print("ball is in the court of " + gameObject.name);
                this.GetComponent<Renderer>().material = onMat;
            }
            else
            {
                this.GetComponent<Renderer>().material = offMat;
            }
        }
    }
}
