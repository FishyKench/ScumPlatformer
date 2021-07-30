using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swingingAxe : MonoBehaviour
{
   
    [SerializeField] private float firstAngle = 45;
    [SerializeField] private float secondAngle = 145;
    [SerializeField] private float speed;

    private void Update()
    {
        rotateLeft();
    }
    private void rotateLeft()
    {
        //transform.Rotate(speed * Time.deltaTime * 100, 0, 0);
        transform.rotation = Quaternion.Slerp(Quaternion.Euler(145, 0, 0), Quaternion.Euler(45, 0, 0), speed * Time.deltaTime);

        if (transform.rotation.x <= 45)
            rotateRight();
    }
    private void rotateRight()
    {
        // transform.Rotate(-speed * Time.deltaTime * 100, 0, 0);
        transform.rotation = Quaternion.Slerp(Quaternion.Euler(45, 0, 0), Quaternion.Euler(145, 0, 0), speed * Time.deltaTime);

        if (transform.rotation.x >= 145)
            rotateLeft();
    }
}
