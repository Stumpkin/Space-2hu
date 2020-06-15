using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullets : MonoBehaviour
{
    public Rigidbody2D rb2D;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 5)
        {
            Destroy(gameObject);
        }

        rb2D.velocity = Vector2.up * 20f;
    }

    void OnTriggerEnter(Collider collider2D)
    {
        Destroy(gameObject);
    }
}
