using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;
public class aktivite4levelcontrollers : MonoBehaviour
{

    [SerializeField] GameObject menupart;
    [SerializeField] GameObject aciolcerpart;
    [SerializeField] GameObject helppart;
    [SerializeField] GameObject bookpart;
    [SerializeField] GameObject adminbutton;

    [SerializeField] GameObject ödül;

    [SerializeField] GameObject ActiviteGiris;
    [SerializeField] GameObject Activite1;
    [SerializeField] GameObject Activite12;
    [SerializeField] GameObject Activite1son;
    public GameObject Activite13;



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
    }

    public void Book()
    {
        if (activitetime)
        {
            bookpart.SetActive(true);
        }
    }

    public void ShowTheÖdül()
    {
        Activite12.SetActive(false);
        ödül.SetActive(true);
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

    public void StartTheAcitivity1()
    {
        ActiviteGiris.SetActive(false);
        Activite1.SetActive(true);
        clickforadminbutton++;
    }

    public void aktivite3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void passtheactiviteAdminButton()
    {
        clickforadminbutton++;
        if (clickforadminbutton == 1)
        {
            ActiviteGiris.SetActive(false);
            Activite1.SetActive(true);
        }
        if (clickforadminbutton == 2)
        {
            Activite1.SetActive(false);
            Activite12.SetActive(true);
        }
        if (clickforadminbutton == 3)
        {
            Activite12.SetActive(false);
            Activite13.SetActive(true);
        }
        if (clickforadminbutton == 4)
        {
            Activite13.SetActive(false);
            Activite1son.SetActive(true);
        }
        if (clickforadminbutton == 5)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }


    public void gobacktheactiviteAdminButton()
    {
        clickforadminbutton--;
        if (clickforadminbutton == -1)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        if (clickforadminbutton == 0)
        {
            ActiviteGiris.SetActive(true);
            Activite1.SetActive(false);
        }
        if (clickforadminbutton == 1)
        {
            Activite1.SetActive(true);
            Activite12.SetActive(false);
        }
        if (clickforadminbutton == 2)
        {
            Activite12.SetActive(true);
            Activite13.SetActive(false);
        }
        if (clickforadminbutton == 3)
        {
            Activite13.SetActive(true);
            Activite1son.SetActive(false);
        }

    }

}
