using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class woodaktivite412 : MonoBehaviour
{
    [SerializeField] GameObject wood;
    [SerializeField] TMPro.TMP_Dropdown dropdown1;
    [SerializeField] TMPro.TMP_Dropdown dropdown2;

    [SerializeField] TMPro.TMP_Dropdown dropdown3;
    [SerializeField] TMPro.TMP_Dropdown dropdown4;

    [SerializeField] TextMeshProUGUI alan;

    [SerializeField] GameObject btn;

    [SerializeField] GameObject activite12;
    [SerializeField] GameObject activite13;

    private Vector3 scaleChange;
    private float h;
    private float h2;
    private float w;
    private float w2;
    private float alandeger;
    private string birim;

    private void Start()
    {
        btn.SetActive(false);
    }
    private void FixedUpdate()
    {
        try
        {
           

            h = dropdown1.value;
            h2 = dropdown1.value;
            w = dropdown2.value;
            w2 = dropdown2.value;

            switch (dropdown3.value)
            {
                case 0:
                    h = h * 0.011f; ;
                    break;
                case 1:
                    h = h * 0.025f;
                    break;
                case 2:
                    h = h * 0.04f;
                    break;
                case 3:
                    h = h * 0.06f;
                    break;
                case 4:
                    h = h * 0.08f;
                    break;
                case 5:
                    h = h * 0.1f;
                    break;
                case 6:
                    h = h * 0.24f;
                    break;
                default:
                    h = h * 0.06f;
                    break;
            }
            switch (dropdown4.value)
            {
                case 0:
                    w = w * 0.011f; ;
                    break;
                case 1:
                    w = w * 0.025f;
                    break;
                case 2:
                    w = w * 0.04f;
                    break;
                case 3:
                    w = w * 0.06f;
                    break;
                case 4:
                    w = w * 0.08f;
                    break;
                case 5:
                    w = w * 0.1f;
                    break;
                case 6:
                    w = w * 0.24f;
                    break;
                default:
                    w = w * 0.06f;
                    break;
            }



            scaleChange = new Vector3(h, w, 1f);
            wood.transform.localScale = scaleChange;

            alandeger = (h2 * w2) / 2;

            if (dropdown3.value == dropdown4.value)
            {
                birim = dropdown3.options[dropdown3.value].text + "²";
            }
            else
            {
                birim = dropdown3.options[dropdown3.value].text + dropdown4.options[dropdown4.value].text;
            }

            alan.text = "" + alandeger + " " + birim;

            if (dropdown3.value == 3 && dropdown4.value == 3 && dropdown1.value == 12 && dropdown2.value == 14)
            {
                btn.SetActive(true);
            }
        }
        catch (System.Exception)
        {

            throw;
        }     
    }

    public void NextActivitePart13()
    {
        activite12.SetActive(false);
        activite13.SetActive(true);
    } 
}
