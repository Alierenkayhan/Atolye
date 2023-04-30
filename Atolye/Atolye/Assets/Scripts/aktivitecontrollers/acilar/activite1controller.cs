using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;

public class activite1controller : MonoBehaviour
{
    [SerializeField] GameObject menupart;
    [SerializeField] GameObject aciolcerpart;
    [SerializeField] GameObject helppart;
    [SerializeField] GameObject bookpart;
    [SerializeField] GameObject adminbutton;
    [SerializeField] GameObject haritapart;

    [SerializeField] GameObject ödül;

    [SerializeField] GameObject ActiviteGiris;
    [SerializeField] GameObject Activite1;
    [SerializeField] GameObject Activite11;
    [SerializeField] GameObject Activite12;
    public GameObject Activite121;
    public GameObject Activite1son;


    public GameObject scoreparent;

    int clickforadminbutton = 0;
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
    public void OpenHarita()
    {
        haritapart.SetActive(true);
    }
    public void CloseHarita()
    {
        haritapart.SetActive(false);
    }
    public void CloseHelpPart()
    {
        helppart.gameObject.SetActive(false);
    }
    public void CloseMenuPart()
    {
        menupart.gameObject.SetActive(false);
    }
    public void Book()
    {
        bookpart.gameObject.SetActive(!bookpart.gameObject.activeSelf);
        scoreparent.gameObject.SetActive(!scoreparent.gameObject.activeSelf);
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
            Activite11.SetActive(true);
        }
        if (clickforadminbutton == 3)
        {
            Activite11.SetActive(false);
            Activite12.SetActive(true);
        }
        if (clickforadminbutton == 4)
        {
            Activite12.SetActive(false);
            Activite121.SetActive(true);
        }
        if (clickforadminbutton == 5)
        {
            Activite121.SetActive(false);
            Activite1son.SetActive(true);
        }
        if (clickforadminbutton == 6)
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
            Activite11.SetActive(false);
        }
        if (clickforadminbutton == 2)
        {
            Activite11.SetActive(true);
            Activite12.SetActive(false);
        }
        if (clickforadminbutton == 3)
        {
            Activite12.SetActive(true);
            Activite121.SetActive(false);
        }
        if (clickforadminbutton == 4)
        {
            Activite121.SetActive(true);
            Activite1son.SetActive(false);
        }
    }
}
