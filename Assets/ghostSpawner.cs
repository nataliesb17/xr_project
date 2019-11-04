using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostSpawner : MonoBehaviour
{
    public GameObject ghostPrefab;
    public GameObject positionBoy;
    float timer = 3.0f;
    public int num;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {
        
        timer -= Time.deltaTime;
        if (timer <= 0.0f)
        {
            num = UnityEngine.Random.Range(0, 5);
            if (num == 0)
            {
                Instantiate(ghostPrefab, positionBoy.transform.position, Quaternion.identity);
            }
            else
            {
                num = UnityEngine.Random.Range(0, 2);
                timer = 3.0f;
            }
        }

    }
}
