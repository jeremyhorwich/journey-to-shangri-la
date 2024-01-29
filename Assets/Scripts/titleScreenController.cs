using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class titleScreenController : MonoBehaviour
{
    GameObject mainTitle;
    GameObject howToPlay;
    GameObject box1;
    GameObject box2;
    bool whichBox = true;
    bool isLearning = false;

    void Start()
    {
        initializeMenu();
    }

    void Update()
    {
        if (!isLearning) mainScreenController();
        else tutorialController();
    }

    void initializeMenu()
    {
        mainTitle = GameObject.Find("mainTitle");
        howToPlay = GameObject.Find("howToPlay");
        box1 = GameObject.Find("box1");
        box2 = GameObject.Find("box2");
        mainTitle.SetActive(true);
        howToPlay.SetActive(false);
        box2.SetActive(false);
    }

    void changeIndicator()
    {
        whichBox = !whichBox;
        box1.SetActive(whichBox);
        box2.SetActive(!whichBox);
    }
    
    void mainScreenController()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.S))
        {
            changeIndicator();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (whichBox == false)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                {
                    mainTitle.SetActive(false);
                    howToPlay.SetActive(true);
                    isLearning = true;
                }
            }
        }
    }

    void tutorialController()
    {
        if (Input.anyKeyDown)
        {
            mainTitle.SetActive(true);
            howToPlay.SetActive(false);
            isLearning = false;
        }
    }
}
