﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grasscolider : MonoBehaviour
{
    public bool IsPlayerinRange;




    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "grassBox")
        {
            IsPlayerinRange = true;

            Debug.Log("detected");
        }


    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "grassBox")
        {
            IsPlayerinRange = false;

        }
    }

}
