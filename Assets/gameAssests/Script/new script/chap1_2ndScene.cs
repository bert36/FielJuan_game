using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chap1_2ndScene : MonoBehaviour
{
    [SerializeField] private GameObject cam4;
    [SerializeField] private GameObject nextClue;


    // Start is called before the first frame update
    void Start()
    {
        nextClue.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void activate()
    {
        nextClue.SetActive(true);
    }
    public void deactivate()
    {
        
        cam4.SetActive(false);
        
    }

}
