using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collTrigger : MonoBehaviour
{

    [SerializeField] GameObject timeline;
    [SerializeField] GameObject trirdcam;
    [SerializeField] GameObject cam1;
    [SerializeField] GameObject prevNpc;
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
            prevNpc.SetActive(false);
            timeline.SetActive(true);
            trirdcam.SetActive(false);
            cam1.SetActive(true);

            Debug.Log("detected");
        }


    }

    public void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            trirdcam.SetActive(true);

        }
    }

}
