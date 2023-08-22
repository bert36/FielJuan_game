using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondDoc : MonoBehaviour
{
    private bool IsPlayerinRange;

    public Conversation convo;
    public GameObject dialoguebox;
    private bool isTalkingt = false;

    Convo_Manager convo_Manager;
    [SerializeField] GameObject conmaneger;

    [SerializeField] GameObject lasttask;




    void Awake()
    {

        convo_Manager = conmaneger.GetComponent<Convo_Manager>();
    }
    // Start is called before the first frame update
    void Start()
    {
        IsPlayerinRange = false;


    }

    // Update is called once per frame
    void Update()
    {
        if (IsPlayerinRange == true && isTalkingt == false)
        {  
            dialoguebox.SetActive(true);
            Convo_Manager.Startconversation(convo);
            isTalkingt = true;
           
            Debug.Log("godss");
        }
       

        if (isTalkingt == true && IsPlayerinRange == false)
        {

            convo_Manager.isconvoDone = false;

        }

        if (convo_Manager.isconvoDone == true)
        {
            lasttask.SetActive(true);
            Debug.Log("done na");
        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            IsPlayerinRange = true;



          

            Debug.Log("detectedsss");
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
