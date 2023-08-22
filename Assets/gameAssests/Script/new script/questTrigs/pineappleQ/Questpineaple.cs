using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Questpineaple : MonoBehaviour
{
    
    private bool onQObject = false;
    public GameObject pickupIcons;
   public int ilangpineAple;
    [SerializeField] private TextMeshProUGUI pineapplesUi;
    [SerializeField] GameObject tamara;
    // Start is called before the first frame update
    void Start()
    {
        pickupIcons.SetActive(false);
        ilangpineAple = 0;
    }

    // Update is called once per frame
    void Update()
    {

        if (onQObject == true && Input.GetKeyDown(KeyCode.C))
        { 
            
            pickupIcons.SetActive(false);
            ilangpineAple += 1;
            onQObject = false;
        }


        pineapplesUi.text = "Pineapple: " + ilangpineAple.ToString() + "/10";


        if(ilangpineAple >= 5)
        {
            tamara.SetActive(true);
        }

    }


    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "pineapple")
        {


            onQObject = true;
            pickupIcons.SetActive(true);


        }



    }

    public void OnTriggerExit(Collider other)
    {



        if (other.gameObject.tag == "pineapple")
        {
            onQObject = false;
            pickupIcons.SetActive(false);
        }


    }
}
