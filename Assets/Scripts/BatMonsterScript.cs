using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatMonsterScript : MonoBehaviour
{
    Vector3 posicionInicial;
    GameObject personaje;

    public float batSpeed = 8.0f;

    AudioSource _audioSource;
    void Start()
    {
        posicionInicial = transform.position;
        //personaje = GameObject.Find("Personaje");
        personaje = GameObject.FindGameObjectWithTag("Player");

        _audioSource = this.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float distancia = Vector3.Distance(transform.position, personaje.transform.position);
        float velocidadFinal = batSpeed * Time.deltaTime;

        // persigue a player cuando esta cerca (distancia -4f)
        if (distancia < 7.1f){
            //Accion:
            //Debug.DrawLine(transform.position, personaje.transform.position, Color.red, 1.5f); 
            transform.position = Vector3.MoveTowards(transform.position, personaje.transform.position, velocidadFinal);
            
            //para que no suene solo 1 frame + loop
            if(_audioSource.isPlaying == false){
                _audioSource.Play();
            }

        }else{
            transform.position = Vector3.MoveTowards(transform.position, posicionInicial, velocidadFinal);

            //para que pare el sonido al volver a la posicion inicial
            if((transform.position == posicionInicial) && _audioSource.isPlaying == true){
                _audioSource.Stop();//Debug.Log("Regresando a la posicion inicial");
            }
            
        }
    }
}
