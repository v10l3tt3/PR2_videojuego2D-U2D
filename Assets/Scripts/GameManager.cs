using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int vidas = 3;

    public static int puntos = 0;

    public static bool estoyMuerto = false;

    public static GameManager Instance { get; private set; }
    
    void Awake(){
       if(Instance == null ){
            Instance = this;
       }
        
    }

    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
}
