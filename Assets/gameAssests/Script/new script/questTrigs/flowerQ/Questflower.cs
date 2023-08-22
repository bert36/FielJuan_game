using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class Questflower : MonoBehaviour
{
    private bool onQObjectpink;
  

    public GameObject pickupIcons;
    public int ilangPink;


    [SerializeField] private TextMeshProUGUI pinkUi;
   

    // Start is called before the first frame update
    void Start()
    {
        pickupIcons.SetActive(false);
        ilangPink = 0;
        onQObjectpink = false;
    }

    // Update is called once per frame
    void Update()
    {
       

        if(Input.GetKeyDown(KeyCode.C) && onQObjectpink == true)
        {

            ilangPink += 1;
            onQObjectpink = false;
            pickupIcons.SetActive(false);

        }
        if(ilangPink <= 5)
            pinkUi.text = "PinkRose: " + ilangPink.ToString() + "/5" ;


      
    }
  

    public void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "pinkRose"  && ilangPink <= 4)
        {
                onQObjectpink = true;
                pickupIcons.SetActive(true);
            
        }

     

    }

    public void OnTriggerExit(Collider other)
    {


        if (other.gameObject.tag == "pinkRose")
        {

            onQObjectpink = false;
            pickupIcons.SetActive(false);
        }
       

    }
}
