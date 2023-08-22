using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Atomic.DialogueSystem
{

    [CreateAssetMenu(fileName = "DialogueObject", menuName = "NPC Dialogue", order = 0)]
    public class DialogueObjects : ScriptableObject
    {
        //[Header("Dialogue")]
        //public List<string> dialogueString = new List<string>();
       
       
 
        public Message[] messages;
    // public GameObject options;
         public Characters[] characters;


        [Header("For option dialogue")]
        public DialogueObjects endNgDialogue;


    }




    [System.Serializable]
    public class Message
    {
        public int characterid;
        [TextArea(3, 15)]
        public string message;
        public bool isItQuestion;


    }


    [System.Serializable]
    public class Characters
    {
        public string name;
        public Sprite sprite;
    }






}


