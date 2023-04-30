using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class activite1panel : MonoBehaviour
{
    [SerializeField] GameObject ahsapoymabicagi;
    [SerializeField] TextMeshProUGUI ahsapoymabicagidegeryeri;
    [SerializeField] TextMeshProUGUI ahsapoymabicagidegeryeri2;
    [SerializeField] TextMeshProUGUI ahsapoymabicagidegeryeri2denartan;


    float deger;
    float deger2;

    [SerializeField] GameObject feedback;
    [SerializeField] GameObject cekic;

    private IEnumerator coroutine;

    public string hedefaci1;
    public string hedefaci2;

    [SerializeField] GameObject activite1;
    [SerializeField] GameObject activite12;
    [SerializeField] GameObject activiteson;


    [SerializeField] GameObject helpmenu;
    public bool helpmenuactive = false;

    //-------------------------activite1.2---------------------------------------
    [SerializeField] GameObject ahsapoymabicagi2;
    [SerializeField] TextMeshProUGUI ahsapoymabicagidegeryeri22;
    [SerializeField] TextMeshProUGUI ahsapoymabicagidegeryeri222;
    [SerializeField] TextMeshProUGUI ahsapoymabicagidegeryeri2denartan2;

    float deger22;
    float deger222;

    [SerializeField] GameObject feedback2;
    [SerializeField] GameObject cekic2;

    [SerializeField] GameObject panelisik;
    [SerializeField] GameObject panelisik2;

    [Header("Yeni")]
    public GameObject wood;
    [SerializeField] GameObject wood2;
    [SerializeField] GameObject activiteto11;
    [SerializeField] GameObject activiteto1;
    [SerializeField] GameObject btn;

    [Header("Activite1.1 açı gösterimi")]
    public GameObject gösterim;

    void FixedUpdate()
    {

        deger = ahsapoymabicagi.transform.rotation.eulerAngles.z;
        deger2 = 180 - ahsapoymabicagi.transform.rotation.eulerAngles.z;

        ahsapoymabicagidegeryeri.text = deger.ToString("n0");
        ahsapoymabicagidegeryeri2.text = deger.ToString("n0");
        ahsapoymabicagidegeryeri2denartan.text = deger2.ToString("n0");


        //-----------------------------------------------------------active1.2-----------------------------------
        deger22 = ahsapoymabicagi2.transform.rotation.eulerAngles.z;
        deger222= 180 - ahsapoymabicagi2.transform.rotation.eulerAngles.z;

        ahsapoymabicagidegeryeri22.text = deger22.ToString("n0");
        ahsapoymabicagidegeryeri222.text = deger22.ToString("n0");
        ahsapoymabicagidegeryeri2denartan2.text = deger222.ToString("n0");
        if (helpmenu.active)
        {
            helpmenuactive = true;
        }
        else if (!helpmenu.active)
        {
            helpmenuactive = false;
        }


        if (ahsapoymabicagidegeryeri22.text == hedefaci2 && helpmenuactive == false)
        {
            panelisik2.SetActive(true);
        }
        else if(ahsapoymabicagidegeryeri22.text != hedefaci2 || helpmenuactive == true)
        {
            panelisik2.SetActive(false);
        }
        if (ahsapoymabicagidegeryeri.text == hedefaci1 && helpmenuactive == false)
        {
            panelisik.SetActive(true);
        }
        else if (ahsapoymabicagidegeryeri.text != hedefaci1 || helpmenuactive == true)
        {
            panelisik.SetActive(false);
        }
    }
    private void Start()
    {
        btn.SetActive(false);
        gösterim.gameObject.GetComponent<Animator>().enabled = false;
    }
    private void Update()
    {
        if (wood.gameObject.GetComponent<dragforwood>().iscorrectmatch == true && wood2.gameObject.GetComponent<dragforwood>().iscorrectmatch == true)
        {
            btn.SetActive(true);
         }
        else
        {
            btn.SetActive(false);

        }
    }
    public void acıgösterimi()
    {
        gösterim.gameObject.GetComponent<Animator>().enabled = true;
    }
    public void TekrarDene()
    {
        feedback.SetActive(false);
        cekic.SetActive(true);
        cekic.GetComponent<Animator>().enabled = false;
        cekic.GetComponent<AudioSource>().enabled = false;
    }
    public void TekrarDene2()
    {
        feedback2.SetActive(false);
        cekic2.SetActive(true);
        cekic2.GetComponent<Animator>().enabled = false;
        cekic2.GetComponent<AudioSource>().enabled = false;
    }
    public void vurma()
    {
         
        try
        {
            if (ahsapoymabicagidegeryeri.text != hedefaci1)
            {
                cekic.GetComponent<Animator>().enabled = true;
                cekic.GetComponent<AudioSource>().enabled = true;
                coroutine = Wait(1.5f);
                StartCoroutine(coroutine);
            }
            else
            {
                cekic.GetComponent<Animator>().enabled = true;
                cekic.GetComponent<AudioSource>().enabled = true;
                coroutine = Pass12(1.5f);
                StartCoroutine(coroutine);

            }
        }
        catch (System.Exception)
        {

            throw;
        }  
    }

    public void activite1to2()
    {
        try
        {
            if (wood.gameObject.GetComponent<dragforwood>().iscorrectmatch == true && wood2.gameObject.GetComponent<dragforwood>().iscorrectmatch == true)
            {
                activiteto1.SetActive(false);
                activiteto11.SetActive(true);
            }
            else
            {
                activite1.SetActive(true);
            }
        }
        catch (System.Exception)
        {

            throw;
        }
    }
    private IEnumerator Wait(float waitTime)
    {
       yield return new WaitForSeconds(waitTime);
       feedback.SetActive(true);
       cekic.SetActive(false);
    }
    private IEnumerator Wait2(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        feedback2.SetActive(true);
        cekic2.SetActive(false);
    }
    private IEnumerator Pass12(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        activite1.SetActive(false);
        activite12.SetActive(true);
    }

    public void vurma2()
    {
        try
        {
            if (ahsapoymabicagidegeryeri22.text != hedefaci2)
            {
                cekic2.GetComponent<Animator>().enabled = true;
                cekic2.GetComponent<AudioSource>().enabled = true;
                coroutine = Wait2(1.5f);
                StartCoroutine(coroutine);
            }
            else
            {
                cekic2.GetComponent<Animator>().enabled = true;
                cekic2.GetComponent<AudioSource>().enabled = true;
                coroutine = Pass2Son(1.5f);
                StartCoroutine(coroutine);

            }
        }
        catch (System.Exception)
        {

            throw;
        }
    }

    private IEnumerator Pass2Son(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        activite12.SetActive(false);
        activiteson.SetActive(true);
       
    }
}
