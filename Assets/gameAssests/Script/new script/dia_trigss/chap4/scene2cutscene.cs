using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scene2cutscene : MonoBehaviour
{
    [SerializeField] GameObject timeline;
    [SerializeField] GameObject lastcon;
    [SerializeField] GameObject panel;


    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
       
    }
    public void deactivate()
    {
        panel.SetActive(false);
        timeline.SetActive(false);
        
       lastcon.SetActive(true);

    }
}
