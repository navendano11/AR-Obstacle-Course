using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input; //new line
using UnityEngine.Events;


public class CubeBtn : MonoBehaviour
{
    public int id;
    public Animator anim;
    private GestureRecognizer gr;
    public UnityEvent Clicked;
    public UnityEvent played;
    public AudioSource click;


    


    void Start()
    {
        // gr = new GestureRecognizer();
        // gr.SetRecognizableGestures(GestureSettings.Tap);
        // gr.Tapped += OnTap;
        // gr.StartCapturingGestures();
        id = transform.GetSiblingIndex();
        
    }

     private void OnMouseDown()
    {
        click.Play();
        Clicked.Invoke();
        Action();
        Game.Instance.PlayerAction(this);

    }

    public void Action()
    {
        anim.enabled = true;
        anim.SetTrigger("Pop");
    }

    public void soundAction()
    {
        played.Invoke();
    }
}
