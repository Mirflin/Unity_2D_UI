using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject bean;
    public GameObject tedy;
    public GameObject tante;
    public GameObject car;
    public GameObject leftToggle;
    public GameObject rightToggle;
    public Sprite[] spriteArray;
    public GameObject imageHolder;

    public void showBean(bool val)
    {
        bean.SetActive(val);
        leftToggle.GetComponent<Toggle>().interactable = val;
        rightToggle.GetComponent<Toggle>().interactable = val;

    }
    public void showTedy(bool val)
    {
        tedy.SetActive(val);
    }
    public void showTante(bool val)
    {
        tante.SetActive(val);
    }
    public void showCar(bool val)
    {
        car.SetActive(val);
    }
    public void toLeft()
    {
        bean.transform.localScale = new Vector2(1, 1);
    }
    public void toRight()
    {
        bean.transform.localScale = new Vector2(-1, 1);
    }
    public void changeImage(int index)
    {
        imageHolder.GetComponent<Image>().sprite = spriteArray[index];
    }
}
