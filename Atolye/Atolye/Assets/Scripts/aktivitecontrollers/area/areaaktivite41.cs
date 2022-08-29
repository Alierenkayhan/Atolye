using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class areaaktivite41 : MonoBehaviour
{
    public int dogrualan;
    public TMP_InputField inputfield;

    public TMP_Dropdown dropdown;
    public int dropdownvalue;
    public GameObject kontroletbtn;
    public GameObject devambtn;
    public GameObject feedbackscreen;
    public GameObject aktivite41;
    public GameObject aktivite42;

    public void kontrolet()
    {
        if (inputfield.text == dogrualan.ToString() && dropdown.value == dropdownvalue)
        {
            kontroletbtn.SetActive(false);
            devambtn.SetActive(true);

        }
        else
        {
            feedbackscreen.SetActive(true);
            kontroletbtn.SetActive(true);
            devambtn.SetActive(false);
        }
    }
    public void closethefeedbackscreen()
    {
        feedbackscreen.SetActive(false);

    }    
    public void devamet1()
    {
        aktivite41.SetActive(false);
        aktivite42.SetActive(true);

    }
}
