using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chap2lara : MonoBehaviour
{
    [SerializeField] GameObject thirdcam;
    [SerializeField] GameObject cutsencecam;


    [SerializeField] GameObject timelene;
    [SerializeField] GameObject cutsencechar;
    [SerializeField] GameObject charLara;




    Convo_Manager convo_Manager;
    [SerializeField] GameObject conmaneger;

    // Start is called before the first frame update
    void Awake()
    {
        
        convo_Manager = conmaneger.GetComponent<Convo_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        convo_Manager.isconvoDone = false;

    }

    public void setCamera()
    {
        thirdcam.SetActive(true);
        charLara.SetActive(true);
    }
    public void deactive()
    {  
        cutsencechar.SetActive(false);
        cutsencecam.SetActive(false);
        Destroy(timelene);
       

    }
}
