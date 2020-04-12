using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForeachLoopsPractice : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] thread = new string[6];

        thread[0] = "First Thread";
        thread[1] = "Second Thread";
        thread[2] = "Thrid Thread";
        thread[3] = "Fourth Thread";
        thread[4] = "Fifth Thread";

        foreach (string item in thread)
        {
            print(item);
        }

        string[] pages = new string[3];

        pages[0] = "First Page";
        pages[1] = "Second Page";
        pages[2] = "Thrid Page";

        foreach (string item in pages)
        {
            print(item);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
