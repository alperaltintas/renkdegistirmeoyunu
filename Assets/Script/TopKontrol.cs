using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TopKontrol : MonoBehaviour
{
    [SerializeField] Color[] colors;
    [SerializeField] String[] tagName;

    [SerializeField] float ziplamaKuvveti = 0f;

    public int rakam = 5;


    void Start()
    {
        RenkVeSyiSec(SayiUret());
    }

    void Update()
    {
        TopZiplama();
    }

    public int SayiUret()
    {
        int sayi = UnityEngine.Random.Range(0, 4);
        return sayi;
    }

    #region Top Zıplama
    private void TopZiplama()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = Vector2.up * ziplamaKuvveti;
        }
    }
    #endregion

    public void RenkVeSyiSec(int sayi)
    {
        GetComponent<SpriteRenderer>().color = colors[sayi];
        gameObject.tag = tagName[sayi];
    }
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != gameObject.tag && !collision.gameObject.CompareTag("Yildiz") && !collision.gameObject.CompareTag("RenkTekeri"))
        {
            //burada öldürmeye gerek zaten oyun baştan başlayacak sıkıntı yok yani öldürmemende

            SceneManager.LoadScene(0);

        }
        
    }

    
}
