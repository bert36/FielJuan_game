using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chap5lasanim : MonoBehaviour
{
    [SerializeField] GameObject thirdcam;
    [SerializeField] GameObject cam1;
    [SerializeField] GameObject timeline;

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
            thirdcam.SetActive(false);
            cam1.SetActive(true);
            timeline.SetActive(true);
            Debug.Log("detected");
        }


    }

}
