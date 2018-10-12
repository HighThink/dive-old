using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uçak : MonoBehaviour {
    public GameObject karakter;
	void Start ()
    {
        StartCoroutine(metodA());
	}

    void Update ()
    {
	}

    IEnumerator metodA()
    {
        yield return new WaitForSeconds(0.5f);
        karakter.SetActive(true);
    }
}
