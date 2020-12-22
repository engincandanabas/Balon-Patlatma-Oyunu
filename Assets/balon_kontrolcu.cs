using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balon_kontrolcu : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject patlama;
    oyun_kontrol oyunKontrolScript;

    private void Start()
    {
        oyunKontrolScript = GameObject.Find("_Scripts").GetComponent<oyun_kontrol>();

    }
    private void OnMouseDown()
    {
        GameObject  go=Instantiate(patlama, transform.position, transform.rotation)as GameObject;
        Destroy(this.gameObject);
        Destroy(go, 0.3f);
        oyunKontrolScript.balonEkle();
    }
}
