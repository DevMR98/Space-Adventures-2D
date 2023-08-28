using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOfOutBounds : MonoBehaviour
{
    public float rangeY=9;
    

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y>rangeY){
            Destroy(gameObject);
        }
    }
}
