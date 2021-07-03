using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmoothFollowMouse : MonoBehaviour
{
    Vector3 mouse;
    public float moveSpeed = 0.1f;
    Rigidbody2D rb;
    Vector2 position = new Vector2(0f, 0f);
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        mouse = Input.mousePosition;
        mouse = Camera.main.ScreenToViewportPoint(mouse);
        position = Vector2.Lerp(transform.position, mouse, moveSpeed);
    }

    private void FixedUpdate()
    {
        rb.MovePosition(position);
    }
}
