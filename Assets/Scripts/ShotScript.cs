using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// поведінка снаряду

public class ShotScript : MonoBehaviour
{

    // Ініциалізація змінних

    // нанесення урону
    public int damage = 1;

    // нанесення урону ворог чи гравцю
    public bool isEnemyShot = false;



    // Start is called before the first frame update
    void Start()
    {
        // обмежений час життя, для того щоб, уникнути витоки памяті
        Destroy(gameObject, 20); // 20 секунд
    }
}
