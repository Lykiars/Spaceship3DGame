using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Topla : MonoBehaviour
{
 

    // Start is called before the first frame update
    void Toplama(int a, int b)
    {
        Debug.Log(a + b);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Start()
    {
        Toplama(20,444);
    }
}

