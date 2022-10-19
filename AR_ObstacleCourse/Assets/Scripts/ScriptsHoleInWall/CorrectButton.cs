using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.XR.WSA.Input; //new line

public class CorrectButton : MonoBehaviour
{
    //public UnityEvent rightButton;
    public GameObject Buttons1;

    //private void OnTap(TappedEventArgs args)
    private void OnMouseDown()
    {

        Buttons1.SetActive(false);



    }
}
