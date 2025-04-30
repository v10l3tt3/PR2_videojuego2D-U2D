using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowAttackPersonaje : MonoBehaviour
{
    public GameObject daggerPrefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X)){
            Instantiate(daggerPrefab, transform.position, Quaternion.identity);


            ///dagger.transform.localScale = new Vector3(1, 1, 1);
            AudioManager.Instance.SonarClipUnaVez(AudioManager.Instance.fxDagger);
        }
    }
}
