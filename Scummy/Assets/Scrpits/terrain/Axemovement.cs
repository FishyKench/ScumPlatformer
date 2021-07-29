using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Axemovement : MonoBehaviour
{

    public Transform axeBody;
    float xRotation = 0f;
    [SerializeField]
    private float _speed = 5f;
    Rigidbody rBody;
    // Start is called before the first frame update
    void Start()
    {
        axeBody.transform.rotation = Quaternion.Euler(90f, 90f, 90f);
    }

    // Update is called once per frame
    void Update()
    {
        axeBody.Rotate(Vector3.right * _speed);
        AxeRight();
        AxeLeft();
    }

    public void AxeRight()
    {
        if (axeBody.transform.rotation.z == 5f)
        {
            rBody.freezeRotation = true;
            StartCoroutine(WaitLeft());

        }
    }
    public void AxeLeft()
    {
        if (axeBody.transform.rotation.z == 40f)
        {
            rBody.freezeRotation = true;
            StartCoroutine(WaitRight());
        }
     }

    IEnumerator WaitRight()
    {
        yield return new WaitForSeconds(1.5f);
        AxeLeft();
    }
    IEnumerator WaitLeft()
    {
        yield return new WaitForSeconds(1.5f);
        AxeRight();
    }
}
