using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other) {
        
            if(other.CompareTag("enemy")){
                Destroy(gameObject);
                Destroy(other.gameObject);
            }
        
    }

}
