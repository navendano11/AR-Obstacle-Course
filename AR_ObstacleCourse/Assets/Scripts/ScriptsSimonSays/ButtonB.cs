using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input; //new line
public class ButtonB : MonoBehaviour
{
    public int id;
    public Animator anim;
    private GestureRecognizer gr;
    public AudioSource buttonpop;

    void Start()
    {
/*        gr = new GestureRecognizer();
        gr.SetRecognizableGestures(GestureSettings.Tap);
        gr.Tapped += OnTap;
        gr.StartCapturingGestures();*/


        id = transform.GetSiblingIndex();
        
    }

    //private void OnTap(TappedEventArgs args)
    private void OnMouseDown()
    {
        if (!GameController.simonIsSaying)
        {
            buttonpop.Play();
            Action();
            GameController.Instance.PlayerAction(this);
        }

    }

    public void Action()
    {
        anim.enabled = true;
        anim.SetTrigger("Pop");
    }
}
