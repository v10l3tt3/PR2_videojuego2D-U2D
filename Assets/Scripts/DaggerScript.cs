using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class DaggerScript : MonoBehaviour
{
    GameObject personaje;
    bool dagaDerecha = true;

    public float speedDaga = 2.0f;

    float tiempoDestruccion = 5.5f;
    float queHoraEs;

    void Start()
    {
        personaje = GameObject.Find("Personaje");
        dagaDerecha = personaje.GetComponent<MovPersonaje>().miraDerecha;

        queHoraEs = Time.time;  
    }

    void Update()
    {
        //trasladar a la izq = num. negativos, a la derecha = num. positivos
        //transform.position += new Vector3(0.1f, 0, 0) * Time.deltaTime;
        

        if(dagaDerecha == true){
            transform.Translate(speedDaga * Time.deltaTime,0,0, Space.World);
        }else{
            transform.Translate((speedDaga*Time.deltaTime)*-1,0,0, Space.World);
        }

        if(Time.time >= queHoraEs + tiempoDestruccion){
            Destroy(this.gameObject, 0.1f);
        }
    }

    void OnTriggerEnter2D(Collider2D colDS){
        
        Debug.Log(colDS.gameObject.tag == "Enemy");
        
        if(colDS.gameObject.tag == "Enemy"){
            //AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxDagger);
            Destroy(colDS.gameObject, 0.1f);
            GameManager.enemiesKills += 1;
            Destroy(this.gameObject, 0.1f);
        }
    }
}
