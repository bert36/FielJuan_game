using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigWithnurse : MonoBehaviour
{
    private bool IsPlayerinRange;
    private bool isTalking = false;
    public Conversation convo;
    public GameObject dialoguebox;

    [SerializeField] public GameObject VisualCue;

    Convo_Manager convo_Manager;
    [SerializeField] GameObject conmaneger;


    [SerializeField] GameObject getinside;
    [SerializeField] GameObject finddoctask;
    [SerializeField] GameObject hoscoll;
    [SerializeField] GameObject ygnacio;
    [SerializeField] GameObject doc;

    // Start is called before the first frame update

    void Awake()
    {
        convo_Manager = conmaneger.GetComponent<Convo_Manager>();
        finddoctask.SetActive(false);

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
            VisualCue.SetActive(true);

            if (Input.GetKeyDown(KeyCode.F) && isTalking == false)
            {
                dialoguebox.SetActive(true);
                Convo_Manager.Startconversation(convo);
                isTalking = true;
            }
        }
        else
        {
            VisualCue.SetActive(false);



        }



        if (isTalking == true)
        {

            VisualCue.SetActive(false);


        }

        if (isTalking == true && IsPlayerinRange == false)
        {
            doc.SetActive(true);
            convo_Manager.isconvoDone = false;

        }

        if (convo_Manager.isconvoDone == true)
        {
           
            Destroy(hoscoll);
            Destroy(getinside);
            finddoctask.SetActive(true);
        }

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(ygnacio);
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
