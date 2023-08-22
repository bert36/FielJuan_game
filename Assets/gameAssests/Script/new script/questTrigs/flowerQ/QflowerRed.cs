using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class QflowerRed : MonoBehaviour
{
    private bool onQObjectred;


    public GameObject pickupIcons;
    public int ilangred;


    [SerializeField] private TextMeshProUGUI redUi;


    // Start is called before the first frame update
    void Start()
    {
        pickupIcons.SetActive(false);
        ilangred = 0;
        onQObjectred = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && onQObjectred == true)
        {
            ilangred += 1;
            onQObjectred = false;
            pickupIcons.SetActive(false);
        }
        if(ilangred <= 5)
            redUi.text = "RedRose: " + ilangred.ToString() + "/5";

    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "redRose" && ilangred <= 4)
        {
                onQObjectred = true;
                pickupIcons.SetActive(true);
            
        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "redRose")
        {

            onQObjectred = false;
            pickupIcons.SetActive(false);
        }
    }
}
