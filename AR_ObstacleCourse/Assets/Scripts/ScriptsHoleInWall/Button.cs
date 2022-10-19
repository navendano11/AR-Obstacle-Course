using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input; //new line

public class Button : MonoBehaviour
{
    public int id;
    public Animator anim;
    private GestureRecognizer gr;
    public AudioSource buttonpop;


    //private void OnTap(TappedEventArgs args)
    private void OnMouseDown()
    {
        buttonpop.Play();
        Action();

    }

    public void Action()
    {
        anim.enabled = true;
        anim.SetTrigger("Pop");
    }
}
