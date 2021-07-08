using System.IO;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public static class Saving
{
    
    public static void savePlayerData(ScoreTrack player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/playerData.yeeter";
        FileStream stream = new FileStream(path, FileMode.Create);

        PlayerSave dataSave = new PlayerSave(player);
        formatter.Serialize(stream, dataSave);

        stream.Close();
    }

    public static PlayerSave loadPlayerData()
    {
        string path = Application.persistentDataPath + "/playerData.yeeter";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            PlayerSave data = (PlayerSave)formatter.Deserialize(stream);
            stream.Close();
            return data;
        }
        else
        {
            Debug.LogError("Save file not found" + path);
            return null;
        }
    }




    
}
