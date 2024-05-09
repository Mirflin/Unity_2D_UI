using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowTextScript : MonoBehaviour
{
    /*
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start!");
    }
    int frame = 0;
    // Update is called once per frame
    void Update()
    {
        frame++;
        Debug.Log("Frame tick: "+frame);
    }
    */
    string text;
    public GameObject inputField;
    public GameObject displayField;

    public void getText()
    {
        text = inputField.GetComponent<Text>().text;
        displayField.GetComponent<Text>().text = "Text: "+text.ToLower()+" ...";
    }

}
