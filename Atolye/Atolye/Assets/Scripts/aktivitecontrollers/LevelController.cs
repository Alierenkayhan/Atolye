using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
public class LevelController : MonoBehaviour
{

    private TMP_Text playername;


   public void LoadSettingsScene()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }

   public void LoadAboutUsScene()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
   }
    public void LoadTutorialScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }
    public void Quit()
   {
       Debug.Log("You closed the game.");
       Application.Quit();
   }

   public void BackFromAboutUs()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
   }
   
   public void BackFromSettings()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
   }

    public void BackFromTutorial()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
    }

    public void LoadStoryScene()
   {
        try
        {
            scoring.totalScore = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
        }
        catch
        {
            Debug.Log("Something goes wrong!");
        }
   }
   
}



