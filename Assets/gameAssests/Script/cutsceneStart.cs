using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutsceneStart : MonoBehaviour
{
    [SerializeField] private GameObject cutscene;
    [SerializeField] private GameObject mainplayer;
    [SerializeField] private GameObject Cut_sceneplayer;
    [SerializeField] private GameObject cam1;
    [SerializeField] private GameObject cam2;
    [SerializeField] private GameObject cam3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void activate()
    {
        mainplayer.SetActive(true);
    }
    public void deactivate()
    {
        cutscene.SetActive(false);
        cam1.SetActive(false);
        cam2.SetActive(false);
        cam3.SetActive(false);
        Cut_sceneplayer.SetActive(false);
    }

}
