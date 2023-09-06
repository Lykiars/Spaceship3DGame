using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeSpawner : MonoBehaviour
{
    public Shape[] shapePrefabs;
    float forcePlus = 5.8f;

    // Update is called once per frame
    void Update()
    {
        Instantiater();
        ForceIncreaser();
    }

    private void ForceIncreaser()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            for (int i = 0; i < shapePrefabs.Length; i++)
            {
                shapePrefabs[i].IncreaseForce(forcePlus);
                Debug.Log("F pressed");
            }
        }
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
