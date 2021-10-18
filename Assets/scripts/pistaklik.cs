using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pistaklik : MonoBehaviour
{
    public AudioSource sound;
    void OnTriggerEnter(Collider Player){
        if(Player.tag == "Player"){
            sound.Play();
        }
    }
}
