using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed=10f;
    public float rangeX=13f;
    public float rangeY=7f;
    public GameObject proyectil;
    public Vector2 offsetEnemy;
    public float velocidad = 3.0f; // Velocidad de movimiento
    public float tiempoCambioDireccion = 2.0f; // Tiempo para cambiar de dirección


    private Vector2 direccionActual;
    private float tiempoParaCambio;


    private void Start() {
        // Inicializar la primera dirección y el tiempo para cambiar
        CambiarDireccion();
        tiempoParaCambio = tiempoCambioDireccion;
    }
    // Update is called once per frame
    void Update()
    {
        //esto no funciona no es tan facil como parece
        // transform.Translate(Vector2.right*speed*Time.deltaTime);
        // transform.Translate(Vector2.left*speed*Time.deltaTime);
        // transform.Translate(Vector2.up*speed*Time.deltaTime);
        // transform.Translate(Vector2.down*speed*Time.deltaTime);
        
        

        if(transform.position.x>rangeX){
            
            transform.position=new Vector2(rangeX,transform.position.y);
        }
        else if(transform.position.x<-rangeX){
            transform.position=new Vector2(-rangeX,transform.position.y);
        }
        else if(transform.position.y>rangeY){
            transform.position=new Vector2(transform.position.x,rangeY);
        }
        else if(transform.position.y<-rangeY){
            transform.position=new Vector2(transform.position.x,-rangeY);
        }

        // Mover al jugador en la dirección actual
        transform.Translate(direccionActual * velocidad * Time.deltaTime);

        // Actualizar el temporizador para cambiar de dirección
        tiempoParaCambio -= Time.deltaTime;

        // Si ha pasado suficiente tiempo, cambiar de dirección
        if (tiempoParaCambio <= 0)
        {
            CambiarDireccion();
            tiempoParaCambio = tiempoCambioDireccion;
        }



    }

    private void CambiarDireccion()
    {
        // Generar una dirección aleatoria
        direccionActual = new Vector2(Random.Range(-1f, 1f), Random.Range(-1f, 1f)).normalized;
    }

    public void shootProjectil()
    {

            //entonces comienza a instanciar el projectil
            //objeto posicion de donde saldra rotacion inicial
            offsetEnemy=new Vector2(transform.position.x,-transform.position.y);
            Instantiate(proyectil, offsetEnemy, transform.rotation);


    }
}
