using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class Data
{
    public int level;
    public float[] position;
    public Transform pos;

    public Data(Data player)
    {
        level = player.level;
        position = new float[3];
        position[0] = player.pos.position.x;
        position[1] = player.pos.position.y;
        position[2] = player.pos.position.z;

    }
}
