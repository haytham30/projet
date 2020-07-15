using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background1 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "player")
        {
            transform.position += 2 * Vector3.right * GetComponent<SpriteRenderer>().bounds.size.x;
        }
    }
}
