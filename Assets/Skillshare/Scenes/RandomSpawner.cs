using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawner : MonoBehaviour
{

    public GameObject[] objectToSpawn;
    public float timer = 2f;


    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 2f)
        {
            Instantiate();
            timer = 0;
        }

    }

    private void Instantiate()
    {
        for(int i = 0; i < objectToSpawn.Length; i++)
        {
            GameObject spawned = Instantiate(objectToSpawn[i]);
            spawned.name = i.ToString();
            Vector3 randomValue = Random.insideUnitSphere * 10f;
            spawned.transform.position += randomValue;
            Destroy(spawned, 3.0f);
        }
    }
}
