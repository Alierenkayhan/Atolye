using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wood : MonoBehaviour
{

    Vector3 startpos;
    float rotationSpeed = 0.2f;


    private Camera myCam;
    private Vector3 screenPos;
    private float angleOffset;
    private Collider2D col;



    public string hedeftag = "hedef";
    bool isinside = false;
    public bool iscorrectmatch = false;

     

    void Start()
    {
        startpos = this.transform.position;
        myCam = Camera.main;
        col = GetComponent<Collider2D>();

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        //Debug.Log("We enter the trigger!");
        isinside = true;
        if (col.gameObject.tag == hedeftag)
        {
            iscorrectmatch = true;
            //Debug.Log("iscorrectmatch =" + iscorrectmatch);
        }
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        //Debug.Log("We enter the trigger!");
        isinside = true;
        if (col.gameObject.tag == hedeftag)
        {
            iscorrectmatch = true;
            //Debug.Log("iscorrectmatch =" + iscorrectmatch);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //Debug.Log("We exit the trigger!");
        isinside = false;
        iscorrectmatch = false;
    }

    private void Update()
    {
        Vector3 mousePos = myCam.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            if (col == Physics2D.OverlapPoint(mousePos))
            {
                screenPos = myCam.WorldToScreenPoint(transform.position);
                Vector3 vec3 = Input.mousePosition - screenPos;
                angleOffset = (Mathf.Atan2(transform.right.y, transform.right.x) - Mathf.Atan2(vec3.y, vec3.x)) * Mathf.Rad2Deg;
               

}
        }
        if (Input.GetMouseButton(0))
        {
            if (col == Physics2D.OverlapPoint(mousePos))
            {
                Vector3 vec3 = Input.mousePosition - screenPos;
                float angle = Mathf.Atan2(vec3.y, vec3.x) * Mathf.Rad2Deg;
                transform.eulerAngles = new Vector3(0, 0, angle + angleOffset);
                 
            }         
        }
    }
}
