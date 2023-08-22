using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diaTrig3 : MonoBehaviour
{
    [Header("Father geronimo")]
    [SerializeField] private GameObject mangTomas;  
    [SerializeField] private GameObject father;
    [SerializeField] public GameObject VisualCue;
    [SerializeField] private GameObject quest;
 
    private bool IsPlayerinRange;
    private bool isTalking = false;
    public Conversation convo;
    public GameObject dialoguebox;
    // public GameObject nextClue;
   



    private void Awake()
    {
        IsPlayerinRange = false;
        VisualCue.SetActive(false);
//dialoguebox.SetActive(false);
     //   nextClue.SetActive(false);
        mangTomas.SetActive(false);
        quest.SetActive(false);
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
            mangTomas.SetActive(true);
            quest.SetActive(true);
            Destroy(father);
           
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
