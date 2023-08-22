using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger2 : MonoBehaviour
{
    [Header("NPC First")]
    [SerializeField] private GameObject npc;
    [SerializeField] public GameObject VisualCue;
    private bool IsPlayerinRange;
    private bool isTalking = false;
    public Conversation convo;
  //  public GameObject dialoguebox;
  //  public GameObject nextClue;
  //  public Transform diaBox;
    private void Awake()
    {
        IsPlayerinRange = false;
        VisualCue.SetActive(false);
        //   dialoguebox.SetActive(false);
       // nextClue.SetActive(false);
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
              
             //   dialoguebox.SetActive(true);
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
          //  nextClue.SetActive(false);
        }


        if (isTalking == true && IsPlayerinRange == false)
        {
            
            
            Destroy(npc);
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
