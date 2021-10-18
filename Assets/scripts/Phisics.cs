using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Phisics : MonoBehaviour
{
    public float forceX;
    public float forceY;
    public bool Grounded= false;
    public Vector3 Charging;
    public Touch touch;
    private float x=0;
    private float y=0;

    void OnColisionEnter(){
        Grounded = true;
        Charging = new Vector3(0,0,0);
    }

    void Update(){
        int Marble = PlayerPrefs.GetInt("selectCharacter");
        Marble = Marble +1;

        if (Input.touchCount>0 & Grounded == true){
            x = x + forceX;
            if (x> 1100){
            x=20;
            }
            if (y> 1100){
            y=20;
            }
            y = y + forceY;
            Charging = new Vector3(-x*Marble,y*Marble,0);
        }
        if (Input.touchCount==2 & Grounded == true){
            GetComponent<Rigidbody>().AddForce(Charging);
            Grounded = false;            
        }

    }

 }

