using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Dialoguetrigger : MonoBehaviour
{
    [Header("Father yael")]
    [SerializeField] public GameObject VisualCue;
 public bool IsPlayerinRange;
    private bool isTalking;
    public Conversation convo;
    public GameObject dialoguebox;
  //  public GameObject nextClue;
    public GameObject info_collider;
    public GameObject guide;
    public GameObject doorcollider;
    public GameObject talkto;
    [SerializeField] private GameObject secondCutScene;
    [SerializeField] private GameObject secondCamera;
    [SerializeField] private GameObject mainCamera;


    private void Awake()
    {
        IsPlayerinRange = false;
        isTalking = false;
        talkto.SetActive(true);
        VisualCue.SetActive(false);
      //  nextClue.SetActive(false);
          doorcollider.SetActive(false);
        secondCamera.SetActive(false);     
      
    }
 

    void Start()
    {
       // dialoguebox.SetActive(false); 
       guide.SetActive(false);
         secondCutScene.SetActive(false);
    }

    void Update()
    {
        
        if (IsPlayerinRange == true)
        {
            VisualCue.SetActive(true);
             Destroy(guide);
             Destroy(info_collider);

            if (Input.GetKeyDown(KeyCode.F) && isTalking==false)
            {
                talkto.SetActive(false);
                dialoguebox.SetActive(true);
                Convo_Manager.Startconversation(convo);
                isTalking = true;
            }
            //if (Input.GetKeyDown(KeyCode.I) && isTalking == true)
            //{
                
            //}
            //Debug.Log("in range");
        }
        else
        {
             VisualCue.SetActive(false);
            //dialoguebox.SetActive(false);
        }

        if (isTalking == true)
        {
            VisualCue.SetActive(false);
          //  nextClue.SetActive(true);
            Debug.Log("nextcueee");
        }
      



        if(isTalking == true && IsPlayerinRange == false)
        {
            doorcollider.SetActive(true);

            mainCamera.SetActive(false);
            secondCamera.SetActive(true);
            secondCutScene.SetActive(true);
            Debug.Log("secodscene");
        }
    }
    //void EndConversation()
    //{
    // //   isTalking = false;
    //    dialoguebox.SetActive(false);
    //}

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
