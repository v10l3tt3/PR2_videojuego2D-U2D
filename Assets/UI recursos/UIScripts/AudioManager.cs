using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioManager : MonoBehaviour
{
    public AudioClip bandaSonora;
    public AudioClip fxButton;
    public AudioClip fxCoin;
    public AudioClip fxFire;
    public AudioClip fxDead;
    
    

    public GameObject musicObj;
    
    //por si se quiere usar un mixer de audio al entrar en una zona:
    //public AudioMixerSnapshot burbujaSnapshot;
    

    
    AudioSource gestorAudio;
    AudioSource audioMusic;
    
    public static AudioManager Instance;

    void Awake()
    {
        //Si existe otro objeto de este tipo, destruyelo
        if (Instance != null && Instance != this){
            Destroy(Instance.gameObject);
        }else{
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
    }

    void Start()
    {
        gestorAudio = this.GetComponent<AudioSource>();
        

        audioMusic = musicObj.GetComponent<AudioSource>();
        audioMusic.clip = bandaSonora;
        audioMusic.loop = true;
        audioMusic.volume = 0.2f;
        audioMusic.Play();
        
    }

    void Update()
    {
        
    }
 

    //Metodo seleccionador de clips de audio
    public void SonarClipUnaVez(AudioClip ac){
     gestorAudio.PlayOneShot(ac, 1f);
    }

    //Para efectos de sonido determinados por triggers
    public void IniciarEfectoBurbuja(){
        //burbujaSnapshot.TransitionTo(0.5f);
    }
    public void IniciarEfectoDefault(){
        //defaultSnapshot.TransitionTo(0.5f);
    }
}
