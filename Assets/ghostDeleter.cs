using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Tobii.G2OM;

public class ghostDeleter : MonoBehaviour

{

    float timer = 2.0f;
    public GameObject ghostPrefab;
    public int ghostsHit;

    // Start is called before the first frame update
    void Start()
    {
        GameObject p = GameObject.Find("logging");
        timerGame s = p.GetComponent<timerGame>();
        ghostsHit = s.ghostsHit;
    }

   public void GazeFocusChanged(bool hasFocus)
    {
        if (hasFocus)
        {
            timer -= Time.deltaTime;
            if (timer <= 0.0f)
            {
                GameObject.Destroy(ghostPrefab);
                ghostsHit += 1;
            }
        }
        else
        {
            timer = 2.0f;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
