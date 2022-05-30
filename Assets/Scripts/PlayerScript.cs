using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Контролер та поведінка гравця

public class PlayerScript : MonoBehaviour
{
    // Швидкість руху 
    public Vector2 speed = new Vector2(50, 50);

    // Напрямок руху
    private Vector2 movement;

    // Оголошення rigid2D
    Rigidbody2D rigid2D;

    void Start ()
    {
        // Ініціалізування rigid2D
        rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // Отримання інформації осі
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        // движение в каждом направлении
        movement = new Vector2(speed.x * inputX, speed.y * inputY);

    }

    // Викликається кожного разу через певну кількість кадрів
    void FixedUpdate()
    {
        // переміщення ігрового об'єкту
        rigid2D.velocity = movement;

    }
}
