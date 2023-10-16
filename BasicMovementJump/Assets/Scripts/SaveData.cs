using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using UnityEngine.SocialPlatforms.Impl;

public static class SaveData
{
    public static void saveScore(int s)
    {
        if (s > loadScore())
        {
            string path = Application.persistentDataPath + "/playerScore.sc";

            BinaryFormatter bf = new BinaryFormatter();

            FileStream stream = new FileStream(path, FileMode.Create);

            bf.Serialize(stream, s);

            stream.Close();
        }
    }

    public static int loadScore()
    {
        string path = Application.persistentDataPath + "/playerScore.sc";

        if (File.Exists(path))
        {
            BinaryFormatter bf = new BinaryFormatter();

            FileStream stream = new FileStream(path, FileMode.Open);

            int score = (int) bf.Deserialize(stream);

            stream.Close();

            return score;
        }
        else
        {
            Debug.LogError("File Not Found In " + path);
            return -999;
        }
    }
}
