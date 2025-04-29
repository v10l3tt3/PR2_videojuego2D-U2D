using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxSinY : MonoBehaviour
{
    public float parallaxSpeedX = 10.5f;
    
    void Start()
    {
        
    }

    void Update()
    {
        //Trasladado a FIXEDUPDATE, ya que el movimiento de la camara es constante y no se ve afectado por la fisica
    }

    void FixedUpdate(){
        //vector3 para definir la posicion excluyendo en 0 a z, /parallaxSpeedX para retardar el seguimiento, /SIN Y para Mountains del fondo
        transform.position = new Vector3(Camera.main.transform.position.x/parallaxSpeedX, -1, 0); 
    }
}
