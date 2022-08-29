using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aciölcer : MonoBehaviour
{
    [SerializeField] GameObject aciolcerpart;
    Vector3 startpos;
    void Start()
    {
        startpos = this.transform.position;
    }

    private void OnMouseDrag()
    {
        Vector3 newpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(newpos.x, newpos.y, 0);
    }
    public void CloseAciolcerPart()
    {
        this.transform.position = startpos;
        aciolcerpart.gameObject.SetActive(false);
    }

}
