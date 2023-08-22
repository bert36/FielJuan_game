using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class constaciatrig : MonoBehaviour
{
    [Header("Constancia")]
    [SerializeField] private GameObject alingCons;
    [SerializeField] private GameObject constacia;


    [SerializeField] public GameObject VisualCue;


    private bool IsPlayerinRange;
    private bool isTalkingg = false;
    public Conversation convo;
    public GameObject dialoguebox;
    // public GameObject nextClue;

    [SerializeField] private GameObject q1Findcons;
    public GameObject chickens;
    [SerializeField] GameObject qChickens;
    [SerializeField] private GameObject countertext;
   
    [SerializeField] GameObject manager;


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
       
    }

    void Start()
    {

    }

    void Update()
    {
     


        if (IsPlayerinRange == true)
        {
            VisualCue.SetActive(true);

            if (Input.GetKeyDown(KeyCode.F) && isTalkingg == false)
            {

                dialoguebox.SetActive(true);
                Convo_Manager.Startconversation(convo);
                isTalkingg = true;
                Destroy(q1Findcons);
                Debug.Log("in range");
            }

        }
        else
        {
            VisualCue.SetActive(false);
        }

        if (isTalkingg == true)
        {
            VisualCue.SetActive(false);
            //    nextClue.SetActive(true);
        }
        else
        {
            //     nextClue.SetActive(false);
        }
        if (isTalkingg == true && IsPlayerinRange == false)
        {
           alingCons.SetActive(true);
            Destroy(constacia);
            convo_Manager.isconvoDone = false;

        }
      if (convo_Manager.isconvoDone == true)
        {
           countertext.SetActive(true);
          chickens.SetActive(true);
            qChickens.SetActive(true);
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
