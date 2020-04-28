using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Counter : MonoBehaviour
{
    // During the game
  //  public int countDownValue = 360;

  //  public Text timer;

    // Starts the game 
    public float countDown;

    public Text countText; 

    // Start is called before the first frame update
    void Start()
    {
        // During the game
        
        // Starting the game
        countDown -= Time.deltaTime;

        countText.text = (countDown).ToString("0");

        if (countDown < 0) ;

    }

   
}
