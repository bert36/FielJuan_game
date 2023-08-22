
using UnityEngine;


[CreateAssetMenu(fileName = "New Conversation", menuName ="Dialogue/New Conversation")]
public class Conversation : ScriptableObject
{
    [SerializeField] private DialogueLines[] allLines;

    public DialogueLines GetLinesByIndex(int index)
    {
        return allLines[index];
    }

    public int GetLength()
    {
        return allLines.Length -1;
    }



}
