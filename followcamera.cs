using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followcamera : MonoBehaviour
{
    public Transform playertransforme;
    Vector3 range;

    void Awake()
    {
        range = transform.position - playertransforme.position;
    }
    private void FixedUpdate()
    {
        transform.position = new Vector3(range.x + playertransforme.position.x, transform.position.y, range.z + playertransforme.position.z);

    }
}
