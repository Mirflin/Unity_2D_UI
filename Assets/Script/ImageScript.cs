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
    public GameObject SliderSize;
    public GameObject SliderRotation;

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
        tedy.transform.localScale = new Vector2(1, 1);
    }
    public void toRight()
    {
        bean.transform.localScale = new Vector2(-1, 1);
        tedy.transform.localScale = new Vector2(-1, 1);
    }
    public void changeImage(int index)
    {
        imageHolder.GetComponent<Image>().sprite = spriteArray[index];
    }
    public void changeSize()
    {
        float size = SliderSize.GetComponent<Slider>().value;
        imageHolder.transform.localScale = new Vector2(1F * size, 1F * size);
    }
    public void changeRotation()
    {
        float rotation = SliderRotation.GetComponent<Slider>().value;
        imageHolder.transform.localRotation = Quaternion.Euler(0,0,rotation*360);
    }
}
