using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cons2nd : MonoBehaviour
{
    [Header("Constancia")]
    
    [SerializeField] private GameObject constacia;


    [SerializeField] public GameObject VisualCue;


    private bool IsPlayerinRange;
    private bool isTalking = false;
    public Conversation convo;
    public GameObject dialoguebox;
    private bool isQdone;
    private int count;
    // public GameObject nextClue;
    [SerializeField] GameObject lara;
    [SerializeField] GameObject inlangchickCounter;
    [SerializeField] GameObject qChickens;


    Convo_Manager convo_Manager;
    [SerializeField] GameObject conmaneger;
    [SerializeField] GameObject timeline;
    [SerializeField] GameObject thirdPersoncamera;
    [SerializeField] GameObject cutsencecamera;

    chickensquest _chickensquest;
    [SerializeField] GameObject chickenq;
    
    private bool forcutscene;
    private void Awake()
    {
        _chickensquest = chickenq.GetComponent<chickensquest>();
        convo_Manager = conmaneger.GetComponent<Convo_Manager>();

        IsPlayerinRange = false;
        VisualCue.SetActive(false);
        //dialoguebox.SetActive(false);
        //   nextClue.SetActive(false);
        timeline.SetActive(false);
        isQdone = false;

    }

    void Start()
    {
       
    }

    void Update()
    {

       
        
        if (IsPlayerinRange == true && isQdone == true )
        {
            VisualCue.SetActive(true);

            if (Input.GetKeyDown(KeyCode.F) && isTalking == false)
            {
                Destroy(inlangchickCounter);
                Destroy(qChickens);
                dialoguebox.SetActive(true);
                Convo_Manager.Startconversation(convo);
                isTalking = true;
                forcutscene = true;
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
          

            Destroy(constacia);

        }


        if (convo_Manager.isconvoDone == true && forcutscene == true)
        {
            lara.SetActive(true);
            timeline.SetActive(true);
            thirdPersoncamera.SetActive(false);
            cutsencecamera.SetActive(true);
            forcutscene = false;
        }

        if(_chickensquest.ilangChicken >= 10)
        {
            isQdone = true;
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
