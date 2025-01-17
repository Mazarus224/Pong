using UnityEngine;

public class MovePaddle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 100;
    public Rigidbody2D paddlebody;

    public float moveup;
    public float movedown;
    public float tiltfor;
    public float tiltback;
    void Start()
    {
        paddlebody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        moveup = transform.position.y;
        movedown = transform.position.y;
        Transform Tiltpaddle = GetComponent<Transform>();
        /*
        float y = Input.GetAxis("Vertical");
        Vector2 movement = new Vector2(0,y);
        transform.Translate(movement * speed * Time.deltaTime);
        */
        if(Input.GetKeyDown("up"))
        {
            moveup = transform.position.y;
            moveup+=1;
            transform.position = new Vector2(transform.position.x, moveup);
        }
        if(Input.GetKeyDown("down"))
        {
            movedown = transform.position.y;
            movedown-=1;
            transform.position = new Vector2(transform.position.x, movedown);
        }
        if(Input.GetKeyDown("right"))
        {
           
           Tiltpaddle.Rotate(new Vector3(0,0,-10), Space.Self);
        }
        if(Input.GetKeyDown("left"))
        {
            
            Tiltpaddle.Rotate(new Vector3(0,0,10), Space.Self);
        }
        

    }
}
