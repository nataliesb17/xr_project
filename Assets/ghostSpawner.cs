using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostSpawner : MonoBehaviour
{
    public GameObject ghostPrefab;
    public GameObject positionBoy;
    //int num = 0;
    float timer = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        //while (num <= 2)
        //{

        //}
    }

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0.0f)
        {
            Instantiate(ghostPrefab, positionBoy.transform.position, Quaternion.identity);
            timer = 3.0f;
        }

    }
}
