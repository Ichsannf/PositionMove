using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
    Rigidbody2D move;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
       move = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horiz ontal");
        float vertikal = Input.GetAxisRaw("Vertical");
        move.velocity = new Vector2(speed * horizontal, vertikal);
       
    }
}
