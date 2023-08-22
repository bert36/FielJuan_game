using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Convo_Manager : MonoBehaviour
{
    public TextMeshProUGUI char_name, dialogue;
    public Image char_image;

    
    private int currentIndex;
    private Conversation currentconvo;
    public static Convo_Manager instance;

    public static bool isconvoActive;
    public GameObject nextcue;
    private Animator anim;
    public bool isconvoDone;
   
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            anim = GetComponent<Animator>();
            
        }

        isconvoDone = false;


    }
    void Start()
    {
       

    }


    //public static Convo_Manager Getinstance()
    //{
    //    return instance;
    //}
    public static void Startconversation(Conversation convo)
    {
       
        instance.anim.SetBool("isOpen", true);
       isconvoActive = true;
        instance.currentIndex = 0;
        instance.currentconvo = convo;
        instance.char_name.text = "";
        instance.dialogue.text = "";
         instance.ReadNext();
        
        
    }

   void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
         
            ReadNext();

        }
       

    }

    public void ReadNext()
    {
        if (currentIndex > currentconvo.GetLength())
        {
            instance.anim.SetBool("isOpen", false);
            
            nextcue.SetActive(false);
            isconvoActive = false;
            isconvoDone = true;
             return;
           
        }
        nextcue.SetActive(true);
        isconvoActive = true;
        isconvoDone = false;
        char_name.text = currentconvo.GetLinesByIndex(currentIndex).characters.GetName();
        dialogue.text = currentconvo.GetLinesByIndex(currentIndex).dialogue;
        char_image.sprite = currentconvo.GetLinesByIndex(currentIndex).characters.GetSprite();
        currentIndex++;
    }

   
}
