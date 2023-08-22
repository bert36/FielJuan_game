using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class DialogueManager : MonoBehaviour
{
   // public DialogueObjects theoptions;

    //public Image charterImage;
    //public TMP_Text chartername;
    //public TMP_Text messagetext;

    //public TMP_Text btnName;
    //public TMP_Text[] optionButtons;
    //public GameObject optionBox;                      //buttoon
    //public RectTransform background;
    //Message[] currentMessage;
    //Characters[] currentCharacter;
    //int activeMessage = 0;
    //public  bool isActive = false;
    //private bool isoptionActive;
    //private int optionAmount;
    //private static DialogueManager instance;







    //private void Awake()
    //{
    //    if (instance != null)
    //    {
    //        Debug.LogWarning("Found more instance in the scene. only one");
    //    }
    //    instance = this;

       
    //}
    //public static DialogueManager GetInstance()
    //{
    //    return instance;
    //}


  
    
       
    

    //public void OpenDialogue(Message[] messages,  Characters[] characters)
    //{
    //    currentMessage = messages;
        
    //    currentCharacter = characters;
        
    //    activeMessage = 0;
    //    isActive = true;
    //    Debug.Log("started the convo! loaded messege:" + messages.Length);
    //    DisplayMessage();
    //    background.LeanScale(Vector3.one, 0.5f);
    //}


    //void DisplayMessage() 
    //{
    //    Message mesageToDisplay = currentMessage[activeMessage];
    //    messagetext.text = mesageToDisplay.message;

    //    Characters charterToDisplay = currentCharacter[mesageToDisplay.characterid];
    //    chartername.text = charterToDisplay.name;
    //    charterImage.sprite = charterToDisplay.sprite;

        
         
    //}

    
   
    //public IEnumerator NextMessage()
    //{
    //    yield return new WaitForSeconds(0.5f);

    //    activeMessage++;
    //    if (activeMessage< currentMessage.Length)
    //    {
    //        DisplayMessage();
          
              
    //    }else if(activeMessage == currentMessage.Length)
    //    {
    //        optionBox.SetActive(true);
    //          isoptionActive = true;
    //    }
    //    else
    //    {

          
    //        Debug.Log("relation/Conversation has ended");
    //        background.LeanScale(Vector3.zero, 0.5f).setEaseInOutExpo();
    //        isActive = false;
    //    }



    //}

    


    //void Update()
    //{
    //   // optionButtons.ToString = theoptions.OptionInfo;

    //   // btnName.

    //    if (Input.GetKeyDown(KeyCode.Space) &&isActive == true)
    //    {
    //       StartCoroutine(NextMessage());

            
            
           

    //    }
    //}

    // void Start()
    //{ 
    //    background.transform.localScale = Vector3.zero;
    //     optionBox.SetActive(false);

     
        

    //}

}
