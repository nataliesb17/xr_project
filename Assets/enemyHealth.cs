using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{

    public int health = 10;
    public GameObject enemy;

    // Start is called before the first frame update
    void Update()
    {
        if(health <= 0)
        {
            GameObject.Destroy(this);
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Projectile"))
        {
            health -= 5;
        }
    }
}
