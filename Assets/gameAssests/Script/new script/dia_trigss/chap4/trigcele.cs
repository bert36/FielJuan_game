using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigcele : MonoBehaviour
{

    [SerializeField] GameObject celestine;
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

            celestine.SetActive(true);
            Debug.Log("detectedyg");
        }


    }

    public void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {


        }
    }
}
