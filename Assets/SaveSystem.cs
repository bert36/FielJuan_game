using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer(Data player) {

        BinaryFormatter formatter = new BinaryFormatter();

        string path = Application.persistentDataPath + "Player.bnry";
        FileStream stream = new FileStream(path, FileMode.Create);

        Data data = new Data(player);

        formatter.Serialize(stream, data);
        stream.Close();

    }

    public static Data LoadPlayer()
    {
        string path = Application.persistentDataPath + "Player.bnry";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);
            stream.Close();

            Data data = formatter.Deserialize(stream) as Data;

            return data;
        }
        else
        {
            Debug.LogError("SAVE FILE NOT FOUND! " + path);
            return null;
        }
    }
}
