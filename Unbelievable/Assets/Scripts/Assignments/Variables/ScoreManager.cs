using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
   
    public static int score;
    public int WinScore;
    public TextAlignment WinText;
    TextAlignment ScoreText;

    void Awake()
    {
        Time.timeScale = 1;
    }

    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<TextAlignment>();
        score = 0;
       
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Game Score: " + score);
    }


    public static void AddPoints(int pointsToAdd)
    {
        score += pointsToAdd;
    }
}
