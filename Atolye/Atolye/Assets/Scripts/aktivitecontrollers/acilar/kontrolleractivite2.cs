using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kontrolleractivite2 : MonoBehaviour
{

    public GameObject wood1;
    public GameObject wood2;


    public GameObject Activite11;
    public GameObject Activite12;

  

    public void Update()
    {
        try // in case of problem in the code, the game continues 
        {
            if (wood1.GetComponent<wood>().iscorrectmatch == true)
            {
                //Debug.Log("kontrol1 =" + wood1.GetComponent<wood>().iscorrectmatch);
                if (wood2.GetComponent<wood>().iscorrectmatch == true)
                {
                    //Debug.Log("kontrol2 =" + wood2.GetComponent<wood>().iscorrectmatch);
                    //okaybutton.SetActive(true);
                    
                }
            }
        }
        catch
        {
            Debug.Log("Something goes wrong!");
        }

    }
}
