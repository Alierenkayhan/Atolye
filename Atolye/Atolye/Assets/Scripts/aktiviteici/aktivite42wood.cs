using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class aktivite42wood : MonoBehaviour
{
    Vector3 startpos;
    public string hedeftag = "bin";
    bool isinside = false;
    public bool iscorrectmatch = false;



    public GameObject hedefwood;
    public GameObject text;

    public Color mycolor;

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
        try
        {
            Vector3 newpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            this.transform.position = new Vector3(newpos.x, newpos.y, 0);

        }
        catch (System.Exception)
        {

            throw;
        }

    }
    private void OnMouseUp()
    {
        try
        {
            hedefwood.GetComponent<Image>().color = mycolor;
            Destroy(this.gameObject);
            text.SetActive(true);
        }
        catch (System.Exception)
        {
            Debug.Log("Hold a second and then try it again please.");
            throw;
        }

    }
    public void basadondur()
    {
        this.transform.position = startpos;

    }

}
 
