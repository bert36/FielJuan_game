using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene2cut3 : MonoBehaviour
{
    public Conversation convo;
    public GameObject dialoguebox;
    private bool istalking = false;
    Convo_Manager convo_Manager;
    [SerializeField] GameObject conmaneger;

    [SerializeField] GameObject currentcut;
    [SerializeField] GameObject nextcut;

    // Start is called before the first frame update
    void Awake()
    {

        convo_Manager = conmaneger.GetComponent<Convo_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (convo_Manager.isconvoDone == true && istalking == true)
        {
          currentcut.SetActive(false);
           nextcut.SetActive(true);
            Debug.Log("next scene");

        }
    }
    public void activate()
    {
        istalking = true;
        Convo_Manager.Startconversation(convo);
        // nextclue.SetActive(true);
    }
}
