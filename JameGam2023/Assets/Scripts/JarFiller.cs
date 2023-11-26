using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class JarFiller : MonoBehaviour, IPointerClickHandler
{

    public Image Jam;
    public Button Jar;
    public Button Preserve;
    public Button Leave;

    public float jamAmount = 3;

    public TextMeshProUGUI counter;

    public static JarFiller instance;

    public Image hunger;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Jam.fillAmount = jamAmount * 0.35f;
        counter.text = jamAmount.ToString();

        if (jamAmount <= 0)
        {
            jamAmount = 0;
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        jamAmount -= 1f;
        StorageFiller.instance.currentFillAmount = +30f;
    }

    //my event
    [Serializable]
    public class MyOwnEvent : UnityEvent { }

    [SerializeField]
    private MyOwnEvent myOwnEvent = new MyOwnEvent();
    public MyOwnEvent onMyOwnEvent { get { return myOwnEvent; } set { myOwnEvent = value; } }

    public void MyOwnEventTriggered()
    {
        onMyOwnEvent.Invoke();
    }

}
///add a collider to the object as well so the OnPointerClick can work

