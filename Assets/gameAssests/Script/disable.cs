using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disable : MonoBehaviour
{
    public bool PlayerInthebox;
    public GameObject instuction;
    public GameObject col;
    void Start()
    {
      
    }
    void Update()
    {
        if (PlayerInthebox == false)
        {
            instuction.SetActive(false);
            col.SetActive(false);


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
