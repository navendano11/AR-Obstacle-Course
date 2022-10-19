using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class trigger : MonoBehaviour
{
    public Collider Player;
    public UnityEvent OnTriggerEntered;
    public Game gamecontroller;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == Player)
        {
            var renderer = other.gameObject.GetComponent<MeshRenderer>();
            gamecontroller.flag = true; 
            OnTriggerEntered.Invoke();
        }
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}