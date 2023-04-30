using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activite3sonetkinlikwoodcontrol : MonoBehaviour
{
    [SerializeField] GameObject wood1;
    [SerializeField] GameObject wood2;
    [SerializeField] GameObject devambtn;

    private void Update()
    {

        if (wood1.GetComponent<dragforwood>().iscorrectmatch == true && wood2.GetComponent<dragforwood>().iscorrectmatch == true)
        {
            devambtn.SetActive(true);
        }
        else
        {
            devambtn.SetActive(false);
        }
    }

}
