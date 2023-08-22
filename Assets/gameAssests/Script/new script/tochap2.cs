using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class tochap2 : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            FindObjectOfType<sceneManager>().loadScene(4);

            Debug.Log("detected");
        }
    }
}
