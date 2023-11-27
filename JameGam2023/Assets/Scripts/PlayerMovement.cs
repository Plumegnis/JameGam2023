using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public float runSpeed = 100f;
    float horizontalMove = 80f;

    public static PlayerMovement instance;

    private void Awake()
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
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        runSpeed = StorageFiller.instance.currentFillAmount * runSpeed;
        if (StorageFiller.instance.currentFillAmount <= 0.2)
        {
            runSpeed = 20;
        }

        horizontalMove = Input.GetAxis("Horizontal") * runSpeed;
    }
    void FixedUpdate() {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, false);
    }
}
