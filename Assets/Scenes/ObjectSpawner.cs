using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public Spawn myCapsule;
    public int spawnCount = 2;

    void Spawn(int xx)
    {
        for (int i = 0; i < xx; i++)
        {
            Spawn spawnedObject = Instantiate(myCapsule);
            Destroy(spawnedObject.gameObject, 2.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spawn(20);
        }

    }


}
