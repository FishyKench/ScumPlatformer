using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;

public class btnBandage : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private GameObject bandage;

    private void Awake()
    {
        bandage.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        bandage.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        bandage.SetActive(false) ;
    }
}
