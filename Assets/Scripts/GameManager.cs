using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int vidas = 3;

    public static int puntos = 0;

    public static int enemiesKills = 0;
    public static int puntoDiamante = 0;

    public static bool estoyMuerto = false;

    public static GameManager Instance { get; private set; }

    GameObject vidasText;
    GameObject puntosText;
    
    void Awake(){
       if(Instance == null ){
            Instance = this;
       }
        
    }

    void Start()
    {
        vidasText = GameObject.Find("vidasText");
        puntosText = GameObject.Find("puntosText");
    }

    
    void Update()
    {
        Debug.Log("Vidas: " + vidas);
        Debug.Log("Enemigos Muertos: " + enemiesKills);
        Debug.Log("Puntos: " + puntos); 
        Debug.Log("Diamantes: " + puntoDiamante);

        vidasText.GetComponent<TMPro.TextMeshProUGUI>().text = vidas.ToString();
        //GetComponent<TMPro.TextMeshProUGUI>().text = enemiesKills.ToString();
        puntosText.GetComponent<TMPro.TextMeshProUGUI>().text = "Score Points: "+ puntos.ToString();
        //GetComponent<TMPro.TextMeshProUGUI>().text = puntoDiamante.ToString+();
        
    }
}
