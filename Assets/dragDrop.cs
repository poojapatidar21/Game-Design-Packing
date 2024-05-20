using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragDrop : MonoBehaviour
{
	private bool isDragging;
	private bool isFixed;

    private void Start()
    {
        isFixed = false;
    }
    public void fixPostion()
    {
        isFixed = true;

    }
    public void OnMouseDown()
	{
		Debug.Log("OnMouseDown");
		isDragging = true;
    }
	public void OnMouseUp()
	{
		Debug.Log("onMouseUp");
		isDragging = false;
	}
    private void Update()
    {
        if(isDragging && !isFixed)
        {
			Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
			transform.Translate(mousePosition);
        }			
    }
}
