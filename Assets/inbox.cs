using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class inbox : MonoBehaviour
{
    public GameObject text;
    public void show()
    {
        text.SetActive(true);
    }

    //public bool PlayerInthebox;
    //public GameObject nextquide;
    //public GameObject quest;
    //void Start()
    //{
    //    nextquide.SetActive(true);
      
    //}
    //void Update()
    //{
    //    if (PlayerInthebox == false)
    //    {

    //        nextquide.SetActive(false);

            
    //    }


    //}

    //public void OnTriggerEnter(Collider other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        PlayerInthebox = true;
           
    //        Debug.Log("detectedhh");
    //    }


    //}

    //public void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.tag == "Player")
    //    {
    //        PlayerInthebox = false;
    //        quest.SetActive(true);
    //    }
    //}
}
