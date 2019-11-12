using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{

    public int health = 10;
    public GameObject enemy;

    private GameObject p;
    private timerGame s;

    private void Start()
    { 
    
        p = GameObject.Find("logging");
        s = p.GetComponent<timerGame>();

    }

    // Start is called before the first frame update
    void Update()
    {
        if(health <= 0)
        {
            s.GhoulHit();
            GameObject.Destroy(enemy);
        }
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Projectile")
        {
            health -= 5;
        }
    }
}
