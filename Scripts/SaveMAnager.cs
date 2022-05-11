using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine;

public static class SaveMAnager
{
    public static void SavePlayer()
    {   
        PlayerData data = new PlayerData();
        PlayerPrefs.SetInt("money", data.moneyPlayer);
        for (int i = 0; i < 2; ++i)
        {
            PlayerPrefs.SetInt("car" + i.ToString(), data.owned[i]);
        }

        /*As file
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.sk";
        FileStream stream = new FileStream(path, FileMode.Create);
        
        formatter.Serialize(stream, data);
        stream.Close();
        */

    }
    
    public static PlayerData LoadPlayer()
    {
        PlayerData data = new PlayerData();
        data.moneyPlayer = PlayerPrefs.GetInt("money", 1000);
        //load owned cars
        for(int i = 0; i < 2; ++i)
        {
            data.owned[i] = PlayerPrefs.GetInt("car"+i.ToString(), 0);
        }
        return data;
        //Save as file
        /*
         string path = Application.persistentDataPath + "/player.fun";
         if (File.Exists(path))
         {
             BinaryFormatter formatter = new BinaryFormatter();
             FileStream stream = new FileStream(path, FileMode.Open);

             PlayerData data = formatter.Deserialize(stream) as PlayerData;
             stream.Close();

             return data;
         }
         else
         {
             Debug.LogError("No Save file found in " + path);
             return null;
         }
        */

    }
}
