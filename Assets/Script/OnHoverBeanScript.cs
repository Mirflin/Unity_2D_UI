using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnHoverBean : MonoBehaviour
{
    public AudioSource aSource;
    public AudioClip aClip;

    public void onImage()
    {
        aSource.PlayOneShot(aClip);
    }
    public void notOnImage()
    {
        aSource.Stop();
    }
}
