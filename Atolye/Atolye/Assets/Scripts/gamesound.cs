using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamesound : MonoBehaviour
{
    private void Awake()
    {
        try
        {
            GameObject[] musicObj = GameObject.FindGameObjectsWithTag("BackgroundSounds");
            if (musicObj.Length > 1)
            {
                Destroy(this.gameObject);
            }
            DontDestroyOnLoad(this.gameObject);
        }
        catch
        {
            Debug.Log("Something goes wrong!");
        }
    }
}
