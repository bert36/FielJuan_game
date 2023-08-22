using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chicnok : MonoBehaviour
{
    private bool allowedTodes;

    private void Update()
    {
        if (allowedTodes && Input.GetKeyDown(KeyCode.C))
            destroyThis();
    }


    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {


            allowedTodes = true;
        


        }



    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            allowedTodes = false;
           
        }


    }
    public void destroyThis()
    {
        Destroy(gameObject);
    }


}
