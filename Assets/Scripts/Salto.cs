using System.Collections;
using System.Collections.Generic;
using UnityEditor.Tilemaps;
using UnityEngine;

public class Salto : MonoBehaviour
{

   

    public Vector3 posInicial; 
    //public Color miColor;

    public float velocidad = 0.01f; 


    void Start(){
      this.GetComponent<Transform>().position = posInicial;

      this.GetComponent<SpriteRenderer>().flipX = true;
      }

    void Awake(){
       // Debug.Log("Soy Awake, soy preferente ante void Start")
    }


    void Update(){
       
       // float positionActual = this.GetComponent<Transform>().position.x;
       // transform.position = new Vector3(positionActual-0.001f,0,0); 

       // transform.Translate(velocidad,0,0); 

       // Debug.Log(transform.rotation); pero funciona con quaternions = 0.00, 0.00, 0.00, 1.00
       // transform.Rotate(0,0,velocidad);
       // transform.localScale = new Vector3(velocidad,0,0);

         // para ir a la izquierda con la A
         /*if(Input.GetKey(KeyCode.A)){
            transform.Translate(velocidad*-1, 0, 0);
         }

         // para ir a la derecha con la D
         if(Input.GetKey(KeyCode.D)){
            transform.Translate(velocidad, 0, 0);
         }*/
    }


}
