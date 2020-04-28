using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    public float move = 4f;
    public Transform locate
    {
        get { return locate; }
        set
        {
            locate = value;

            StopCoroutine("Movement");
           // StopCoroutine("Movement", locate);
           // StopCoroutine locate isn't working
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(MyCoroutine(locate));
    }

    IEnumerator MyCoroutine(Transform locate)
    {

        while (Vector3.Distance(transform.position, locate.position) > 1f)
        {
            transform.position = Vector3.Lerp(transform.position, locate.position, move * Time.deltaTime);

            yield return null;

        }

        print("Reached it's destined location");

        //WaitForSeconds is not working 
      //  yield return null WaitForSeconds(2f);


        print("Finished");
    }

   
}
