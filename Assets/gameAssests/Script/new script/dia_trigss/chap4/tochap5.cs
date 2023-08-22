using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tochap5 : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            FindObjectOfType<sceneManager>().loadScene(11);

            Debug.Log("detectedyg");
        }


    }
}
