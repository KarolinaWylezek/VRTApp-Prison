using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhotoMover : MonoBehaviour
{
    public float speed = 5f;  // Units per second; adjust in Inspector
    public Vector3 direction = Vector3.left;  // Fixed direction (0,0,1); set as needed

    void Update()
    {
        transform.Translate(direction.normalized * speed * Time.deltaTime, Space.Self);
    }
}
