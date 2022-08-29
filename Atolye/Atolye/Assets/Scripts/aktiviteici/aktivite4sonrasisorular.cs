using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class aktivite4sonrasisorular : MonoBehaviour
{
    [SerializeField] GameObject konusmabalonumetni1;
    [SerializeField] GameObject konusmabalonumetni2;

    [SerializeField] GameObject ilksayfa;
    [SerializeField] GameObject sorupage1;
    [SerializeField] GameObject sorupage2;

    [SerializeField] TMPro.TMP_Dropdown soru2dropbox;
    [SerializeField] GameObject feedbackscreen;

    [SerializeField] GameObject nextaktivite;

    [SerializeField] TMPro.TMP_Dropdown soru1dropbox;
    [SerializeField] GameObject feedbackscreen1;
    [SerializeField] GameObject nextsoru;

    [SerializeField] GameObject kontroletbutton2;

    [SerializeField] TextMeshProUGUI scoretext;
    [SerializeField] GameObject scoreparent;
    [SerializeField] GameObject nextactivite;

    [SerializeField] GameObject kontroletbtn1;
    [SerializeField] GameObject kontroletbtn2;

    int score = 0;
    bool soru1hakk = true;
    bool soru2hakk = true;
    public void NextPage1()
    {
        ilksayfa.SetActive(false);
        sorupage1.SetActive(true);

    }
    public void NextPage2()
    {
        sorupage1.SetActive(false);
        sorupage2.SetActive(true);
    }

    public void PreviousPage1()
    {
        ilksayfa.SetActive(true);
        sorupage1.SetActive(false);
    }
    public void PreviousPage2()
    {
        sorupage1.SetActive(true);
        sorupage2.SetActive(false);

    }

    public void CloseTheBook()
    {
        sorupage1.SetActive(false);
        scoreparent.SetActive(false);
    }


    public void Soru2kontrolet()
    {
        try
        {
            if (soru2dropbox.value == 0)
            {
                soru2dropbox.image.color = Color.green;
                feedbackscreen.SetActive(false);
                kontroletbutton2.SetActive(false);
                nextaktivite.SetActive(true);
                if (soru2hakk == true)
                {
                    score = score + 5;
                    scoring.totalScore = scoring.totalScore + 5;
                    kontroletbtn2.SetActive(false);
                }
            }
            else
            {
                soru2dropbox.image.color = Color.red;
                feedbackscreen.SetActive(true);
                soru2hakk = false;
            }
        }
        catch (System.Exception)
        {
            throw;
        }

    }

    public void kapat()
    {
        sorupage2.SetActive(false);
        konusmabalonumetni1.SetActive(false);
        konusmabalonumetni2.SetActive(true);
        nextactivite.SetActive(true);
        scoreparent.SetActive(false);
    }

    public void Soru1kontrolet()
    {
        try
        {
            if (soru1dropbox.value == 1)
            {
                soru1dropbox.image.color = Color.green;
                feedbackscreen1.SetActive(false);
                nextsoru.SetActive(true);
                if (soru1hakk == true)
                {
                    score = score + 5;
                    scoring.totalScore = scoring.totalScore + 5;
                    kontroletbtn1.SetActive(false);
                }
            }
            else
            {
                soru1dropbox.image.color = Color.red;
                feedbackscreen1.SetActive(true);
                soru1hakk = false;
            }
        }
        catch (System.Exception)
        {
            throw;
        }

    }


    private void FixedUpdate()
    {
        scoretext.text = "Score: " + scoring.totalScore.ToString();
    }
}
