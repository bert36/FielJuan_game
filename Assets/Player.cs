using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int level = 1;
    
    public void SavePlayer()
    {
        //SaveSystem.SavePlayer(this);
    }

    public void LoadPlayer()
    {
        Data data = SaveSystem.LoadPlayer();

        level = data.level;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];

        transform.position = position; 
    }

    // Start is called before the first frame update
    void Start()
    {
        LoadPlayer();
    }

    // Update is called once per frame
    void Update()
    {
        //SavePlayer();
    }
}
