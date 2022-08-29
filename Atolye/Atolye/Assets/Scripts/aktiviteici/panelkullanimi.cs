using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class panelkullanimi : MonoBehaviour
{
    [SerializeField] GameObject yesilodun;
    [SerializeField] TextMeshProUGUI yesilodundegeryeri;
    [SerializeField] TextMeshProUGUI yesilodundegeryeri2;


    [SerializeField] GameObject kirmiziodun;
    [SerializeField] TextMeshProUGUI kirmiziodundegeryeri;
    [SerializeField] TextMeshProUGUI kirmiziodundegeryeri2;

    [SerializeField] GameObject helpmenu;
    public bool helpmenuactive = false;

    public GameObject okaybutton;

    float yesildeger;
    float yesildeger2;
    float kirmizideger;
    float kirmizideger2;

    public string hedefyesilaci;
    public string hedefkirmizilaci;

    [SerializeField] GameObject yesilpanelisik;
    [SerializeField] GameObject kirmizipanelisik;
    void FixedUpdate()
    {
        try
        {
            yesildeger = yesilodun.transform.rotation.eulerAngles.z + 10;
            yesildeger2 = 170 - yesilodun.transform.rotation.eulerAngles.z;

            yesilodundegeryeri.text = yesildeger.ToString("n0");
            yesilodundegeryeri2.text = yesildeger.ToString("n0") + "°";


            kirmizideger = kirmiziodun.transform.rotation.eulerAngles.z;
            kirmizideger2 = 180 - kirmiziodun.transform.rotation.eulerAngles.z;
            kirmiziodundegeryeri.text = kirmizideger2.ToString("n0");
            kirmiziodundegeryeri2.text = kirmizideger2.ToString("n0") + "°";



            if (helpmenu.active)
            {
                helpmenuactive = true;
            }
            else if (!helpmenu.active)
            {
                helpmenuactive = false;
            }


            if (yesilodundegeryeri.text == hedefyesilaci && helpmenuactive == false)
            {
                yesilpanelisik.SetActive(true);
            }
            else if (yesilodundegeryeri.text != hedefyesilaci || helpmenuactive == true)
            {
                yesilpanelisik.SetActive(false);
            }

            if (kirmiziodundegeryeri.text == hedefyesilaci && helpmenuactive == false)
            {
                kirmizipanelisik.SetActive(true);
            }
            else if (kirmiziodundegeryeri.text != hedefyesilaci || helpmenuactive == true)
            {
                kirmizipanelisik.SetActive(false);
            }


            if (yesilodundegeryeri.text == hedefyesilaci && kirmiziodundegeryeri.text == hedefkirmizilaci)
            {
                okaybutton.SetActive(true);
            }
            else
            {
                okaybutton.SetActive(false);
            }
        }
        catch (System.Exception)
        {

            throw;
        }
    }
}
