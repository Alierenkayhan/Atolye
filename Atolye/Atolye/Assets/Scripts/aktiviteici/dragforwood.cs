using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dragforwood : MonoBehaviour
{
    Vector3 startpos;
    Quaternion rotation;
    public string hedeftag = "vida";
    bool isinside = false;
    public bool iscorrectmatch = false;
    void Start()
    {
        startpos = this.transform.position;
        rotation = this.transform.rotation;
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("We enter the trigger!");
        isinside = true;
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
            Debug.Log("This match is correct.");

        }
        else
        {
            Debug.Log("This match is not correct.");

        }
    }
    public void basadondur()
    {
        this.transform.position = startpos;
        this.transform.rotation = rotation; 

    }
}
