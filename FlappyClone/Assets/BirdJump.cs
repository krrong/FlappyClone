// 외부 모듈 import 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rb;
    public float jumpPower;

    // Start is called before the first frame update --> only start
    void Start()
    {
        // Debug.Log("start");

        rb = GetComponent<Rigidbody2D>();   // to get component
    }

    // Update is called once per frame --> every frame
    void Update()
    {
        // Debug.Log("update");

        // click the left mouse button (0 is left button)
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumpPower; // Vector2 is 2dimension Vector2.up = (0, 1)
        }
    }
}
