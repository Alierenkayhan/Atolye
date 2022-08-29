using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;
public class StoryLevelController : MonoBehaviour
{

    [SerializeField] GameObject teacher;

    [SerializeField] GameObject bubble1;
    [SerializeField] GameObject bubble2;
    [SerializeField] GameObject bubble3;
    [SerializeField] GameObject bubble4;
    [SerializeField] GameObject bubble5;
    [SerializeField] GameObject bubble6;
    [SerializeField] GameObject bubble7;

    [SerializeField] GameObject square;


    [SerializeField] GameObject chair1;
    [SerializeField] GameObject chair2;
    [SerializeField] GameObject chair3;
    [SerializeField] GameObject table1;
 

    [SerializeField] TextMeshProUGUI txt6;
    [SerializeField] TextMeshProUGUI txt7;

    [SerializeField] GameObject rightarrow;
    [SerializeField] GameObject leftarrow;

    Animator teacheranim;

    [SerializeField] GameObject Story;
    [SerializeField] GameObject GetName;

    [SerializeField] TextMeshProUGUI Inputusername;

    public static string playernamestr;

    int click = 0;

    void Start()
    {
        playernamestr = Inputusername.text;
       
        teacheranim = teacher.GetComponent<Animator>();
    }

    void Update()
    {
        playernamestr = Inputusername.text;


        if (teacheranim.GetCurrentAnimatorStateInfo(0).IsName("teacherdefault"))
        {
            rightarrow.SetActive(true);
        }

        //Debug.Log("Username: " + playernamestr);

        txt6.text = "Bu hafta seçilen kişi " + playernamestr;
        txt7.text = playernamestr + ", okulumuzun mobilyalarını tamir edeceğine inanıyoruz.";
    }
    
    public void NextText()
    {
        click++;
        //Debug.Log("Click number: " + click);
        try
        {
            if (click == 1)
            {
                bubble1.SetActive(true);
                bubble2.SetActive(false);
            }
            if (click == 2)
            {
                bubble1.SetActive(false);
                bubble2.SetActive(true);
                leftarrow.SetActive(true);
            }
            if (click == 3)
            {
                bubble2.SetActive(false);
                bubble3.SetActive(true);
                square.SetActive(true);
            } 
            if (click == 4)
            {
                bubble3.SetActive(false);
                square.SetActive(false);
                chair1.SetActive(true);  
            }
            if (click == 5)
            {
                chair1.SetActive(false);
                chair2.SetActive(true);
            }
            if (click == 6)
            {
                chair2.SetActive(false);
                chair3.SetActive(true);
            }
            if (click == 7)
            {
                chair3.SetActive(false);
                table1.SetActive(true);
            }
            if (click == 8)
            {
                table1.SetActive(false);
                bubble4.SetActive(true);
            }
            if (click == 9)
            {
                bubble4.SetActive(false);
                bubble5.SetActive(true);
            }
            if (click == 10)
            {
                bubble5.SetActive(false);
                bubble6.SetActive(true);
            }
            if (click == 11)
            {
                bubble6.SetActive(false);
                bubble7.SetActive(true);
            }
            if (click == 12)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
        catch
        {
            Debug.Log("Something goes wrong!");
        }
    }

    public void PreviousText()
    {
        click--;
        //Debug.Log("Click number: " + click);
        try
        {
            if (click == 0)
            {
                bubble1.SetActive(false);
            }
            if (click == 1)
            {
                bubble1.SetActive(true);
                bubble2.SetActive(false);
                leftarrow.SetActive(false);
            }
            if (click == 2)
            {
                bubble2.SetActive(true);
                bubble3.SetActive(false);
                square.SetActive(false);

            }
           if (click == 3)
            {
                bubble3.SetActive(true);
                square.SetActive(true);
                chair1.SetActive(false);
            }
            if (click == 4)
            {
                chair1.SetActive(true);
                chair2.SetActive(false);
            }
            if (click == 5)
            {
                chair2.SetActive(true);
                chair3.SetActive(false);
            }
            if (click == 6)
            {
                chair3.SetActive(true);
                table1.SetActive(false);
            }
            if (click == 7)
            {
                table1.SetActive(true);
                bubble4.SetActive(false);
            }
            if (click == 8)
            {
                bubble4.SetActive(true);
                bubble5.SetActive(false);
            }
            if (click == 9)
            {
                bubble5.SetActive(true);
                bubble6.SetActive(false);
            }
            if (click == 10)
            {
                bubble6.SetActive(true);
                bubble7.SetActive(false);
            }
        }
        catch
        {
            Debug.Log("Something goes wrong!");
        }
    }

    public void StoryBegin()
    {
        GetName.SetActive(false);
        Story.SetActive(true);

    }
}

