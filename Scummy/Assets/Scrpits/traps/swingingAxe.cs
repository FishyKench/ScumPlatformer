using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swingingAxe : MonoBehaviour
{
   
    [SerializeField] private float firstAngle = 45;
    [SerializeField] private float secondAngle = 145;
    [SerializeField] private float speed;


    private void Start()
    {
        //StartCoroutine(MovingAxe());
        StartCoroutine(MovingAxe());
    }

    private void Update()
    {
        //  rotateLeft();
       // StartCoroutine(MovingAxe());
    }
    private void rotateLeft()
    {
        //transform.Rotate(speed * Time.deltaTime * 100, 0, 0);
       // transform.rotation = Quaternion.Lerp(Quaternion.Euler(0, 145, 0), Quaternion.Euler(0, 45, 0), speed * Time.deltaTime);

       // if (transform.rotation.x <= 45)
         //   rotateRight();
    }
    private void rotateRight()
    {
        // transform.Rotate(-speed * Time.deltaTime * 100, 0, 0);
      //  transform.rotation = Quaternion.Lerp(Quaternion.Euler(0, 45, 0), Quaternion.Euler(0, 145, 0), speed * Time.deltaTime);

        //if (transform.rotation.x >= 145)
           // rotateLeft();
    }


    IEnumerator MovingAxe()
    {
        while (true)
        {
            // transform.rotation = Quaternion.Lerp(Quaternion.Euler(0, 145, 0), Quaternion.Euler(0, 45, 0), speed * Time.deltaTime);
            transform.Rotate(new Vector3(1 , 0, 0));
            yield return new WaitForSeconds(2.0f);
            //  transform.rotation = Quaternion.Lerp(Quaternion.Euler(0, 45, 0), Quaternion.Euler(0, 145, 0), speed * Time.deltaTime);
            transform.Rotate(new Vector3(-1 , 0, 0));
            yield return new WaitForSeconds(2.0f);
        }
    }
}
