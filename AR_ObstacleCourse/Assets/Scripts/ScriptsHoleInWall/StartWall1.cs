using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class StartWall1 : MonoBehaviour
{

    public Collider Player;
    public UnityEvent OnTriggerEntered;
    public AudioSource buttonpop;


    private void OnTriggerEnter(Collider other)
    {

        if (other == Player)
        {
            buttonpop.Play();
            var renderer = other.gameObject.GetComponent<MeshRenderer>();
            OnTriggerEntered.Invoke();

        }


    }


}
