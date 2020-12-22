using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyun_kontrol : MonoBehaviour
{
    public GameObject patlama;
    public UnityEngine.UI.Text zamanText,balonText;
    public float zaman_sayaci = 60f;
    int patlayan_balon = 0;

    // Start is called before the first frame update
    void Start()
    {
        balonText.text = "" + patlayan_balon;
    }

    // Update is called once per frame
    void Update()
    {
        if (zaman_sayaci > 0)
        {
            zaman_sayaci -= Time.deltaTime;
            zamanText.text = (int)zaman_sayaci + "";
        }
        else
        {
            GameObject[] go = GameObject.FindGameObjectsWithTag("balon_c");
            for(int i = 0; i < go.Length; i++)
            {
                GameObject an=Instantiate(patlama, go[i].transform.position, go[i].transform.rotation)as GameObject;
                Destroy(go[i]);
                Destroy(an,0.3f);
            }
        }

    }
    public void balonEkle()
    {
        patlayan_balon += 1;
        balonText.text = patlayan_balon + "";

    }
}
