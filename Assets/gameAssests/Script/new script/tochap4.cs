using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tochap4 : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            FindObjectOfType<sceneManager>().loadScene(8);

            Debug.Log("detected");
        }
    }
}
