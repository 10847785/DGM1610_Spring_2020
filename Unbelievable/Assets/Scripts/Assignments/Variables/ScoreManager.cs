using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// In order to use UI functions you must access the UI library
using UnityEngine.UI;
// This library is used to manage scenes, including loading scenes.
using UnityEngine.SceneManagement;


public class ScoreManager : MonoBehaviour
{
   
    public static int score;

    public int WinScore;

    public Text WinText;

    private Text ScoreText;

    // On Awake run this block of code
    void Awake()
    {
        Time.timeScale = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text>();

        score = 0;

        WinText.GetComponent<Text>().enabled = false;
       
    }

    // Update is called once per frame
    void Update()
    {
        if (score < 0)
            score = 0;
        ScoreText.text = " " + score;

        // If the player wins the game, display win text!
        if(score >= WinScore)
        {
            print("Win Score Reached = " + score);
            WinText.GetComponent<Text>().enabled = true;
            Time.timeScale = 0;
        }
        // If player hits the Escape key return to start menu
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(0);
        }

        Debug.Log("Game Score: " + score);
    }


    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }

    public static void SubPoints(int pointsToSub)
    {
        score -= pointsToSub;
    }
}
