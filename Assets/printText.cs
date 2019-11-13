using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class printText : MonoBehaviour
{

    private GameObject p;
    private timerGame s;

    public Text text;

    int ghoulsHit;
    int ghostsHit;
    int playerHit;


    // Start is called before the first frame update
    void Start()
    {
        p = GameObject.Find("logging");
        s = p.GetComponent<timerGame>();
        ghostsHit = s.ghostsHit;
        ghoulsHit = s.ghoulsHit;
        playerHit = s.playerHit;

        text.text = "Ghosts Killed: " + ghostsHit + ", Ghouls Hit: " + ghoulsHit + ", Player Damage: " + playerHit;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
