using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Character : MonoBehaviour {
    public float hiz;
    Rigidbody2D fizik;
    public GameObject uçak;
    public GameObject karakter1;
    public GameObject karakter;
    public GameObject kamera;
    public GameObject kamera1;
    int sayac = 750;
    int sayac1 = 0;
    public Text sayacText1;
    public Text sayacText;
    void Start ()
    {
        fizik = GetComponent<Rigidbody2D>();
        StartCoroutine(metodA());
	}
	void Update ()
    {
        float yatay = CrossPlatformInputManager.GetAxisRaw("Horizontal");
        Vector3 vec = new Vector3(yatay,0,0);
        fizik.velocity = vec * hiz;

        sayac1++;
        StartCoroutine(metodC());

        sayac--;
        StartCoroutine(metodB());
        sayacText.text =""+sayac;    
    }
    IEnumerator metodA()
    {
        yield return new WaitForSeconds(0.1f);
        uçak.SetActive(false);
    }
    IEnumerator metodB()
    {
        yield return new WaitForSeconds(0.1f);
    }
    IEnumerator metodC()
    {
        yield return new WaitForSeconds(1);
    }
    private void OnTriggerEnter2D(Collider2D h)
    {
        if (h.gameObject.tag == "yer")
        {
            karakter.SetActive(false);
            karakter1.SetActive(true);
            kamera.SetActive(false);
            kamera1.SetActive(true);
            sayacText.enabled = false;
            sayacText1.text = "Zaman = " + sayac1;
        }
        if (h.gameObject.tag == "kus")
        {
            SceneManager.LoadScene("Sahne1");
        }
    }
}
