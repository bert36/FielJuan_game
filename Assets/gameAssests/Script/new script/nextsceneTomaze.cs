using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nextsceneTomaze : MonoBehaviour
{

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            FindObjectOfType<sceneManager>().loadScene(3);

            Debug.Log("detected");
        }
    }
}
