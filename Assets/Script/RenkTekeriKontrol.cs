using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RenkTekeriKontrol : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int rastgeleSayi = FindObjectOfType<TopKontrol>().SayiUret();

        FindObjectOfType<TopKontrol>().RenkVeSyiSec(rastgeleSayi);

        Destroy(gameObject);

        Instantiate(this, new Vector2(transform.position.x, transform.position.y + 8f), Quaternion.identity);
        
    }
}
