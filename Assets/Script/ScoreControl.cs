using UnityEngine;
using UnityEngine.UI;

public class ScoreControl : MonoBehaviour
{
    [SerializeField] GameObject daire;
    [SerializeField] Text scoreText;
    [SerializeField] float mesafe = 0f;

    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score += 5;
        scoreText.text = score.ToString();
        Destroy(gameObject);

        Instantiate(daire, new Vector2(transform.position.x, transform.position.y + mesafe), Quaternion.identity);
    }
}
