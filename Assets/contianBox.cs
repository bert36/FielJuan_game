using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class contianBox : MonoBehaviour
{
    private bool PlayerInthebox;
    [SerializeField] private GameObject textbox;
    [SerializeField] private GameObject nextquide;
 
    private bool isMoving;
    private bool activate;
    void Start()
    {
        textbox.SetActive(false);
        nextquide.SetActive(false);
        activate = false;
    }        
    void Update()
    {

        if (PlayerInthebox == true)
        {
            textbox.SetActive(true);
            isMoving = false;
            nextquide.SetActive(false);
            activate = true;
        }

        else 
        {
            isMoving = true;
            textbox.SetActive(false);
            Debug.Log("ismoving_true");

        }

       if (isMoving== true && activate==true)
        {
            showtalkto();
            
        }



    }

    public void showtalkto()
    {
        nextquide.SetActive(true);
       
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInthebox = true;

            Debug.Log("detectedsss");
        }


    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerInthebox = false;
            Debug.Log("out");
        }
    }
}
