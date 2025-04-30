using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int vidas = 3;

    public static int puntosCoin = 0;

    public static int enemiesKills = 0;

    public static int puntoEstrella = 0;
    public static int puntoDiamante = 0;

    public static bool estoyMuerto = false;

    public static GameManager Instance { get; private set; }

    GameObject vidasText;
    GameObject monedasText;
    GameObject muertesText;
    GameObject estrellaText;
    GameObject diamanteText;
    
    void Awake(){
       if(Instance == null ){
            Instance = this;
       }
        
    }

    void Start()
    {
        vidasText = GameObject.Find("vidasText");
        monedasText = GameObject.Find("monedasText");
        muertesText = GameObject.Find("muertesText");
        estrellaText = GameObject.Find("estrellaText");
        diamanteText = GameObject.Find("diamanteText");
    }

    
    void Update()
    {
        Debug.Log("Vidas: " + vidas);
        Debug.Log("Enemigos Muertos: " + enemiesKills);
        Debug.Log("Puntos: " + puntosCoin); 
        Debug.Log("Estrella: " + puntoEstrella);
        Debug.Log("Diamantes: " + puntoDiamante);

        vidasText.GetComponent<TMPro.TextMeshProUGUI>().text = vidas.ToString();
        muertesText.GetComponent<TMPro.TextMeshProUGUI>().text = enemiesKills.ToString();
        monedasText.GetComponent<TMPro.TextMeshProUGUI>().text = puntosCoin.ToString();
        estrellaText.GetComponent<TMPro.TextMeshProUGUI>().text = puntoEstrella.ToString();
        diamanteText.GetComponent<TMPro.TextMeshProUGUI>().text = puntoDiamante.ToString();
        
    }
}
