using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coinjump : MonoBehaviour
{
    public float forceX;
    public float forceY;
    public bool Grounded= false;
    public Vector3 Charging;
    public Touch touch;
    public AudioSource Sorce;

    void OnTriggerEnter(Collider Player){
           if(Player.tag =="Coin"){
            Sorce.Play();
            Grounded = true;
        }
    }

    void Update()
    {
        if (Input.touchCount>0  & Grounded == true){
            Charging += new Vector3(-forceX,forceY,0);
        }
        if (Input.touchCount==2 & Grounded == true){
            GetComponent<Rigidbody>().AddForce(Charging);
            Grounded = false;            
        }

    }

}
