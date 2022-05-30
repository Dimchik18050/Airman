using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// просто переміщує ігровий об'єкт

public class MoveScript : MonoBehaviour
{
    // змінні
    // швидкість руху 
    public Vector2 speed = new Vector2(10, 10);

    // напрямок рух
    public Vector2 direction = new Vector2(-1, 0);

    private Vector2 movement;

    // оголошення rigid2D
    Rigidbody2D rigid2D;



    // Start is called before the first frame update
    void Start()
    {
        // Ініціалізування rigid2D
        rigid2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // переміщення
        movement = new Vector2(speed.x * direction.x, speed.y * direction.y);
    }

    // Викликається кожного разу через певну кількість кадрів
    void FixedUpdate()
    {
        // переміщення ігрового об'єкту
        rigid2D.velocity = movement;

    }
}
