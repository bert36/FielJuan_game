using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wihlara : MonoBehaviour
{
    [Header("Lara")]
  
    [SerializeField] public GameObject VisualCue;


    private bool IsPlayerinRange;
    private bool isTalkingg = false;
    public Conversation convo;
    public GameObject dialoguebox;
    public GameObject pineappleQuest;

    [SerializeField] GameObject openthepine;

    [SerializeField] GameObject coll;

    Convo_Manager convo_Manager;
    [SerializeField] GameObject conmaneger;


    [SerializeField] GameObject charCons;
    [SerializeField] GameObject charLara;

    private void Awake()
    {
        convo_Manager = conmaneger.GetComponent<Convo_Manager>();

        IsPlayerinRange = false;
        VisualCue.SetActive(false);
        //dialoguebox.SetActive(false);
        //   nextClue.SetActive(false);
      
        
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
           
        }
      
        if (isTalkingg == true && IsPlayerinRange == false)
        {

            convo_Manager.isconvoDone = false;
            Destroy(charCons);
            Destroy(charLara);
        }

        if(convo_Manager.isconvoDone == true)
        {
            pineappleQuest.SetActive(true);
           Destroy(openthepine);
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
