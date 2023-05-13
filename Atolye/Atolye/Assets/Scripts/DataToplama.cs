using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class DataToplama : MonoBehaviour
{
    public GameObject[] scene;
    private int activeSceneIndex = -1;
    public float timer = 0f;
 
    void Update()
    {
        // Aktif sahneyi bulun
        int newActiveSceneIndex = -1;
        for (int i = 0; i < scene.Length; i++)
        {
            if (scene[i].activeSelf)
            {
                newActiveSceneIndex = i;
                break;
            }
        }

        // Eğer aktif sahne değiştiyse
        if (newActiveSceneIndex != activeSceneIndex)
        {
            if (activeSceneIndex >= 0)
            {
                // Eski aktif sahne zamanlayıcısını listeye ekle
                DataWrite.TimeData.Add(scene[activeSceneIndex].name,timer);
            }

            // Yeni aktif sahne indeksini güncelle ve zamanlayıcıyı sıfırla
            activeSceneIndex = newActiveSceneIndex;
            timer = 0f;
        }

        // Aktif sahne varsa zamanlayıcıyı arttır
        if (activeSceneIndex >= 0)
        {
            timer += Time.deltaTime;
        }
    }
}
