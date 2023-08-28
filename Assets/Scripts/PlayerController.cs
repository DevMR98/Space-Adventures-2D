using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 15f;
    public float horizontal;
    public float rangeX = 13f;
    //objeto a instanciar
    public GameObject proyectil;


    // Update is called once per frame
    void Update()
    {
        //capturamos los controles horizontals en el eje x
        horizontal = Input.GetAxis("Horizontal");
        //movimiento del jugador segun formula fisica s=s0*v*t
        transform.Translate(Vector2.right * speed * Time.deltaTime * horizontal);

        //colocar el limite al que nuestro player puede moverse
        if (transform.position.x > rangeX)
        {
            transform.position = new Vector2(rangeX, this.transform.position.y);
        }
        if (transform.position.x < -rangeX)
        {
            transform.position = new Vector2(-rangeX, this.transform.position.y);
        }
        //validacion de y proximamente estoy pensando en la mecannica...

        //shoot projectil
        shootProjectil();
    }

    public void shootProjectil()
    {
        //si se presiona tal tecla
        if (Input.GetKeyUp(KeyCode.Space))
        {
            //entonces comienza a instanciar el projectil
            //objeto posicion de donde saldra rotacion inicial
            Instantiate(proyectil, transform.position, transform.rotation);
            Debug.Log("shoot!!");
        }


    }
}
