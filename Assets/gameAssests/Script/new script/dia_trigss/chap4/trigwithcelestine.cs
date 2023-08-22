using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigwithcelestine : MonoBehaviour
{
    Animator animator;

    private bool IsPlayerinRange;
    private bool isTalking = false;
    public Conversation convo;
    public GameObject dialoguebox;


    Convo_Manager convo_Manager;
    [SerializeField] GameObject conmaneger;
    [SerializeField] GameObject escapetask;
    [SerializeField] GameObject findtask;


    void Awake()
    {
        convo_Manager = conmaneger.GetComponent<Convo_Manager>();
    }

    void Start()
    {
        IsPlayerinRange = false;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsPlayerinRange == true)
        {
            animator.SetBool("iswalking", false);

            if (isTalking == false)
            {
                dialoguebox.SetActive(true);
                Convo_Manager.Startconversation(convo);
                isTalking = true;
                findtask.SetActive(false);


            }
               

            
               

        }
        else
        {
            animator.SetBool("iswalking", true);

        }

        if (isTalking == true && IsPlayerinRange == false)
        {

            convo_Manager.isconvoDone = false;
        }

        if (convo_Manager.isconvoDone == true && isTalking == true)
        {
            escapetask.SetActive(true);
            Debug.Log("show");
            

        }
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            IsPlayerinRange = true;
            
            Debug.Log("detectedyg");
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
