using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{

    public GameObject[] enemies;
    public float starTime=1f;
    public float repeatTime=2;
    public int randomIndex;
    public float randomPositionX;
    public float limitPositionX=13f;
    public float randomPositionY;
    public float limitPositionY=7f;
    public Vector2 randomPosition;
    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomEnemies",starTime,repeatTime);
    }

    public void SpawnRandomEnemies(){
        randomIndex=Random.Range(0, enemies.Length);
        randomPositionX=Random.Range(-limitPositionX, limitPositionX);
        randomPositionY=Random.Range(-limitPositionY,limitPositionY);
        randomPosition=new Vector2(randomPositionX,randomPositionY);
        transform.position=randomPosition;

        Instantiate(enemies[randomIndex],enemies[randomIndex].transform.position,
        enemies[randomIndex].transform.rotation);
        
        
    }

    
}
