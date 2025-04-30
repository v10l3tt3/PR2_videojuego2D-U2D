using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
    Animator dAnimatorController;
    void Start()
    {
        dAnimatorController = this.GetComponent<Animator>();
    }

    
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D colD){
        if(colD.gameObject.tag == "Player"){
            GameManager.puntoDiamante += 1;
            dAnimatorController.SetBool("destroyDiamond", true);
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxDiamondCompleted);
            Destroy(this.gameObject, 0.9f);
        }
    }
}
