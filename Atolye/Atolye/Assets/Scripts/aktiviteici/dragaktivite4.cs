using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dragaktivite4 : MonoBehaviour
{
    Vector3 startpos;
    public string hedeftag = "bin";
    bool isinside = false;
    public bool iscorrectmatch = false;

    public GameObject text;
    public GameObject text2;
 
    public GameObject hedefwood;
   
     void Start()
    {
        startpos = this.transform.position;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("We enter the trigger!");
        if (col.gameObject.tag == hedeftag)
        {
            iscorrectmatch = true;

        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log("We exit the trigger!");
        isinside = false;
        iscorrectmatch = false;
    }
    private void OnMouseDrag()
    {
        Vector3 newpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(newpos.x, newpos.y, 0);
    }
    private void OnMouseUp()
    {
        if (!isinside)
        {
            //this.transform.position = startpos;
            basadondur();
        }
        if (iscorrectmatch)
        {
            text.SetActive(true);
            text2.SetActive(true);
            Debug.Log("This match is correct");
            this.transform.position = new Vector3(hedefwood.transform.position.x, hedefwood.transform.position.y, 0);

        }
        else if (!iscorrectmatch)
        {
            text.SetActive(true);
            text2.SetActive(true);
            Debug.Log("This match is not correct");
            this.transform.position = new Vector3(hedefwood.transform.position.x, hedefwood.transform.position.y, 0);

        }
    }
    public void basadondur()
    {
        this.transform.position = startpos;

    }
 
}
