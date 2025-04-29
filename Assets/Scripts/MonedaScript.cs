using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonedaScript : MonoBehaviour
{
    Animator cAnimatorController;
    void Start()
    {
        cAnimatorController = this.GetComponent<Animator>();
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D colC){
        if(colC.gameObject.tag == "Player"){
            GameManager.puntos += 1;
            cAnimatorController.SetBool("destroyCoin", true);
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxCoin);
            Destroy(this.gameObject, 0.9f);
        }
    }
}