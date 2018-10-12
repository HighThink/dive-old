using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kamera : MonoBehaviour {


    public GameObject karakter;
    Vector3 aradakiMesafe;
    void Start()
    {
        aradakiMesafe = transform.position - karakter.transform.position;

    }


    void LateUpdate()
    {

        transform.position = karakter.transform.position + aradakiMesafe;

    }
}
