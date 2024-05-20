using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotate : MonoBehaviour
{
    private bool isFixed;
    private void Start()
    {
        isFixed = false;
    }
    public void fixPosition()
    {
        isFixed = true;
    }
    public void unfixPosition()
    {
        Debug.Log("done");
        isFixed = false;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && isFixed==false)
        {
            Debug.Log("rotate");
            transform.eulerAngles = new Vector3(0, 0,transform.eulerAngles.z-1);
        }
        if (Input.GetKeyDown(KeyCode.E) &&isFixed==false)
        {
            transform.eulerAngles = new Vector3(0, 0, transform.eulerAngles.z + 1);
        }
    }
}

