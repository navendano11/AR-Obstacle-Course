using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Collision3 : MonoBehaviour
{
    public Collider Player;
    public UnityEvent OnTriggerEntered;
    public GameController gamecontroller;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == Player)
        {
            var renderer = other.gameObject.GetComponent<MeshRenderer>();
            gamecontroller.flag3 = true;
            OnTriggerEntered.Invoke();
        }


    }

    // Update is called once per frame
    void Update()
    {

    }
}
