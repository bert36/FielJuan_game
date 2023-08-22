using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disable2 : MonoBehaviour
{
    public bool PlayerInthebox;

    public GameObject toforest;
    void Start()
    {
        toforest.SetActive(true);
    }
    void Update()
    {
        if (PlayerInthebox == true)
        {

            toforest.SetActive(false);

        }


    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInthebox = true;
           
            Debug.Log("deteedhh");
        }


    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInthebox = false;
           
           
        }
    }
}
