using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ghostMovement : MonoBehaviour
{
    public NavMeshAgent agent;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        agent.SetDestination(player.transform.position);
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player.transform);
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        Debug.Log("collision detected");
    //        GameObject.Destroy(this);
    //    }
    //}
}
