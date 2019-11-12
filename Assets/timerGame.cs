using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timerGame : MonoBehaviour {


    public int ghoulsHit = 0;
    public int ghostsHit = 0;
    public int playerHit = 0;

    // Start is called before the first frame update
    public void Start()
    {
        DontDestroyOnLoad(this.gameObject);
    }

    // Update is called once per frame
    public void Update()
    {
        //GameObject p1 = GameObject.Find("seabearTrap");
        //destroyOnTouch s1 = p1.GetComponent<destroyOnTouch>();
        //playerHit = s1.playerDamage;

        ////GameObject p2 = GameObject.Find("g7");
        ////HighlightAtGaze s2 = p2.GetComponent<HighlightAtGaze>();

        //GameObject p = GameObject.Find("logging");
        //HighlightAtGaze s = p.GetComponent<HighlightAtGaze>();

        //GameObject p3 = GameObject.Find("ghoulWalkCycle");
        //enemyHealth s3 = p3.GetComponent<enemyHealth>();
        //ghoulsHit = s3.ghoulsHit;

        //if (s.hasHit == true)
        //{
        //    GhostHit();
        //}

    }

    public void GhostHit()
    {
        ghostsHit++;
        Debug.Log(ghostsHit);
    }
}
