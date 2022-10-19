using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeginGame : MonoBehaviour
{

    public GameObject Wall1;
    public GameObject Buttons1;
    public GameObject Wall2;
    public GameObject Buttons2;
    public GameObject Trigger2;
    public GameObject Wall3;
    public GameObject Buttons3;
    public GameObject Trigger3;
    public GameObject Wall4;
    public GameObject Buttons4;
    public GameObject Trigger4;

    void Start()
    {
        Wall1.SetActive(false);
        Buttons1.SetActive(false);
        Wall2.SetActive(false);
        Buttons2.SetActive(false);
        Wall3.SetActive(false);
        Buttons3.SetActive(false);
        Wall4.SetActive(false);
        Buttons4.SetActive(false);
        Trigger2.SetActive(false);
        Trigger3.SetActive(false);
        Trigger4.SetActive(false);
    }

    
}
