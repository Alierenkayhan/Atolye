using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class inputfield : MonoBehaviour
{
    public int caretWidth = 1;
    private void Start()
    {
         
        this.GetComponent<InputField>().caretWidth = caretWidth;
        
    }
}
