using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class QflowerWhite : MonoBehaviour
{
    private bool onQObjectwhite;


    public GameObject pickupIcons;
    public int ilangWhite;


    [SerializeField] private TextMeshProUGUI whiteUi;


    // Start is called before the first frame update
    void Start()
    {
        pickupIcons.SetActive(false);
        ilangWhite = 0;
        onQObjectwhite = false;

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.C) && onQObjectwhite == true)
        {
            ilangWhite += 1;
            pickupIcons.SetActive(false);
            onQObjectwhite = false;
        }

        if (ilangWhite <= 5)
            whiteUi.text = "WhiteRose: " + ilangWhite.ToString()+ "/5";
        
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "whiteRose" && ilangWhite <= 4)
        {
                onQObjectwhite = true;
                pickupIcons.SetActive(true);

        }
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "whiteRose")
        {

            onQObjectwhite = false;
            pickupIcons.SetActive(false);
        }
    }
}
