using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DiialogueManeger : MonoBehaviour
{
    public Conversation conversation;
    public TextMeshProUGUI _char_name, _dialogue;
    public Image _char_image;

    public GameObject dialogueUI;
    public GameObject VisualCue;
    public GameObject nextClue;
    public bool istalking;
    private bool IsPlayerinRange;
    private int currentIndex = 0;

    private DiialogueManeger instance;
    // Start is called before the first frame update
    void Start()
    {
       
    }
    void Update()
    {
       

        if (IsPlayerinRange)
        {
            VisualCue.SetActive(true);
            if (Input.GetKeyDown(KeyCode.E) && istalking == false)
            {
                StartConversation();
            }
            else if (Input.GetKeyDown(KeyCode.I) && istalking == true)
            {
                EndConversation();
            }

        }

        if (istalking == true)
        {
            nextClue.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.M))
        {
            nextdialogue();
        }
      
    }


    void StartConversation()
    {
        nextdialogue(); 
    }
    public void nextdialogue()
    {
        _char_name.text = conversation.GetLinesByIndex(currentIndex).characters.GetName();
        _dialogue.text = conversation.GetLinesByIndex(currentIndex).dialogue;
        _char_image.sprite = conversation.GetLinesByIndex(currentIndex).characters.GetSprite();
        currentIndex++;

        dialogueUI.SetActive(true);
        istalking = true;

    }
    void EndConversation()
    {
        istalking = false;
        dialogueUI.SetActive(false);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            IsPlayerinRange = true;

           
           
        }

        Debug.Log("detect");
    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            IsPlayerinRange = false;

        }
    }



}
