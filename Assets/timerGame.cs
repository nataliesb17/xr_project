using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerGame : MonoBehaviour {


    public int ghoulsHit;
    public int ghostsHit;
    public int playerHit;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        GameObject p = GameObject.Find("seabearTrap");
        destroyOnTouch s = p.GetComponent<destroyOnTouch>();
        playerHit = s.playerDamage;

        GameObject p2 = GameObject.Find("g7");
        ghostDeleter s2 = p2.GetComponent<ghostDeleter>();
        ghostsHit = s2.ghostsHit;

        GameObject p3 = GameObject.Find("ghoulWalkCycle");
        enemyHealth s3 = p3.GetComponent<enemyHealth>();
        ghoulsHit = s3.ghoulsHit;

    }
}
