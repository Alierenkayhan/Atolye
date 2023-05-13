using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using Unity.VisualScripting;

public class aktivite33 : MonoBehaviour
{
    [SerializeField] GameObject yesilodun;
    [SerializeField] TextMeshProUGUI yesilodundegeryeri2;

    [SerializeField] TMP_InputField yesilodundegeryeri;


    [SerializeField] GameObject kirmiziodun;
    [SerializeField] TextMeshProUGUI kirmiziodundegeryeri2;

    public GameObject feedbackscreen;

    public GameObject okaybutton;
    public GameObject kontroletbutton;

    float yesildeger;
    float yesildeger2;
    float kirmizideger;
    float kirmizideger2;

    public string hedefyesilaci;
    public string hedefkirmizilaci;

    public float cikartilacakdegeryesil;
    public float cikartilacakdegerkirmizi;
 

    void FixedUpdate()
    {
        try
        {
            yesildeger = yesilodun.transform.rotation.eulerAngles.z;
            yesildeger2 = yesilodun.transform.rotation.eulerAngles.z - cikartilacakdegeryesil;

             yesilodundegeryeri2.text = yesildeger2.ToString("n0") + "°";


            kirmizideger = kirmiziodun.transform.rotation.eulerAngles.z;
            kirmizideger2 = kirmiziodun.transform.rotation.eulerAngles.z - cikartilacakdegerkirmizi;
            kirmiziodundegeryeri2.text = kirmizideger2.ToString("n0") + "°";
        
        }
        catch (System.Exception)
        {

            throw;
        }
    }

    public void KontrolEt()
    {
        if (yesilodundegeryeri.text == hedefyesilaci)
        {
            okaybutton.SetActive(true);
            kontroletbutton.SetActive(false);
            yesilodundegeryeri.interactable = false;
        }
        else
        {
            okaybutton.SetActive(false);
            kontroletbutton.SetActive(true);
            feedbackscreen.SetActive(true);
            yesilodundegeryeri.interactable = true;
        }
    }
    public void closefeedbackscreen()
    {
        feedbackscreen.SetActive(false);
    }
}
