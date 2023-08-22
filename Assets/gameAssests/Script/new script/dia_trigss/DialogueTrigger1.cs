using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger1 : MonoBehaviour
{
    [Header("felipe")]
    [SerializeField] private GameObject felipe;
    [SerializeField] private GameObject nanayL;
    [SerializeField] private GameObject npc;
    [SerializeField] private GameObject VisualCue;
    private bool IsPlayerinRange;
    private bool isTalking = false;
    public Conversation convo;
    public GameObject dialoguebox;
    //  public GameObject nextClue;
    public GameObject quest;
    public GameObject nextQuest;
    private void Awake()
    {
        IsPlayerinRange = false;
        VisualCue.SetActive(false);
     //   dialoguebox.SetActive(false);
     //   nextClue.SetActive(false); 
        quest.SetActive(true);
        nextQuest.SetActive(false);
        nanayL.SetActive(false);
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
         //   nextClue.SetActive(true);
        }
        else
        {
           // nextClue.SetActive(false);
        }


        if (isTalking == true && IsPlayerinRange == false)
        {
            nextQuest.SetActive(true);
            nanayL.SetActive(true);
            Destroy(felipe);
            Destroy(npc);
            
        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            IsPlayerinRange = true;
            
        if (IsPlayerinRange == false)
         {
           
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
