using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Hero : MonoBehaviour
{
    [Header("Set in Inspector")]
    public float speed = 5;

    //[Header("Set Dynamically")]

    private Rigidbody2D rigid;
    private float moveDirection;

    void Awake()
    {
        rigid = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float moveX = Input.GetAxisRaw("Horizontal");
        moveDirection = moveX;
        if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(0, rigid.velocity.y + 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(0, rigid.velocity.y - 1, 0);
        }
    }

    void FixedUpdate()
    {
        rigid.velocity = new Vector2(moveDirection * speed, rigid.velocity.y);
    }
}
