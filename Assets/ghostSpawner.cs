using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghostSpawner : MonoBehaviour
{
    public GameObject ghostPrefab;
    public GameObject positionBoy;
    public GameObject positionBoy2;
    float timer = 3.0f;
    public int num;
    public int spawnNum;
    

    // Start is called before the first frame update
    void Start()
    {

    }

    void FixedUpdate()
    {
        
        timer -= Time.deltaTime;
        if (timer <= 0.0f)
        {
            num = UnityEngine.Random.Range(0, 3);
            spawnNum = UnityEngine.Random.Range(0, 2);
            if (num == 0)
            {
                if (spawnNum == 0)
                {
                    Instantiate(ghostPrefab, positionBoy.transform.position, Quaternion.identity);
                }
                if (spawnNum == 1)
                {
                    Instantiate(ghostPrefab, positionBoy2.transform.position, Quaternion.identity);
                }
            }
            else
            {
                num = UnityEngine.Random.Range(0, 2);
                spawnNum = UnityEngine.Random.Range(0, 2);
            }
            timer = 3.0f;
        }

    }
}
