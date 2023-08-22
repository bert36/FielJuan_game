using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alonsotrig : MonoBehaviour
{  
    [Header("Alonso")]
    [SerializeField] private GameObject alingCons;
    [SerializeField] private GameObject alonso;


    [SerializeField] public GameObject VisualCue;

   
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
        //dialoguebox.SetActive(false);
        //   nextClue.SetActive(false);
        alingCons.SetActive(false);

       

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

                dialoguebox.SetActive(true);
                Convo_Manager.Startconversation(convo);
                isTalking = true;
               
                Debug.Log("in range");
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
        else
        {
            //     nextClue.SetActive(false);
        }
        if (isTalking == true && IsPlayerinRange == false)
        {

            alingCons.SetActive(true);
            Destroy(alonso);
            convo_Manager.isconvoDone = false;
        }

        if (convo_Manager.isconvoDone == true)
        {
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
