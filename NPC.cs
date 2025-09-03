using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    // Start is called before the first frame update
    //Здоровье игрока
    public int health = 3;
    //Скорость игрока
    public float speed = 1.2f;
    //Уровень игрока
    public int level = 1;
    void Start()
    {
        //прибавляет уровень к хп
        health += level;
        //выводит его
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
