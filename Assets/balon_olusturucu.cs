using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balon_olusturucu : MonoBehaviour
{
    public GameObject balon;
    float balonOlusturmaSuresi = 1f;
    float zamanSayaci = 0f;
    oyun_kontrol okscript;

    // Start is called before the first frame update
    void Start()
    {
        okscript = this.gameObject.GetComponent<oyun_kontrol>();    
    }

    // Update is called once per frame
    void Update()
    {
        zamanSayaci -= Time.deltaTime;
        if (zamanSayaci < 0 && okscript.zaman_sayaci>0)
        {
            GameObject go=Instantiate(balon, new Vector3(Random.Range(-2f, 2.2f), -6f, 0), Quaternion.Euler(0, 0, 0)) as GameObject;
            go.GetComponent<Rigidbody2D>().AddForce(new Vector3(0, Random.Range(50f,200f), 0));
            zamanSayaci = balonOlusturmaSuresi;

        }
    }
}
