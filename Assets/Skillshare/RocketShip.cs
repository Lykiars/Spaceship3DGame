using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketShip : MonoBehaviour
{
    [SerializeField] float mainThrust = 2f;
    [SerializeField] float rotationThrust = 2f;

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

        Thrusting(thrustForce);
        Rotating(rotationSpeed, thrustForce);
    }

    private void Thrusting(float thrustForce)
    {
        if (Input.GetKey(KeyCode.W))
        {
            if (!myAudioSource.isPlaying)
            {
                myAudioSource.Play();
            }

            myRigidBody.AddRelativeForce(Vector3.up * thrustForce);
            Debug.Log("Up");
        }

        else
        {
            myAudioSource.Stop();
        }
    }

    private void Rotating(float rotationSpeed, float thrustForce)
    {

        myRigidBody.freezeRotation = true;

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

        myRigidBody.freezeRotation = false;

        if (Input.GetKey(KeyCode.S))
        {
            myRigidBody.AddRelativeForce(Vector3.down * thrustForce);
            Debug.Log("down");
        }
    }

    private void LateUpdate()
    {
        transform.localEulerAngles = new Vector3(0, 0, transform.localEulerAngles.z);
    }
}
