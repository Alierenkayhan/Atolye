using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drag : MonoBehaviour
{
    Vector3 startpos;
    public string hedeftag = "vida";
    bool isinside = false;
    public bool iscorrectmatch = false;
    private IEnumerator coroutine;
    [SerializeField] GameObject matkap;

    [SerializeField] GameObject Activite11;
    [SerializeField] GameObject Activite1DenemeYeri11;

    public GameObject[] pages;

    [SerializeField] GameObject Activite12;
    [SerializeField] GameObject Activite1DenemeYeri12;

    [SerializeField] GameObject Activite1Son;
    void Start()
    {
        startpos = this.transform.position;
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
        this.transform.position = new Vector3(newpos.x,newpos.y,0);
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

    }

    public void Continue()
    {
        try
        {
            if (iscorrectmatch)
            {
                Activite11.SetActive(false);
                Activite1DenemeYeri11.SetActive(true);
            }
        }
        catch
        {
            Debug.Log("Something goes wrong.");
        }
    }



    public void Continue2()
    {
        try
        {
            if (iscorrectmatch)
            {
                Activite12.SetActive(false);
                Activite1Son.SetActive(true);
            }
        }
        catch
        {
            Debug.Log("Something goes wrong.");
        }
    }


    public void Continue3()
    {
        try
        {
            if (iscorrectmatch)
            {
                Activite12.SetActive(false);
                Activite1DenemeYeri12.SetActive(true);
            }
        }
        catch
        {
            Debug.Log("Something goes wrong.");
        }
    }

    public void aktivite2continue()
    {
        try
        {
            if (iscorrectmatch)
            {
                matkap.GetComponent<AudioSource>().enabled = true;
                coroutine = Wait2(2f);
                StartCoroutine(coroutine);
            }
        }
        catch
        {
            Debug.Log("Something goes wrong.");
        }
    }

    public void aktivite3continue()
    {
        try
        {
            if (iscorrectmatch)
            {
                matkap.GetComponent<AudioSource>().enabled = true;
                coroutine = Wait2(2f);
                StartCoroutine(coroutine);
            }
        }
        catch
        {
            Debug.Log("Something goes wrong.");
        }
    }


    public void aktivite4continue()
    {
        try
        {
            if (iscorrectmatch)
            {
                matkap.GetComponent<AudioSource>().enabled = true;
                coroutine = Wait(2f);
                StartCoroutine(coroutine);
            }
        }
        catch
        {
            Debug.Log("Something goes wrong.");
        }
    }

    private IEnumerator Wait2(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Activite12.SetActive(false);
        Activite1Son.SetActive(true);
    }

    private IEnumerator Wait(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        Activite11.SetActive(false);
        Activite1DenemeYeri11.SetActive(true);
    }
}
