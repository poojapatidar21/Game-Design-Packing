using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerName : MonoBehaviour
{
    public InputField inputName;
    public Text displayName1;
    public Text displayName2; 
    public Text displayName3; 
    public Text displayName4; 
    public Text displayName5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        displayName1.text = inputName.text;
        displayName2.text = inputName.text;
        displayName3.text = inputName.text;
        displayName4.text = inputName.text;
        displayName5.text = inputName.text;
    }
}
