using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class withlara2 : MonoBehaviour
{
    [Header("Lara2")]

    [SerializeField] public GameObject VisualCue;


    private bool IsPlayerinRange;
    private bool isTalkingg = false;
    public Conversation convo;
    public GameObject dialoguebox;
    private bool istaskdone;

    [SerializeField] GameObject qcounter;
    [SerializeField] GameObject qgotolara;
    [SerializeField] GameObject qpinyaTask;



    [SerializeField] GameObject thirdpCam;
    [SerializeField] GameObject timeline;
    [SerializeField] GameObject cutsceneCam;
    [SerializeField] GameObject cutscenechar;

    Convo_Manager convo_Manager;
    [SerializeField] GameObject conmaneger;
    // Start is called before the first frame update

    Questpineaple pinyaTask;
    [SerializeField] GameObject pinyapple;

    [SerializeField] GameObject qflower;

    [SerializeField] GameObject opentheflower;

    private void Awake()
    {
        convo_Manager = conmaneger.GetComponent<Convo_Manager>();
        pinyaTask = pinyapple.GetComponent<Questpineaple>();


        IsPlayerinRange = false;
        VisualCue.SetActive(false);
        istaskdone = false;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsPlayerinRange == true && istaskdone == true)
        {   
            VisualCue.SetActive(true);
          // thirdpCam.SetActive(false);
          
            if (Input.GetKeyDown(KeyCode.F) && isTalkingg == false )
            {
                
                qcounter.SetActive(false);
                cutsceneCam.SetActive(true);
                cutscenechar.SetActive(true);
                timeline.SetActive(true);
                dialoguebox.SetActive(true);
                Convo_Manager.Startconversation(convo);
                isTalkingg = true;
                qgotolara.SetActive(false);
               
              
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
            qflower.SetActive(true);
            Destroy(opentheflower);
        }


      if(pinyaTask.ilangpineAple >= 10)
        {
            istaskdone = true;


        }
        if (istaskdone == true && isTalkingg ==false)
        {
            qgotolara.SetActive(true);
            Destroy(qpinyaTask);

        }
        else
        {
            qgotolara.SetActive(false);
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
