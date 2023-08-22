using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flowersborder : MonoBehaviour
{
    private bool IsPlayerinRange;
    [SerializeField] GameObject gototext;
    [SerializeField] GameObject counter;
    [SerializeField] GameObject qcollect;
    [SerializeField] GameObject tamara;
    [SerializeField] GameObject oldTamara;
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
        if (other.gameObject.tag == "Player")
        {
            oldTamara.SetActive(false);
            tamara.SetActive(true);
            counter.SetActive(true);
            qcollect.SetActive(true);
            gototext.SetActive(false);
            IsPlayerinRange = true;
            Debug.Log("detected");
        }


    }

    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            IsPlayerinRange = false;
            Destroy(gameObject);

        }
    }

}
