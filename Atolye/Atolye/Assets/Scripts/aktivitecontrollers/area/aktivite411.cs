using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aktivite411 : MonoBehaviour
{
    public GameObject wood1;
    public GameObject wood2;


    public GameObject Activite11;
    public GameObject Activite12;

    public GameObject btn;

    public void Update()
    {
        
        try // in case of problem in the code, the game continues 
        {
            if (wood1.GetComponent<metre>().iscorrectmatch == true && wood2.GetComponent<metre>().iscorrectmatch == true)
            {
                //Debug.Log("kontrol2 =" + wood2.GetComponent<wood>().iscorrectmatch);
                btn.SetActive(true);

            }
        }
        catch
        {
            Debug.Log("Something goes wrong!");
        }

    }
    public void nextaktivite12()
    {
        Activite11.SetActive(false);
        Activite12.SetActive(true);
    }
}
