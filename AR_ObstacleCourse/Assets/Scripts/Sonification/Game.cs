using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input; //new line
public class Game : MonoBehaviour
{

    public static Game Instance;
    public CubeBtn[] btns;
    int wrongInput = 0;
    bool game = true; 
    public bool flag;

    public AudioSource wrongclk;
    public AudioSource rightclk;

    static int userinp, gameinp;

    public static bool simonIsSaying;

    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        // simonMax = 2;
        // simonTime = 0.5f;
        flag = false;

 
    }

    void Update()
    {
        if (flag==true)
        {
            StartCoroutine(SimonSays());
            flag = false;
        }
        
    }

    public void PlayerAction(CubeBtn b)
    {
        userinp = b.id;

        if (game)
        {
            if (userinp != gameinp)
            {
                // wrongclk.Play();
                wrongInput++;
                Debug.Log("Wrong inputs:"+wrongInput);
            }
            else
            {
                rightclk.Play();
                game = false;
                Debug.Log("Right Selection, Total wrong inputs:" + wrongInput);
            }
        }
        // else if (userList.Count == simonList.Count)
        // {
        //     Debug.Log("Next Level");
        //     StartCoroutine(SimonSays());
        // }
    }

    IEnumerator SimonSays()
    {

        Debug.Log("Prepare");
        // set flag here, once flag is true //
        // boolean set True // 
        // yield return new WaitWhile(() => flag); 

        yield return new WaitForSeconds(3);
        // simonIsSaying = true;
        // for (int i = 0; i < simonMax; i++)
    // {
        int rand = Random.Range(0, 3);
        gameinp = rand;
        btns[rand].soundAction();


        // yield return new WaitForSeconds(simonTime);
        // // }
        // simonTime -= 0.015f;
        // // simonMax++;
        // simonIsSaying = false;
    }
}
