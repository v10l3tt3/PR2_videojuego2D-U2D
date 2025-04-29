using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    //1a Aproximacion:
    //GameObject miCamara;

    //Para ajustar velocidad de nubes
    public float parallaxSpeed = 2.5f;

    void Start()
    {
        //1a Aproximacion:
        //miCamara = GameObject.Find("MainCamera");
    }


    void Update()
    {
        //1a Aproximacion:
        //Debug.Log(miCamara.transform.position.x);

        //2a Aproximacion:
        //Debug.Log(Camera.main.transform.position);
        
        //Trasladado a FIXEDUPDATE, ya que el movimiento de la camara es constante y no se ve afectado por la fisica
    }

    void FixedUpdate(){
        //vector3 para definir la posicion excluyendo en 0 a z, /parallaxSpeed para retardar el seguimiento
        transform.position = new Vector3(Camera.main.transform.position.x/parallaxSpeed, Camera.main.transform.position.y/parallaxSpeed, 0);
    }

}
