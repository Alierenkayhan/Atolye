using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class helpmenu : MonoBehaviour
{
    [SerializeField] GameObject genelpart;
    [SerializeField] GameObject aktivitepart;
    [SerializeField] GameObject derspart;
    public void GenelPart()
    {
        genelpart.SetActive(true);
        aktivitepart.SetActive(false);
        derspart.SetActive(false);
    }
    public void AktivitePart()
    {
        genelpart.SetActive(false);
        aktivitepart.SetActive(true);
        derspart.SetActive(false);
    }
    public void DersPart()
    {
        genelpart.SetActive(false);
        aktivitepart.SetActive(false);
        derspart.SetActive(true);
    }
}
