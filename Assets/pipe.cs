using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public float speed;
    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}