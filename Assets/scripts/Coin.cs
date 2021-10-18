using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public bool rotation;
    public bool Way;
    public float speed;
    void OnTriggerEnter(Collider Player){
        if(Player.tag == "Player"){
            transform.position = new Vector3(0,-555,0);
        }

    }
    void Update()
    {
        if (rotation == true){
            transform.Rotate(0,0,speed * Time.deltaTime,Space.Self);

        }
    }
}
