using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class npcfollowtrig : MonoBehaviour
{
    public GameObject mytarget;
    
    public NavMeshAgent myAgent;
    void Start()
    {

    }

    void Update()
    {
        if(mytarget!= null)
        {
            myAgent.destination = mytarget.transform.position;
        }
    }


   private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            mytarget = other.gameObject;
        }

    }


    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            mytarget = null;
        }

    }

}
