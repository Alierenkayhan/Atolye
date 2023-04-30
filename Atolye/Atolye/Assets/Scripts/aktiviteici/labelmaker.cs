using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class labelmaker : MonoBehaviour
{
    [SerializeField] GameObject[] willbeshown;
    Vector3 startpos;
    

    private void Start()
    {
        foreach (var item in willbeshown)
        {
            item.gameObject.SetActive(false);
        }
        startpos = this.transform.position;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        foreach (var item in willbeshown)
        {
            item.gameObject.SetActive(true);
        }
        collision.gameObject.SetActive(false);
    }
    private void OnMouseDrag()
    {
        Vector3 newpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        this.transform.position = new Vector3(newpos.x, newpos.y, 0f);
     }
    private void OnMouseUp()
    {
        this.transform.position = startpos;
    }
}
