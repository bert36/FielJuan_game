using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//nanayluningning

public class dialogueTrig2 : MonoBehaviour
{
    [Header("naynay luningning")]
   
    [SerializeField] private GameObject felipemodel;
    [SerializeField] private GameObject luningningmadel;
    [SerializeField] public GameObject VisualCue;
    private bool IsPlayerinRange;
    private bool isTalking = false;
    public Conversation convo;
    public GameObject dialoguebox;
  //  public GameObject nextClue;
  [SerializeField]  private BoxCollider gravecollider;
   // public GameObject quest;
    public GameObject quest;
    [SerializeField] private GameObject nextQ;
    private void Awake()
    {
        
        IsPlayerinRange = false;
        VisualCue.SetActive(false);
        //   dialoguebox.SetActive(false);
      //  nextClue.SetActive(false);
       quest.SetActive(true);
        felipemodel.SetActive(false);
        gravecollider.enabled = false;
        nextQ.SetActive(false);
    }

    void Start()
    {

    }

    void Update()
    {

        if (IsPlayerinRange == true)
        {
            VisualCue.SetActive(true);
            felipemodel.SetActive(true);

            if (Input.GetKeyDown(KeyCode.F) && isTalking == false)
            {
                quest.SetActive(false);
                dialoguebox.SetActive(true);
                Convo_Manager.Startconversation(convo);
                isTalking = true;
            }
            //  Debug.Log("in range");
        }
        else
        {
            VisualCue.SetActive(false);
        }

        if (isTalking == true)
        {
            VisualCue.SetActive(false);
       //     nextClue.SetActive(true);
        }
        else
        {
           // nextClue.SetActive(false);
        }


        if(isTalking==true && IsPlayerinRange == false)
        {
            felipemodel.SetActive(false);
            Destroy(luningningmadel);
            gravecollider.enabled = true;
            nextQ.SetActive(true);

        }
        //if(isTalking==true&&)
        //{
        //  //  dialoguebox.SetActive(true);
        //}
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            IsPlayerinRange = true;
        

            if (IsPlayerinRange == false)
            {
                // quest.SetActive(true);
            }

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


