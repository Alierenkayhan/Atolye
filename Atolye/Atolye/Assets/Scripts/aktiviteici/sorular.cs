using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Unity.VisualScripting;

public class sorular : MonoBehaviour
{

    [SerializeField] GameObject[] pages;
    [SerializeField] TMPro.TMP_Dropdown[] dropboxs;
    [SerializeField] GameObject[] feedbackscreens;
    [SerializeField] GameObject[] kontroletbutton;
    [SerializeField] GameObject[] rightarrow;
    [SerializeField] GameObject[] leftarrow;

    [SerializeField] TextMeshProUGUI scoretext;
    [SerializeField] GameObject scoreparent;

    public GameObject devambtn;


    int score = 0;
    bool soruhakk1 = true;
    bool soruhakk2 = true;
    bool soruhakk3 = true;
    bool soruhakk4 = true;
    float clickbtn = 0;
    [SerializeField] int dogrunumber;
    [SerializeField] int arraynumber;

    [Header("Aktivite 1")]
    [SerializeField] GameObject page0;
    [SerializeField] GameObject page1;
    [SerializeField] GameObject page2;
    [SerializeField] GameObject page3;


  
    public void nextsoru()
    {

        pages[0].SetActive(false);
        pages[1].SetActive(true);
        clickbtn++;

        if (clickbtn == 2)
        {
            pages[1].SetActive(false);
            pages[2].SetActive(true);
 
 
        }
        else if (clickbtn == 3)
        {
            pages[1].SetActive(false);
            pages[2].SetActive(false);
            pages[3].SetActive(true);
 
 
        }
    }
    public void previousone()
    {
        clickbtn--;

        if (clickbtn == 2)
        {
            pages[3].SetActive(false);
            pages[2].SetActive(true);
            leftarrow[2].SetActive(false);
        }
        if (clickbtn == 1)
        {
            pages[2].SetActive(false);
            pages[1].SetActive(true);
            leftarrow[1].SetActive(false);
        }
        if (clickbtn == 0)
        {
            pages[1].SetActive(false);
            pages[0].SetActive(true);
            leftarrow[0].SetActive(false);
        }
    }

    public void Sorukontrolet1()
    {
        try
        {

            if (dropboxs[0].value == 0)
            {

                dropboxs[0].image.color = Color.green;
                feedbackscreens[0].SetActive(false);
                kontroletbutton[0].SetActive(false);
                rightarrow[0].SetActive(true);
                if (soruhakk1 == true)
                {
                    score = score + 5;
                    scoring.totalScore = scoring.totalScore + 5;
                    kontroletbutton[0].SetActive(false);
                }
            }
            else  
            {
                dropboxs[0].image.color = Color.red;
                feedbackscreens[0].SetActive(true);
                soruhakk1 = false;
            }
        }
        catch (System.Exception)
        {
            throw;
        }
    }


