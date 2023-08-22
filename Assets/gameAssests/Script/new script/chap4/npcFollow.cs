using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class npcFollow : MonoBehaviour
{
    public GameObject mytarget;
    public GameObject currentTarget;
    public NavMeshAgent myAgent;

    public int range;

    public int tetherRange;
    public Vector3 startpos;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("distanceCheck", 0, 0.5f);

        startpos = this.transform.position;

        
    }

    // Update is called once per frame
    void Update()
    {
       if(currentTarget != null)
        {
            myAgent.destination = currentTarget.transform.position;
        }
        else if(myAgent.destination != startpos){
            myAgent.destination = startpos;

        }
    }
    public void distancecheck()
    { 
        float dist = Vector3.Distance(this.transform.position, mytarget.transform.position);

        if (dist < range)
        {
            currentTarget = mytarget;
        }
        else if (dist > tetherRange)
        {
            currentTarget = null;
        }

    }
  
}
