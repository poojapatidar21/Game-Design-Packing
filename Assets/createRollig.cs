using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createRollig : MonoBehaviour
{
    public GameObject main;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;
    string levelName;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void StartLevel(string name)
    {
        levelName = name;
    }
    public void OnMouseDown()
    {
        Debug.Log("onclick");
        if (levelName == "main")
            main.GetComponent<containerObjects>().CreateRolling();
        if (levelName == "level2")
            level2.GetComponent<containerObjects2>().CreateRolling();
        if (levelName == "level3")
            level3.GetComponent<containerObjects3>().CreateRolling();
        if (levelName == "level4")
            level4.GetComponent<containerObjects4>().CreateRolling();
        if (levelName == "level5")
            level5.GetComponent<containerObjects5>().CreateRolling();
    }
}
