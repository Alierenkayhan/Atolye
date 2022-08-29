using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mousecurser : MonoBehaviour
{
    Animator animator;
    int clicks;
    int clicksend;

    private void Start()
    {
         
        try
        {
            //Cursor.visible = false;
            animator = this.GetComponent<Animator>();
            clicks = Animator.StringToHash("clicks");
            clicksend = Animator.StringToHash("clicksend");
        }
        catch
        {
            Debug.Log("Something goes wrong!");
        }
    }
    void Update()
    {
        try
        {
            bool iswalking = animator.GetBool(clicks);

            Vector2 cursorPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            transform.position = cursorPos;

            if (Input.GetMouseButtonDown(0))
            {
                animator.SetTrigger(clicks);
            }
            animator.SetTrigger(clicksend);
        }
        catch
        {
            Debug.Log("Something goes wrong!");
        }
    }


    private void Awake()
    {
        GameObject[] cursorObject = GameObject.FindGameObjectsWithTag("Cursor");
        DontDestroyOnLoad(this.gameObject);
       
    }
     
}
