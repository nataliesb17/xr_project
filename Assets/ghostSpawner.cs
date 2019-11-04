using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostSpawner : MonoBehaviour
{
    public GameObject ghostPrefab;
    public GameObject positionBoy;
    int num = 0;

    // Start is called before the first frame update
    void Start()
    {
        //while (num <= 2)
        //{
            
        //}
    }

    void Update()
    {
        while (num <= 20) 
        {
        Instantiate(ghostPrefab, positionBoy.transform.position, Quaternion.identity);
            num += 1;
        }
    }
}
