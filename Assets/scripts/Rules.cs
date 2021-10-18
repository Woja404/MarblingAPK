using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rules : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Centar")
        {
            transform.position = new Vector3(5003.8f, 76.2f, 666.718f);
            Points.instance.AddPoint();
        }
        if (other.tag == "Centar2")
        {
            transform.position = new Vector3(5003.8f, 76.2f, 666.718f);
            Points.instance.AddPoint();
            Points.instance.AddPoint();
        }
        if (other.tag == "Centar3")
        {
            transform.position = new Vector3(5003.8f, 76.2f, 666.718f);
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
        }
        if (other.tag == "Centar4")
        {
            transform.position = new Vector3(5003.8f, 76.2f, 666.718f);
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();

        }
        if (other.tag == "Centar5")
        {
            transform.position = new Vector3(5003.8f, 76.2f, 666.718f);
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();

        }
        if (other.tag == "Centar6")
        {
            transform.position = new Vector3(5003.8f, 76.2f, 666.718f);
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
        }
        if (other.tag == "Centar7")
        {
            transform.position = new Vector3(5003.8f, 76.2f, 666.718f);
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
        }
        if (other.tag == "Centar8")
        {
            transform.position = new Vector3(5003.8f, 76.2f, 666.7f);
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
        }
        if (other.tag == "Centar9")
        {
            transform.position = new Vector3(5003.8f, 76.2f, 666.7f);
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
        }
        if (other.tag == "Centar10")
        {
            transform.position = new Vector3(5003.8f, 76.2f, 666.7f);
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
            Points.instance.AddPoint();
        }
    }
}
