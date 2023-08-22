using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chap2_lastpart : MonoBehaviour
{
   

    [SerializeField] public GameObject VisualCue;
    [SerializeField] GameObject lastquest;

    private bool IsPlayerinRange;
    private bool isTalking;
    public Conversation convo;
    public GameObject dialoguebox;
    // public GameObject nextClue;


    Convo_Manager convo_Manager;
    [SerializeField] GameObject conmaneger;


    private void Awake()
    {

        convo_Manager = conmaneger.GetComponent<Convo_Manager>();
        IsPlayerinRange = false;
        VisualCue.SetActive(false);
    


        isTalking = false;

    }

    void Start()
    {

    }

    void Update()
    {


        if (IsPlayerinRange == true)
        {
            VisualCue.SetActive(true);

            if (Input.GetKeyDown(KeyCode.F) && isTalking == false)
            {
                VisualCue.SetActive(true);
                dialoguebox.SetActive(true);
                Convo_Manager.Startconversation(convo);
                isTalking = true;

            }

        }
        else
        {
            VisualCue.SetActive(false);
        }

        if (isTalking == true)
        {
            VisualCue.SetActive(false);
            //    nextClue.SetActive(true);
        }
       
        if (isTalking == true && IsPlayerinRange == false)
        {

            convo_Manager.isconvoDone = false;
        }

        if (convo_Manager.isconvoDone == true)
        {
            lastquest.SetActive(true);
            Debug.Log("Map is active");
        }



    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            IsPlayerinRange = true;
            Debug.Log("detected");
        }


    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            IsPlayerinRange = false;


        }
    }
}
