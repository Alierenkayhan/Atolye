using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class basadön : MonoBehaviour
{
    public int number;
    public void basadönbtn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - number);
    }
        
}
