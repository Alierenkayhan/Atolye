using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class end : MonoBehaviour
{
    public void RestartTheGame()
    {
        scoring.totalScore = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 8);
    }
    public void Quit()
    {
        Debug.Log("You closed the game.");
        Application.Quit();
    }

    [SerializeField] TextMeshProUGUI scoretext;
    [SerializeField] TextMeshProUGUI isimtext;
    private void FixedUpdate()
    {
        scoretext.text = scoring.totalScore.ToString();
        isimtext.text  = StoryLevelController.playernamestr.ToString();
    }
}
