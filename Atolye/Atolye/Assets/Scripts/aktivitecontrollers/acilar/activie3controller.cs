using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;
using TMPro;
public class activie3controller : MonoBehaviour
{
    [SerializeField] GameObject menupart;
    [SerializeField] GameObject aciolcerpart;
    [SerializeField] GameObject helppart;
    [SerializeField] GameObject bookpart;

    [SerializeField] GameObject rightarrow;
    [SerializeField] GameObject rightarrow1;
    [SerializeField] GameObject rightarrow2;


    [SerializeField] GameObject ActiviteGiris;
    [SerializeField] GameObject Activite11;
    [SerializeField] GameObject Activite12;
    [SerializeField] GameObject Activite122;
    [SerializeField] GameObject Activite21;
    [SerializeField] GameObject Activite22;
    [SerializeField] GameObject Activite221;
    [SerializeField] GameObject Activite31;
    [SerializeField] GameObject Activite32;
    [SerializeField] GameObject Activite322;
    [SerializeField] GameObject ActiviteSon;
    [SerializeField] GameObject ödül;


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
        bookpart.SetActive(true);
    }

    public void StartTheAcitivity1()
    {
        ActiviteGiris.SetActive(false);
        Activite11.SetActive(true);
        rightarrow.SetActive(false);
    }
    public void Activite12Begin()
    {
        Activite11.SetActive(false);
        Activite12.SetActive(true);
    }

    public void Activite12Begin2()
    {
        Activite12.SetActive(false);
        Activite122.SetActive(true);
    }

    public void Activite22Begin()
    {
        Activite21.SetActive(false);
        Activite22.SetActive(true);
    }

    public void Activite32Begin()
    {
        Activite31.SetActive(false);
        Activite32.SetActive(true);
    }

    public void ShowÖdül()
    {
        ödül.SetActive(true);
        rightarrow1.SetActive(false);
        rightarrow2.SetActive(true);

    }
    public void CloseÖdül()
    {
        ödül.SetActive(false);
    }

    public void Activite3Sorular()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void passtheactiviteAdminButton()
    {
        clickforadminbutton++;
        if (clickforadminbutton == 1)
        {
            ActiviteGiris.SetActive(false);
            Activite11.SetActive(true);
        }
        if (clickforadminbutton == 2)
        {
            Activite11.SetActive(false);
            Activite12.SetActive(true);
        }
        if (clickforadminbutton == 3)
        {
            Activite12.SetActive(false);
            Activite122.SetActive(true);
        }
        if (clickforadminbutton == 4)
        {
            Activite122.SetActive(false);
            Activite21.SetActive(true);
        }
        if (clickforadminbutton == 5)
        {
            Activite21.SetActive(false);
            Activite22.SetActive(true);
        }
        if (clickforadminbutton == 6)
        {
            Activite22.SetActive(false);
            Activite221.SetActive(true);
        }
        if (clickforadminbutton == 7)
        {
            Activite221.SetActive(false);
            Activite31.SetActive(true);
        }
        if (clickforadminbutton == 8)
        {
            Activite31.SetActive(false);
            Activite32.SetActive(true);
        }
        if (clickforadminbutton == 9)
        {
            Activite32.SetActive(false);
            Activite322.SetActive(true);
        }
        if (clickforadminbutton == 10)
        {
            Activite322.SetActive(false);
            ActiviteSon.SetActive(true);
        }
        if (clickforadminbutton == 11)
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
            Activite11.SetActive(false);
        }
        if (clickforadminbutton == 1)
        {
            Activite11.SetActive(true);
            Activite12.SetActive(false);
        }
        if (clickforadminbutton == 2)
        {
            Activite12.SetActive(true);
            Activite122.SetActive(false);
        }
        if (clickforadminbutton == 3)
        {
            Activite122.SetActive(true);
            Activite21.SetActive(false);
        }
        if (clickforadminbutton == 4)
        {
            Activite21.SetActive(true);
            Activite22.SetActive(false);
        }
        if (clickforadminbutton == 5)
        {
            Activite22.SetActive(true);
            Activite221.SetActive(false);
        }
        if (clickforadminbutton == 6)
        {
            Activite221.SetActive(true);
            Activite31.SetActive(false);
        }
        if (clickforadminbutton == 7)
        {
            Activite31.SetActive(true);
            Activite32.SetActive(false);
        }
        if (clickforadminbutton == 8)
        {
            Activite32.SetActive(true);
            Activite322.SetActive(false);
        }
        if (clickforadminbutton == 9)
        {
            Activite322.SetActive(true);
            ActiviteSon.SetActive(false);
        }

    }

}