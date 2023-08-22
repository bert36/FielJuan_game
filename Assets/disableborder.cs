using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disableborder : MonoBehaviour
{
    //   private GameObject previewsQ;
   // [SerializeField] private GameObject timeline;
   [SerializeField] private GameObject quest;
    [SerializeField] private GameObject father;

    // GameObject border4;
   
  public  bool PlayerInthebox;
   
    private bool isTalking;
    void Start()
    {
        isTalking = false;
        father.SetActive(false);
        quest.SetActive(false);
    }
    void Update()
    {
        if (PlayerInthebox == true)
        {
           
          //  isTalking = true;
        }


        //if (isTalking == true && PlayerInthebox == false)
        //{
        //    Destroy(gameObject);
        //}
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            father.SetActive(true);
            Destroy(quest);
            PlayerInthebox = true;
            // previewsQ.SetActive(false);
          
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
