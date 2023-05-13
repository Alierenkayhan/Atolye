using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using Newtonsoft.Json;

public class DataWrite:MonoBehaviour
{
    public static Dictionary<string, float> TimeData = new Dictionary<string, float>();
    Dictionary<string, Dictionary<string, float>> myDictionary = new Dictionary<string, Dictionary<string, float>>();
    string score = scoring.totalScore.ToString();
    public GameObject levelcontrol;
    public void SaveData()
    {
        try
        {
            // Yeni verileri sözlüğe ekle
            myDictionary.Add(score, TimeData);

            // Verileri kontrol etmek için sözlüğü yazdırın
            foreach (KeyValuePair<string, Dictionary<string, float>> kvp in myDictionary)
            {
                Debug.Log("Score: " + kvp.Key);
                foreach (KeyValuePair<string, float> kvp2 in kvp.Value)
                {
                    Debug.Log("Activity name and time: " + kvp2.Key);
                }
            }

            // Daha önce oluşturulmuş verileri dosyadan okuyun
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/" + levelcontrol.GetComponent<end>().isimtext.text + "data.json";

            // Verileri JSON formatına dönüştürün
            string jsonData = JsonConvert.SerializeObject(myDictionary, Formatting.Indented);

            // Dosyaya yeniden yazın
            File.WriteAllText(filePath, jsonData);

            Debug.Log("Data saved successfully!");
        }
        catch (Exception ex) { Debug.LogError("An error occurred while saving data: " + ex.Message); }
    }
}

