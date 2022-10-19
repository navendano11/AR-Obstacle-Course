using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.WSA.Input; //new line
public class GameController : MonoBehaviour
{

    public static GameController Instance;
    public ButtonB[] btns1;
    public ButtonB[] btns2;
    public ButtonB[] btns3;
    public ButtonB[] btns4;

    public GameObject SimonSays1;
    public GameObject SimonSays2;
    public GameObject SimonSays3;
    public GameObject SimonSays4;

    public bool set1;
    public bool set2;
    public bool set3;
    public bool set4;

    private int wincount;
    private int losecount;
    private float score;


    static int simonMax;
    static float simonTime;

    static List<int> userList, simonList;

    public static bool simonIsSaying;
    public bool flag1;
    public bool flag2;
    public bool flag3;
    public bool flag4;

    public AudioSource win;
    public AudioSource whoops;
    public AudioSource complete;

    // Start is called before the first frame update
    void Start()
    {

       // SimonSays1.SetActive(false);
       // SimonSays2.SetActive(false);

        wincount = 0;
        losecount = 0;
        Instance = this;


        // simonMax = 3;
        // simonTime = 1f;

        // StartCoroutine(SimonSays());
    }

    private void Update()
    {
        //score = wincount + losecount;
        if (wincount + losecount == 3)
        {
            complete.Play();
            Debug.Log("You got " + wincount + " out of 3!");
            if (set1 == true)
            {
                SimonSays1.SetActive(false);
                
            }
            if (set2 == true)
            {
                SimonSays2.SetActive(false);
                
            }
            if (set3 == true)
            {
                SimonSays3.SetActive(false);
                
            }
            if (set4 == true)
            {
                SimonSays4.SetActive(false);
                
            }

            wincount = 0;
            losecount = 0;
            set1 = false;
            set2 = false;
            set3 = false;
            set4 = false;
        }

        if (flag1==true)
        {
            simonMax = 3;
            simonTime = 1f;
            set1 = true;
            StartCoroutine(SimonSays());
            flag1 = false;
            
        }
        if(flag2==true)
        {
            simonMax = 4;
            simonTime = 0.7f;
            set2 = true;
            StartCoroutine(SimonSays());
            flag2 = false;
        }
        if (flag3 == true)
        {
            simonMax = 5;
            simonTime = 0.7f;
            set3 = true;
            StartCoroutine(SimonSays());
            flag3 = false;
        }
        if (flag4 == true)
        {
            simonMax = 6;
            simonTime = 1f;
            set4 = true;
            StartCoroutine(SimonSays());
            flag4 = false;
        }
    }

    public void PlayerAction(ButtonB b)
    {
        userList.Add(b.id);

        if (userList[userList.Count - 1] != simonList[userList.Count - 1])
        {
            // Start();
            losecount += 1;
            StartCoroutine(Wait());

        }
        else if (userList.Count == simonList.Count)
        {
            StartCoroutine(Win());
            wincount += 1;
           // StartCoroutine(SimonSays());
        }
    }



    IEnumerator SimonSays()
    {

        Debug.Log("Prepare");
        // set flag here, once flag is true //
        // boolean set True // 
        // yield return new WaitWhile(() => flag); 

        Debug.Log("Begin in 3..");
        yield return new WaitForSeconds(1);
        Debug.Log("Begin in 2..");
        yield return new WaitForSeconds(1);
        Debug.Log("Begin in 1..");
        yield return new WaitForSeconds(1);
        Debug.Log("Displaying Pattern...");
        yield return new WaitForSeconds(1);
        simonIsSaying = true;
        userList = new List<int>();
        simonList = new List<int>();

        for (int i = 0; i < simonMax; i++)
        {
            int rand = Random.Range(0, 4);
/*            simonList.Add(rand);
            btns1[rand].Action();*/
            if (set1 == true)
            {
                simonList.Add(rand);
                btns1[rand].Action();

            }
            if (set2 == true)
            {
                simonList.Add(rand);
                btns2[rand].Action();

            }
            if (set3 == true)
            {
                simonList.Add(rand);
                btns3[rand].Action();

            }
            if (set4 == true)
            {
                simonList.Add(rand);
                btns4[rand].Action();

            }
            yield return new WaitForSeconds(simonTime);
        }
        Debug.Log("Repeat The Pattern You Saw!");
/*        set1 = false;
        set2 = false;
        set3 = false;
        set4 = false;*/
        // simonTime -= 0.015f;
        // simonMax++;
        simonIsSaying = false;
    }

    IEnumerator Wait()
    {
        whoops.Play();
        Debug.Log("Whoops! Wrong Pattern!");
        yield return new WaitForSeconds(1);
        Debug.Log("You'll Get It Next Time! Preparing next pattern...");
        yield return new WaitForSeconds(1);
        StartCoroutine(SimonSays());
    }

    IEnumerator Win()
    {
        win.Play();
        Debug.Log("Nice! You Did It!");
        yield return new WaitForSeconds(1);
        Debug.Log("Next Pattern!");
        yield return new WaitForSeconds(1);
        StartCoroutine(SimonSays());
    }
}
