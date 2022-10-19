using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MovingWall1 : MonoBehaviour
{

    public Collider Player;
    public Collider Player1;
    public UnityEvent OnTriggerEntered;
    public AudioSource buttonpop;


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == Player1)
        {

            buttonpop.Play();
            var renderer = other.gameObject.GetComponent<MeshRenderer>();
            OnTriggerEntered.Invoke();


        }

        if (other == Player)
        {

            var renderer = other.gameObject.GetComponent<MeshRenderer>();
            OnTriggerEntered.Invoke();


        }


    }


}
