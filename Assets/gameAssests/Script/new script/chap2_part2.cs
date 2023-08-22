using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class chap2_part2 : MonoBehaviour
{
    [SerializeField] GameObject timeline;
    [SerializeField] GameObject cam1;
    [SerializeField] GameObject cam2;
    [SerializeField] GameObject maincam;
    public Conversation convo;
    public GameObject dialoguebox;
    [SerializeField] GameObject nextclue;
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
        if (convo_Manager.isconvoDone == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

          //  FindObjectOfType<sceneManager>().loadScene(7);
            Debug.Log("next scene");

        }
    }
    public void deactcam2()
    {
        Destroy(cam2);

    }
    public void setcamera()
    {
        cam1.SetActive(false);
     //   timeline.SetActive(false);

    }
    public void activate()
    {
       
        
        maincam.SetActive(true);
        Convo_Manager.Startconversation(convo);
        nextclue.SetActive(true);
    }
}
 