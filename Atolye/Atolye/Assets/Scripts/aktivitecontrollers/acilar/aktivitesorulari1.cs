using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;
public class aktivitesorulari1 : MonoBehaviour
{
    [SerializeField] GameObject menupart;
    [SerializeField] GameObject aciolcerpart;
    [SerializeField] GameObject helppart;
    [SerializeField] GameObject bookpart;
    [SerializeField] GameObject adminbutton;
     
    [SerializeField] GameObject score;


    int clickforadminbutton = 0;

    bool activitetime = true;
    public void OpenAciolcerPart()
    {
        aciolcerpart.gameObject.SetActive(true);
    }
    public void OpenHelpPart()
    {
        helppart.gameObject.SetActive(true);
    }
    public void OpenMenuPart()
    {
        menupart.gameObject.SetActive(true);
    }

    public void CloseHelpPart()
    {
        helppart.gameObject.SetActive(false);
    }
    public void CloseMenuPart()
    {
        menupart.gameObject.SetActive(false);
    }

    public void CloseBookPart()
    {
        bookpart.SetActive(false);
        score.SetActive(false);
    }

    public void Book()
    {
        if (activitetime)
        {
            bookpart.SetActive(true); 
            score.SetActive(true);
        }
    }

 
    public void CloseTheÖdül()
    {
        try
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        catch
        {
            Debug.Log("Something goes wrong!");
        }
    }

 

    public void aktivite3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void aktivite4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void passtheactiviteAdminButton()
    {
        clickforadminbutton++;
        if (clickforadminbutton == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }     
    }
    public void gobacktheactiviteAdminButton()
    {
        clickforadminbutton++;
        if (clickforadminbutton == 1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }


}
