using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public GameObject PlayerDeath;
    Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)){
            jump();
        }
        
    }

    void jump(){
        rb.AddForce(Vector2.up * 5, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision){
    if (collision.CompareTag("wall")){
        this.enabled = false;
        PlayerDeath.SetActive(true);
        Time.timeScale = 0f;
    }
    }
}
