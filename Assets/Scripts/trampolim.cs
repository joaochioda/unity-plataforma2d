using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trampolim : MonoBehaviour
{
    public float jumpForce;
    // Start is called before the first frame update
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }
    void OnCollisionEnter2D(Collision2D collission)
    {
        if (collission.gameObject.tag == "Player")
        {
            anim.SetTrigger("jump");
            collission.gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpForce), ForceMode2D.Impulse);
          
        }

    }
}
