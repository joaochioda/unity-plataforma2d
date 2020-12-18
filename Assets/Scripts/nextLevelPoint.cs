using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextLevelPoint : MonoBehaviour
{
    public string lvname;
    void OnCollisionEnter2D(Collision2D collission)
    {
        if (collission.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(lvname);
        }

       
    }
}
