using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forcutscene : MonoBehaviour
{

    [SerializeField] GameObject timeleneCut;

    [SerializeField] GameObject nextCanvas;
      [SerializeField] GameObject previewsCanvas;
    
    


    public void setTheScene()
    {
        
        nextCanvas.SetActive(true);
        previewsCanvas.SetActive(false);
    }
  

    public void delTimeline()
    {
        timeleneCut.SetActive(false);

    }
}
