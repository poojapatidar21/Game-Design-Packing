using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class containerObjects3 : MonoBehaviour
{
    public GameObject fixobjectbutton;
    public GameObject overlappingText;
    public GameObject bowl;
    public GameObject pan;
    public GameObject kettle;
    public GameObject powder;
    public GameObject mixer;
    public GameObject teapot;
    public GameObject rolling;
    public GameObject ponpan;
    public GameObject isOutsideText;
    public Text objectCountText;
    public Text totalObjectsText;
    public Text playerName;

    private GameObject selectedObject;
    public GameObject container;
    private List<GameObject> Objects = new List<GameObject>();
    private int count = 0;
    private bool isSelected = false;
    private bool isOverlapping = false;
    private bool isGameOver = false;
    private bool isOutside = false;
    private int objectCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        fixobjectbutton.SetActive(false);
        isOutsideText.SetActive(false);
    }
    public void StartUp()
    {
        Debug.Log("error while clicking home");
        objectCount = 0;
        objectCountText.text = "Objects : " + objectCount.ToString();
        fixobjectbutton.SetActive(false);
        isOutsideText.SetActive(false);
        for (int i = 0; i < Objects.Count; i++)
            GameObject.Destroy(Objects[i]);
        isSelected = false;
        for (var i = 0; i < Objects.Count; i++)
        {
            Objects.RemoveAt(i);
        }
        isSelected = false;
        isOverlapping = false;
        isGameOver = false;
        isOutside = false;
}
    public void onFixObject()
    {
        selectedObject.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
        selectedObject.GetComponent<dragDrop>().fixPostion();
        selectedObject.GetComponent<rotate>().fixPosition();
        isSelected = false;
        isOverlapping = false;
        selectedObject.GetComponent<SpriteRenderer>().color = new Color(0, 0, 0, 1);
        objectCount++;
        objectCountText.text = "Objects : " + objectCount.ToString();

    }
    public void removeobject()
    {
        
        for (int i = 0; i<Objects.Count; i++)
            GameObject.Destroy(Objects[i]);
        isSelected = false;
        for (var i = 0; i<Objects.Count; i++)
        {
            Objects.RemoveAt(i);
        }
    }
    public void GameOver()
    {
        isGameOver = true;
        totalObjectsText.text = playerName.text + " puts " + objectCount +" objects";
        objectCountText.text = "";

    }


    // Update is called once per frame
    void Update()
    {
        if (isSelected)
        {
            bool isIN = true;
            PolygonCollider2D polygonCollider = selectedObject.GetComponent<PolygonCollider2D>();
            foreach (Vector2 point in polygonCollider.points)
            {
                Vector3 point_in_object = selectedObject.transform.TransformPoint(point);
                bool isIn = container.GetComponent<BoxCollider2D>().bounds.Contains(point_in_object);
                if (!isIn)
                    isIN = false;
            }
            if (isIN)
                isOutside = false;
            else
                isOutside = true;
            if (isOutside)
            {
                isOutsideText.SetActive(true);
                fixobjectbutton.SetActive(false);
            }
            else
            {
                isOutsideText.SetActive(false);
                fixobjectbutton.SetActive(true);
            }
        }

        if (isDragging && isSelected)
        {
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
            transform.Translate(mousePosition);
        }
        if (!isSelected )
        {
            fixobjectbutton.SetActive(false);
            overlappingText.SetActive(false);
        }
    }

    
    public void CreateBowl()
    {
        if (isSelected == false && isGameOver == false)
        {
            Debug.Log("call create bowl script");
            GameObject bowlDuplicate = Instantiate(bowl, new Vector3(120, 390, 0), bowl.transform.rotation);
            selectedObject = bowlDuplicate;
            selectedObject.GetComponent<rotate>().unfixPosition();

            Objects.Add(selectedObject);
            isSelected = true;
        }
    }
    public void CreatePan()
    {
        if (isSelected == false && isGameOver == false)
        {
            Debug.Log("call create bowl script");
            GameObject bowlDuplicate = Instantiate(pan, new Vector3(120, 390, 0), pan.transform.rotation);
            selectedObject = bowlDuplicate;
            selectedObject.GetComponent<rotate>().unfixPosition();
            Objects.Add(selectedObject);
            isSelected = true;
        }
    }
    public void CreateKettle()
    {
        if (isSelected == false && isGameOver == false)
        {
            Debug.Log("call create bowl script");
            GameObject bowlDuplicate = Instantiate(kettle, new Vector3(120, 390, 0), kettle.transform.rotation);
            selectedObject = bowlDuplicate;
            selectedObject.GetComponent<rotate>().unfixPosition();
            Objects.Add(selectedObject);
            isSelected = true;
        }
    }
    public void CreatePonpan()
    {
        if (isSelected == false && isGameOver == false)
        {
            Debug.Log("call create bowl script");
            GameObject bowlDuplicate = Instantiate(ponpan, new Vector3(120, 390, 0), ponpan.transform.rotation);
            selectedObject = bowlDuplicate;
            selectedObject.GetComponent<rotate>().unfixPosition();
            bowlDuplicate.GetComponent<SpriteRenderer>().color = new Color(1, 0, 0, 1);
            Objects.Add(selectedObject);
            isSelected = true;
        }
    }
    public void CreateRolling()
    {
        if (isSelected == false && isGameOver == false)
        {
            Debug.Log("call create bowl script");
            GameObject bowlDuplicate = Instantiate(rolling, new Vector3(120, 390, 0), rolling.transform.rotation);
            selectedObject = bowlDuplicate;
            selectedObject.GetComponent<rotate>().unfixPosition();
            Objects.Add(selectedObject);
            isSelected = true;
        }
    }
    public void CreateTeapot()
    {
        if (isSelected == false && isGameOver == false)
        {
            Debug.Log("call create bowl script");
            GameObject bowlDuplicate = Instantiate(teapot, new Vector3(120, 390, 0), teapot.transform.rotation);
            selectedObject = bowlDuplicate;
            selectedObject.GetComponent<rotate>().unfixPosition();
            Objects.Add(selectedObject);
            isSelected = true;
        }
    }
    public void CreatePowder()
    {
        if (isSelected == false && isGameOver == false)
        {
            Debug.Log("call create bowl script");
            GameObject bowlDuplicate = Instantiate(powder, new Vector3(120, 390, 0), powder.transform.rotation);
            selectedObject = bowlDuplicate;
            selectedObject.GetComponent<rotate>().unfixPosition();
            Objects.Add(selectedObject);
            isSelected = true;
        }
    }
    public void CreateMixer()
    {
        if (isSelected == false && isGameOver == false)
        {
            Debug.Log("call create bowl script");
            GameObject bowlDuplicate = Instantiate(mixer, new Vector3(120, 390, 0), mixer.transform.rotation);
            selectedObject = bowlDuplicate;
            bowlDuplicate.GetComponent<rotate>().unfixPosition();
            Objects.Add(selectedObject);
            isSelected = true;
        }
    }
    public void closeGame()
    {
        for(int i=0;i<count;i++)
        {
            Objects[i].SetActive(false);
        }
    }
    private bool isDragging;

    public void OnMouseDown()
    {
        if(isSelected)
        {
            Debug.Log("OnMouseDown");
            isDragging = true;
        }
    }
    public void OnMouseUp()
    {
        if (isSelected)
        {
            Debug.Log("onMouseUp");
            isDragging = false;
        }
    }
}
