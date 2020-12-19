using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serra : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    private bool dirRight;
    public float moveTimer;
    private float timer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(dirRight)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }else
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);

        }

        timer += Time.deltaTime;
        if (timer >= moveTimer)
        {
            dirRight = !dirRight;
            timer = 0f;
        }
    }
}
