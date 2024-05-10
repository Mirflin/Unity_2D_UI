using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageScript : MonoBehaviour
{
    public GameObject bean;
    public GameObject tedy;
    public GameObject tante;
    public GameObject car;

    public void showBean(bool val)
    {
        bean.SetActive(val);
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
}
