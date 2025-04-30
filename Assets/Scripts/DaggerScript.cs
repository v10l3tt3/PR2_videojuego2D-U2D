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
        
        Debug.Log(colDS.gameObject.tag == "EnemyGhost");
        
        
        if(colDS.gameObject.tag == "EnemyGhost"){
            //no AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxDagger);
            Destroy(colDS.gameObject, 0.1f);
            GameManager.enemiesKills += 1;
            Destroy(this.gameObject, 0.1f);
        }
        Debug.Log(colDS.gameObject.tag == "EnemyMonster");

        if(colDS.gameObject.tag == "EnemyMonster"){
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.monsterDeathFX);
            
            
            //animacion de muerte
            colDS.gameObject.GetComponent<Animator>().SetBool("SliceinHalf", true);
            
            Rigidbody2D rb = colDS.gameObject.GetComponent<Rigidbody2D>();
            rb.constraints = RigidbodyConstraints2D.FreezePositionX;
            rb.constraints = RigidbodyConstraints2D.FreezePositionY;

            Destroy(colDS.gameObject, 1.1f);
            GameManager.enemiesKills += 1;
            Destroy(this.gameObject, 3.1f);
        }
    }
}
