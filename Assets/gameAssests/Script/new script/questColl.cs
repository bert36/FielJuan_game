using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class questColl : MonoBehaviour
{
    private bool IsPlayerinRange;
    [SerializeField] GameObject qcounter;
    [SerializeField] GameObject qgoto;
    [SerializeField] public GameObject qcollect;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            qcounter.SetActive(true);
            Destroy(qgoto);
            qcollect.SetActive(true);
            IsPlayerinRange = true;
            Debug.Log("detected");
        }


    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            IsPlayerinRange = false;

            Destroy(gameObject);
        }
    }

}
