using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//for 1st npc- 


public class dialogueTrig : MonoBehaviour
{
    [Header("Mangtomas")]
    [SerializeField] public GameObject VisualCue;
    private bool IsPlayerinRange;
    private bool isTalking = false;
    public Conversation convo;
    public GameObject dialoguebox;
   // public GameObject nextClue;

    
    [SerializeField] private GameObject colNextscene;
    private void Awake()
    {
        IsPlayerinRange = false;
        VisualCue.SetActive(false);
        //   dialoguebox.SetActive(false);
      //  nextClue.SetActive(false);
        
        colNextscene.SetActive(false);
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
     //       nextClue.SetActive(true);
        }
        else
        {
         //   nextClue.SetActive(false);
        }

        if (isTalking == true && IsPlayerinRange == false)
        {
            colNextscene.SetActive(true);
        }

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
