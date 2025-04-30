using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowAttackPersonaje : MonoBehaviour
{
    public GameObject shuriken_0Prefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X)){
            Instantiate(shuriken_0Prefab, transform.position, Quaternion.identity);


            
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxDagger);
        }
    }
}
