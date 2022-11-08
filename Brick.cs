using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour //IBrick
{
    public int lives;


    // Start is called before the first frame update
    void Start()
    {
        lives = Random.Range(1, 3);
        //IBrick.Lives = lives;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnResolveHit()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            //Debug.Log("Ball!");
        }
    }
}
