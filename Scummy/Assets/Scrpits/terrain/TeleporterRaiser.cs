using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleporterRaiser : MonoBehaviour
{

    [SerializeField]
    private int _pillyCount;
    [SerializeField]
    private bool _isRaised;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_pillyCount == 2 && ! _isRaised)
        {
            RaiseBlock();
        }
    }

    public void AddPilly()
    {
        _pillyCount += 1;
    }


    private void RaiseBlock()
    {
        transform.position = new Vector3(-101, 83.5f, transform.position.z);
        _isRaised = true;
    }



}
