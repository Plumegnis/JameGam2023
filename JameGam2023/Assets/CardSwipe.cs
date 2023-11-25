using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardSwipe : MonoBehaviour
{
    public float swipeSpeed = 5f; // Szybkość przesuwania karty
    public float rotationAngle = 15f; // Kąt obrotu karty podczas przesuwania

    private bool isDragging = false;
    private Vector2 lastPosition;

    void Update()
    {
        HandleInput();
    }

    void HandleInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isDragging = true;
            lastPosition = Input.mousePosition;
        }
        else if (Input.GetMouseButtonUp(0))
        {
            isDragging = false;
        }

        if (isDragging)
        {
            Vector2 currentPosition = Input.mousePosition;
            float swipeInput = currentPosition.x - lastPosition.x;

            // Przesuwanie karty
            float translation = swipeInput * swipeSpeed * Time.deltaTime;
            transform.Translate(new Vector3(translation, 0f, 0f));

            // Dodanie obrotu karty podczas przesuwania
            float rotation = Mathf.Clamp(translation * rotationAngle, -rotationAngle, rotationAngle);
            transform.Rotate(new Vector3(0f, 0f, -rotation));

            lastPosition = currentPosition;
        }
    }
}