using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    Rigidbody myRigidbody;


    [SerializeField] float Force = 2f;
    [SerializeField] float Rotation = 4f;

    void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float forceSpeed = Time.deltaTime * Force;
        float rotaitonSpeed = Time.deltaTime * Rotation;


        if (Input.GetKey(KeyCode.W))
        {
            myRigidbody.AddRelativeForce(Vector3.forward * forceSpeed);

            Debug.Log("W PRESSED");

        }

        if (Input.GetKey(KeyCode.S))
        {
            myRigidbody.AddRelativeForce(Vector3.back * forceSpeed);

            Debug.Log("S PRESSED");
        }

        if (Input.GetKey(KeyCode.Space))
        {
            myRigidbody.AddRelativeForce(Vector3.up * forceSpeed);

            Debug.Log("Space PRESSED");
        }

        if (Input.GetKey(KeyCode.D))
        {
            myRigidbody.AddRelativeForce(Vector3.right * rotaitonSpeed);

            Debug.Log("D PRESSED");

        }

        if (Input.GetKey(KeyCode.A))
        {
            myRigidbody.AddRelativeForce(Vector3.left * rotaitonSpeed);

            Debug.Log("A PRESSED");
        }




    }

}
