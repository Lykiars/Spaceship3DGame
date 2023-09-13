using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{
    public Shape[] shapePrefabs;

    // Update is called once per frame

    void Start()
    {

        Instantiate(shapePrefabs[0]);
        Instantiate(shapePrefabs[1]);
        Instantiate(shapePrefabs[2]);
    }


    void Update()
    {
        Instantiater();
    }


    private void Instantiater()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            for (int i = 0; i < shapePrefabs.Length; i++)
            {
                Instantiate(shapePrefabs[i]);
            }
        }
    }
}
