using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class nextsceneTotown : MonoBehaviour
{
   
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {

            FindObjectOfType<sceneManager>().loadScene(2);

            Debug.Log("detected");
        }
    }

  

 
}
