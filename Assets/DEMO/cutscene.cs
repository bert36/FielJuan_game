using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutscene : MonoBehaviour
{
    [SerializeField] GameObject mainmenuCanvas;
    [SerializeField] GameObject cutsceneCanvas;
    
    


    public void setTheScene()
    {
        
        mainmenuCanvas.SetActive(true);
        cutsceneCanvas.SetActive(false);
    }
}
