using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;
public class activite2controller : MonoBehaviour
{

    [SerializeField] GameObject menupart;
    [SerializeField] GameObject aciolcerpart;
    [SerializeField] GameObject helppart;
    [SerializeField] GameObject bookpart;
    [SerializeField] GameObject scoreparent;
    [SerializeField] GameObject archieve;
    [SerializeField] GameObject harita;

    [SerializeField] GameObject rightarrow;
    [SerializeField] GameObject rightarrow2;

    [SerializeField] GameObject ActiviteGiris;

    [SerializeField] GameObject Activite1;

    [SerializeField] GameObject Activite12;

    [SerializeField] GameObject Activite1Son;

    [SerializeField] GameObject ödül;

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

    public void StartTheAcitivity1()
    {
        ActiviteGiris.SetActive(false);
        Activite1.SetActive(true);
        rightarrow.SetActive(false);
    }

    public void Book()
    {
        bookpart.gameObject.SetActive(!bookpart.gameObject.activeSelf);
        scoreparent.gameObject.SetActive(!scoreparent.gameObject.activeSelf);
    }
    public void Archieve()
    {
        archieve.gameObject.SetActive(true);
    }
    public void CloseArchieve()
    {
        archieve.gameObject.SetActive(false);
    }

    public void Harita()
    {
        harita.gameObject.SetActive(true);
    }
    public void CloseHarita()
    {
        harita.gameObject.SetActive(false);
    }

    public void StartTheAcitivity12()
    {
        Activite1.SetActive(false);
        Activite12.SetActive(true);
    }

    public void EndTheAcitivity1()
    {
        Activite12.SetActive(false);

        Activite1Son.SetActive(true);
    }

    public void ShowTheÖdül()
    {
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


    public void Aktivite21()
    {
        Activite1.SetActive(false);
        Activite12.SetActive(true);
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
            Activite1Son.SetActive(true);
        }
        if (clickforadminbutton == 4)
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
            Activite1Son.SetActive(false);
        }
    }
}
