using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class lastcon : MonoBehaviour
{
    public Conversation convo;
    public GameObject dialoguebox;
    private bool istalking = false;
    Convo_Manager convo_Manager;
    [SerializeField] GameObject conmaneger;


    // Start is called before the first frame update
    void Awake()
    {

        convo_Manager = conmaneger.GetComponent<Convo_Manager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (convo_Manager.isconvoDone == true && istalking == true)
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

            Debug.Log("next scene");

        }
    }
    public void activate()
    {
        istalking = true;
        Convo_Manager.Startconversation(convo);
        // nextclue.SetActive(
    }

}
