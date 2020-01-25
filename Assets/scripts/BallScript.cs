using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float power;

    private Rigidbody Rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
            Rigidbody.AddForce(power, 0, 0);  //move left
        }
        if (Input.GetKey(KeyCode.D))
        {
            Rigidbody.AddForce(-power, 0, 0); //move right
        }
        if (Input.GetKey(KeyCode.W))
        {
            Rigidbody.AddForce(0, 0, -power); //move forward
        }
        if (Input.GetKey(KeyCode.S))
        {
            Rigidbody.AddForce(0, 0, power); //move back
        }
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag.Equals("finish"))
        {
            Debug.Log("win!");   
        }
        else if (!other.gameObject.tag.Equals(this.tag))
        {
            Debug.Log("Lose!");
        }
    }
}