using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ghoulSpawner : MonoBehaviour
{

    public GameObject ghoulPrefab;
    public GameObject positionBoy;
    float timer = 3.0f;
    public int num;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        timer -= Time.deltaTime;
        if (timer <= 0.0f)
        {
            num = UnityEngine.Random.Range(0, 2); 
            if (num == 0)
            {
                Instantiate(ghoulPrefab, positionBoy.transform.position, Quaternion.identity);
            }
            else
            {
                num = UnityEngine.Random.Range(0, 2);
            }
            timer = 3.0f;
        }
    }
}
