using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class booksorular : MonoBehaviour
{
    [SerializeField] GameObject bookgiris;
    [SerializeField] GameObject sorular1;

    public void sorularpart1()
    {
        bookgiris.SetActive(false);
        sorular1.SetActive(true);
    }
}
