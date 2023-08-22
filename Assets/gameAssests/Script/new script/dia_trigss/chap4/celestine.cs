using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class celestine : MonoBehaviour
{

    Animator animator;

    private bool IsPlayerinRange;
    private bool isTalking = false;
   
    
    
    [SerializeField] GameObject escapetask;
   


    void Start()
    {
        IsPlayerinRange = false;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (IsPlayerinRange == true)
        {
            animator.SetBool("iswalking", false);

          
        }
        else
        {
            animator.SetBool("iswalking", true);

        }

       
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            IsPlayerinRange = true;

            Debug.Log("detectedyg");
        }


    }

    public void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            IsPlayerinRange = false;

        }
    }
}
