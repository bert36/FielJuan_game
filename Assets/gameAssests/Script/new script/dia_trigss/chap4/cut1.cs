using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cut1 : MonoBehaviour
{
    [SerializeField] GameObject timeline;
    [SerializeField] GameObject cam1;
    [SerializeField] GameObject thirdcam;

    public Conversation convo;
    public GameObject dialoguebox;
   // [SerializeField] GameObject nextclue;
    Convo_Manager convo_Manager;
    [SerializeField] GameObject conmaneger;
    private bool istalking;
    void Awake()
    {
        istalking = false;
        convo_Manager = conmaneger.GetComponent<Convo_Manager>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if (convo_Manager.isconvoDone == true)
        {
            thirdcam.SetActive(true);
            cam1.SetActive(false);
            timeline.SetActive(false);
            Debug.Log("bye");

        }

        if(istalking == true)
        {
            Debug.Log("byeeee");

        }
    }

    public void setcamera()
    {
        cam1.SetActive(false);
        //   timeline.SetActive(false);

    }
    public void activate()
    {

        istalking = true;
      //  cam1.SetActive(true);
        Convo_Manager.Startconversation(convo);
      //  nextclue.SetActive(true);
    }
}
