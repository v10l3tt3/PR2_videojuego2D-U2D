using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstrellaScript : MonoBehaviour
{
    Animator sAnimatorController;
    void Start()
    {
        sAnimatorController = this.GetComponent<Animator>();
    }

    
    void Update()
    {
            
    }

    void OnTriggerEnter2D(Collider2D colS){
        if(colS.gameObject.tag == "Player"){
            GameManager.puntoEstrella += 1;
            sAnimatorController.SetBool("destroyStar", true);
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxStarBonus);
            Destroy(this.gameObject, 0.9f);
        }
    }
}
