using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charControl : MonoBehaviour
{
    [SerializeField] private Animator m_animator = null;
    [SerializeField] private Rigidbody m_rigidBody = null;
 
    public float Speed;

   
    private bool m_jumpInput = false;

    private bool m_isGrounded;
    private void Awake()
    {
        if (!m_animator) { gameObject.GetComponent<Animator>(); }
        if (!m_rigidBody) { gameObject.GetComponent<Animator>(); }
    }

   
    private void Update()
    {
        //if (Convo_Manager.Getinstance().isconvoActive == true)

        //    return;

        playerMovement();
        if (!m_jumpInput && Input.GetKey(KeyCode.Space))
        {
            m_jumpInput = true;
        }
    }

    private void FixedUpdate()
    {
        m_animator.SetBool("Grounded", m_isGrounded);

        
       
    }
 

  
    void playerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        Vector3 playermove = new Vector3(hor, 0, ver) * Speed* Time.deltaTime;
        transform.Translate(playermove, Space.Self);



        if (playermove != Vector3.zero)
        {
          

            m_animator.SetFloat("MoveSpeed", playermove.magnitude);
        }
    }
}
