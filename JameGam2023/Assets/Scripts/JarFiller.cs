using System;
using System.Collections;
using System.Collections.Generic;
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

    public Text counter;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Jam.fillAmount = jamAmount;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        jamAmount--;
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

