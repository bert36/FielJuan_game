
using UnityEngine;


[CreateAssetMenu(fileName = "New Character", menuName = "Dialogue/New Character")]
public class Characters_s : ScriptableObject
{
    [SerializeField] private string Character_Name;
    [SerializeField] private Sprite Character_sprite;

    public string GetName()
    {
        return Character_Name;
    }

    public Sprite GetSprite()
    {
        return Character_sprite;
    }
}
