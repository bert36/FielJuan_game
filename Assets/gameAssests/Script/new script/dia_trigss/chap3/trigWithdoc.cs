using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigWithdoc : MonoBehaviour
{
    private bool IsPlayerinRange;
    private bool isTalkingt = false;
    public Conversation convo;
    public GameObject dialoguebox;


    [SerializeField] public GameObject VisualCue;

    Convo_Manager convo_Manager;
    [SerializeField] GameObject conmaneger;


    [SerializeField] GameObject finddoctask;

    [SerializeField] GameObject timeline;
    [SerializeField] GameObject nurse;
    void Awake()
    {
        convo_Manager = conmaneger.GetComponent<Convo_Manager>();
        
    }
    // Start is called before the first frame update
    void Start()
    {

       
        VisualCue.SetActive(false);

        IsPlayerinRange = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (IsPlayerinRange == true)
        {

            Destroy(nurse);
            VisualCue.SetActive(true);

            if (Input.GetKeyDown(KeyCode.F) && isTalkingt == false)
            {
                Destroy(finddoctask);
                dialoguebox.SetActive(true);
                Convo_Manager.Startconversation(convo);
                isTalkingt = true;
            }
        }
        else
        {
            VisualCue.SetActive(false);

        }
        if (isTalkingt == true)
        {
            VisualCue.SetActive(false);


        }

        if (isTalkingt == true && IsPlayerinRange == false)
        {

            convo_Manager.isconvoDone = false;

        }

        if (convo_Manager.isconvoDone == true)
        {
            timeline.SetActive(true);
            Debug.Log("done na");
            
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
