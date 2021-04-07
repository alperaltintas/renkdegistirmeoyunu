using UnityEngine;

public class Kamera : MonoBehaviour
{
    [SerializeField] GameObject top;

    void Start()
    {
        
    }

    void Update()
    {
        TopuTakipEt();
    }

    private void TopuTakipEt()
    {
        if (top.transform.position.y > transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, top.transform.position.y, transform.position.z);
        }
    }
}
