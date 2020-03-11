using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    // This variable is used with the For Loop example
    public int numEnemies = 5;
    // This variable is used with the While Loop example
    public int cupsInTheSink = 10;
        
    // Start is called before the first frame update
    void Start()
    {
        //For Loop Example
        // = sign by < is to round out the number
        for (int i = 0; i <= numEnemies; i++)
         {
             Debug.Log("Creating enemy number: " + i);
         }

        //While Loop example
        while (cupsInTheSink > 0)
        {
          //  i < Enemies; i++[Debug.Log]
            Debug.Log("I washed a cup!");
            cupsInTheSink --;
        }

        // Do While Loop Example
        bool shouldContinue = false;

         do
         {
             print("Hello World");

         } while (shouldContinue == true);


        //Foreach Loop Example
        string[] strings = new string[3];

        strings[0] = "First string";
        strings[1] = "Second string";
        strings[2] = "Third string";

        foreach (string item in strings)
        {
            print(item);
        }

        // Practice Code Here

       
      //  foreach (var Num Enemies) ; 
      //  {
           
      //  }

      //  for (int i = 100; i <= 100; i++) ;
      //  {
      //      Debug.Log(int i = 100;  "Does not go down" + Num);
      //  }

      //  while (Num < 100)
      //  {
      //      Enemies += 1;

      //      Enemies = -1;

      //      Debug.Log("Represents Adding or Subtracking Enemies");
      //  }
      
    }

  //Practice end here

    // Update is called once per frame
    void Update()
    {
        
    }
}
