using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveProjectil : MonoBehaviour
{   
    public float speed=15f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.up*speed*Time.deltaTime);
    }
}