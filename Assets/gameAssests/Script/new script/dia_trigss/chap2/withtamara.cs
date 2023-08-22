using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class withtamara : MonoBehaviour
{
    [Header("tamara")]

    [SerializeField] public GameObject VisualCue;


    private bool IsPlayerinRange;
    private bool isTalkingg = false;
    public Conversation convo;
    public GameObject dialoguebox;
    private bool istaskdone;

    [SerializeField] GameObject counter;
    [SerializeField] GameObject goback;
    [SerializeField] GameObject qcollect;


    Convo_Manager convo_Manager;
    [SerializeField] GameObject conmaneger;


    Questflower Flowerpink;
    [SerializeField] GameObject qFlowerpink;

    QflowerRed Flowerred;
    [SerializeField] GameObject qFlowerred;

    QflowerWhite Flowerwhite;
    [SerializeField] GameObject qFlowerwhite;

   
    private void Awake()
    {
        convo_Manager = conmaneger.GetComponent<Convo_Manager>();

        Flowerpink = qFlowerpink.GetComponent<Questflower>();
        Flowerred = qFlowerred.GetComponent<QflowerRed>();
        Flowerwhite = qFlowerwhite.GetComponent<QflowerWhite>();

        IsPlayerinRange = false;
        VisualCue.SetActive(false);
        istaskdone = false;
        
    }



    void Update()
    {
        if (IsPlayerinRange == true && istaskdone == true)
        {
            
            VisualCue.SetActive(true);
            // thirdpCam.SetActive(false);

            if (Input.GetKeyDown(KeyCode.F) && isTalkingg == false )
            {
                counter.SetActive(false);
                dialoguebox.SetActive(true);
                Convo_Manager.Startconversation(convo);
                isTalkingg = true;
              
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

        }

        if (convo_Manager.isconvoDone == true)
        {
            // insert cutsence

            FindObjectOfType<sceneManager>().loadScene(5);
            Debug.Log("nextpart2");

        }

        if (Flowerpink.ilangPink >= 5 && Flowerred.ilangred >= 5 && Flowerwhite.ilangWhite >= 5)
        {
            istaskdone = true;
            Debug.Log("donetask");

        }


        if (istaskdone == true && isTalkingg == false)
        {
            goback.SetActive(true);
            Destroy(qcollect);

        }
        else
        {
            goback.SetActive(false);
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
