using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    public float forceMagnitude = 5.8f;

    Material shapeMaterial;
    Rigidbody myRigidbody;

    // Start is called before the first frame update
    void Start()
    {
        shapeMaterial = GetComponent<MeshRenderer>().material;
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        ShapeMovement();
        ColorBasedOnPosition();
    }


    public void IncreaseForce(float addedForce)
    {
        forceMagnitude += addedForce;
    }

    private void ColorBasedOnPosition()
    {
        if (transform.position.y < 2)
        {
            shapeMaterial.color = Color.green;
            Debug.Log("Falling down");
        }

        if (transform.position.x < -2)
        {
            shapeMaterial.color = Color.blue;
            Debug.Log("Going Right");
        }

        else if (transform.position.x > 2)
        {
            shapeMaterial.color = Color.yellow;
            Debug.Log("Going Left");
        }
    }

    private void ShapeMovement()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.AddForce(Vector3.left * forceMagnitude);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.AddForce(Vector3.right * forceMagnitude);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            myRigidbody.AddForce(Vector3.up * forceMagnitude);
        }
    }
}
