using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dead : MonoBehaviour
{
    private GameObject personaje; 
    private MovPersonaje movPersonaje;
    
    void Start()
    {
        personaje = GameObject.Find("Personaje");
        movPersonaje = personaje.GetComponent<MovPersonaje>();
        //movPersonaje.Respawnear();

    }
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D col){
        //Debug.Log(col.name);
        if(col.name == "Personaje"){
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxDead);
            GameManager.vidas -= 1;
            movPersonaje.Respawnear();
        }
    }
}
