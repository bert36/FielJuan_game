using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class chickensquest : MonoBehaviour
{
    private bool onQObject = false;
    public GameObject pickupIcons;
    public int ilangChicken;
    [SerializeField] private TextMeshProUGUI numChicken;

   
    // Start is called before the first frame update
    void Start()
    {
        pickupIcons.SetActive(false);
        ilangChicken = 0;
    }

    // Update is called once per frame
    void Update()
    {
     
        if (onQObject == true && Input.GetKeyDown(KeyCode.C))
        {
            ilangChicken += 1;
            
            pickupIcons.SetActive(false);
            onQObject = false;
        }


        numChicken.text = "Chickens: " + ilangChicken.ToString() + "/10";
        if (ilangChicken == 10) 
        {



        }

    }

   



    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "questObs")
        {
           

            onQObject = true;
            pickupIcons.SetActive(true);

           
        }

    

    }

    public void OnTriggerExit(Collider other)
    {
       


        if (other.gameObject.tag == "questObs")
        {
            onQObject = false;
            pickupIcons.SetActive(false);
        }


    }
}
