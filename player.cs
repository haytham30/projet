using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    private float speed = 5f;
    public string axisName;
    public Rigidbody2D rb;
    public float speeed = 10;
    // Start is called before the first frame update
   

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }



    //update - fixedupdate - star
    void Update()
    {
        float y = Input.GetAxisRaw(axisName);
        rb.velocity = new Vector2(0, y) * speed;
        float x = Input.GetAxisRaw("Horizontal") * speeed;
        rb.velocity = new Vector2(x, 0);
        float h = Input.GetAxisRaw("Horizontal");
        GetComponent<Rigidbody2D>().velocity = Vector2.right * h * speeed;
    }
}
  

