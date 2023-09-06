using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketShip : MonoBehaviour
{
    public float mainThrust = 2f;
    public float rotationThrust = 2f;

    Rigidbody myRigidBody;
    AudioSource myAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        myRigidBody = GetComponent<Rigidbody>();
        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        RocketMovement();

    }

    private void RocketMovement()
    {
        float rotationSpeed = Time.deltaTime * rotationThrust;
        float thrustForce = Time.deltaTime * mainThrust;

        if (Input.GetKey(KeyCode.W))
        {
            if(!myAudioSource.isPlaying)
            {
                myAudioSource.Play();

            }

            else
            {
                myAudioSource.Stop();
            }

            myRigidBody.AddRelativeForce(Vector3.up * thrustForce);
            Debug.Log("Up");
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.forward * rotationSpeed);
            Debug.Log("Rotate Z");
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(-Vector3.forward * rotationSpeed);
            Debug.Log("Rotate -Z");
        }

        if (Input.GetKey(KeyCode.S))
        {
            myRigidBody.AddRelativeForce(Vector3.down * thrustForce);
            Debug.Log("down");
        }
    }
}
