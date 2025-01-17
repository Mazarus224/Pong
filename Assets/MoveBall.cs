using UnityEngine;

public class MoveBall : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D rb;
    public float ForceAmount = 10;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown("space"))
        {
            transform.position = new Vector2(0,0);
            rb.AddForce(Vector2.right * ForceAmount, ForceMode2D.Impulse);
            
        }
        if(transform.position.y > 11 || transform.position.y < -11)
        {
            transform.position = new Vector2(12,12);
        }
    }
}
