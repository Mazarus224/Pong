using UnityEngine;

public class CloseOpenTitleScreen : MonoBehaviour
{
    public SpriteRenderer sr;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        sr = GetComponent<SpriteRenderer>();
        if(Input.GetKeyDown("space"))
        {
            sr.enabled =false;
        }
        
    }
}
