using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    GameObject mySphere;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void Instantiate()
    {
        if (Input.GetKey(KeyCode.F))
        {
            GameObject newObject = Instantiate(mySphere);

            Debug.Log("F PRESSED");

        }
    }
}