    public void Sorukontrolet2()
    {
        try
        {

            if (dropboxs[1].value == 3)
            {

                dropboxs[1].image.color = Color.green;
                feedbackscreens[1].SetActive(false);
                kontroletbutton[1].SetActive(false);
                rightarrow[1].SetActive(true);
                if (soruhakk2 == true)
                {
                    score = score + 5;
                    scoring.totalScore = scoring.totalScore + 5;
                    kontroletbutton[1].SetActive(false);
                }
            }
            else
            {
                dropboxs[1].image.color = Color.red;
                feedbackscreens[1].SetActive(true);
                soruhakk2 = false;
            }
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public void Sorukontrolet3()
    {
        try
        {

            if (dropboxs[2].value == 1)
            {

                dropboxs[2].image.color = Color.green;
                feedbackscreens[2].SetActive(false);
                kontroletbutton[2].SetActive(false);
                devambtn.SetActive(true);
                if (soruhakk3 == true)
                {
                    score = score + 5;
                    scoring.totalScore = scoring.totalScore + 5;
                    kontroletbutton[1].SetActive(false);
                }
            }
            else
            {
                dropboxs[2].image.color = Color.red;
                feedbackscreens[2].SetActive(true);
                soruhakk3 = false;
                devambtn.SetActive(false);
            }
        }
        catch (System.Exception)
        {
            throw;
        }
    }


    public void Sorukontrolet4()
    {
        try
        {

            if (dropboxs[0].value == 0)
            {

                dropboxs[0].image.color = Color.green;
                feedbackscreens[0].SetActive(false);
                kontroletbutton[0].SetActive(false);
                devambtn.SetActive(true);
                if (soruhakk1 == true)
                {
                    score = score + 5;
                    scoring.totalScore = scoring.totalScore + 5;
                    kontroletbutton[0].SetActive(false);
                }
            }
            else
            {
                dropboxs[0].image.color = Color.red;
                feedbackscreens[0].SetActive(true);
                soruhakk1 = false;
                devambtn.SetActive(false);
            }
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public void Sorukontrolet5()
    {
        try
        {

            if (dropboxs[0].value == dogrunumber)
            {

                dropboxs[arraynumber].image.color = Color.green;
                feedbackscreens[arraynumber].SetActive(false);
                kontroletbutton[arraynumber].SetActive(false);
                devambtn.SetActive(true);
                rightarrow[0].SetActive(true);
                if (soruhakk1 == true)
                {
                    score = score + 5;
                    scoring.totalScore = scoring.totalScore + 5;
                    kontroletbutton[arraynumber].SetActive(false);
                }
            }
            else
            {
                dropboxs[arraynumber].image.color = Color.red;
                feedbackscreens[arraynumber].SetActive(true);
                soruhakk1 = false;
                devambtn.SetActive(false);
                rightarrow[0].SetActive(false);

            }
        }
        catch (System.Exception)
        {
            throw;
        }
    }
    public void Sorukontrolet6()
    {
        try
        {

            if (dropboxs[0].value == dogrunumber)
            {

                dropboxs[arraynumber].image.color = Color.green;
                feedbackscreens[arraynumber].SetActive(false);
                kontroletbutton[arraynumber].SetActive(false);
                devambtn.SetActive(true);
                pages[arraynumber].SetActive(true);
                pages[arraynumber - 1].SetActive(false);
                if (soruhakk1 == true)
                {
                    score = score + 5;
                    scoring.totalScore = scoring.totalScore + 5;
                    kontroletbutton[arraynumber].SetActive(false);
                }
            }
            else
            {
                dropboxs[arraynumber].image.color = Color.red;
                feedbackscreens[arraynumber].SetActive(true);
                soruhakk1 = false;
                devambtn.SetActive(false);
            }
        }
        catch (System.Exception)
        {
            throw;
        }
    }

    public void Sorukontrolet7()
    {
        try
        {

            if (dropboxs[0].value == dogrunumber)
            {

                dropboxs[0].image.color = Color.green;
                feedbackscreens[0].SetActive(false);
                kontroletbutton[0].SetActive(false);
                devambtn.SetActive(true);
                rightarrow[0].SetActive(true);
                if (soruhakk1 == true)
                {
                    score = score + 5;
                    scoring.totalScore = scoring.totalScore + 5;
                    kontroletbutton[arraynumber].SetActive(false);
                }
            }
            else
            {
                dropboxs[0].image.color = Color.red;
                feedbackscreens[0].SetActive(true);
                soruhakk1 = false;
                devambtn.SetActive(false);
                rightarrow[0].SetActive(false);
            }
        }
        catch (System.Exception)
        {
            throw;
        }
    }
    
    public void Sorukontrolet8()
    {
        try
        {

            if (dropboxs[0].value == dogrunumber)
            {

                dropboxs[0].image.color = Color.green;
                feedbackscreens[0].SetActive(false);
                kontroletbutton[0].SetActive(false);
                devambtn.SetActive(true);
                 if (soruhakk4 == true)
                {
                    score = score + 5;
                    scoring.totalScore = scoring.totalScore + 5;
                    kontroletbutton[arraynumber].SetActive(false);
                }
            }
            else
            {
                dropboxs[0].image.color = Color.red;
                feedbackscreens[0].SetActive(true);
                soruhakk4 = false;
                devambtn.SetActive(false);
             }
        }
        catch (System.Exception)
        {
            throw;
        }
    }



    public void nextpage0to1()
    {
        page0.SetActive(false);
        page1.SetActive(true);
    }
    public void nextpage1to2()
    {
        page1.SetActive(false);
        page2.SetActive(true);
    }
    public void nextpage2to3()
    {
        page2.SetActive(false);
        page3.SetActive(true);
    }
 

    public void previouspage0to1()
    {
        page1.SetActive(false);
        page0.SetActive(true);
    }
    public void previouspage1to2()
    {
        page2.SetActive(false);
        page1.SetActive(true);
    }
    public void previouspage2to3()
    {
        page3.SetActive(false);
        page2.SetActive(true);
    }

    private void FixedUpdate()
    {
        scoretext.text = "Puan : " + scoring.totalScore.ToString();
    }
}
