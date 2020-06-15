using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    public Rigidbody2D rb2D;
    public float speed = 12f;
    public GameObject cannon, cannon2, cannon3, cannon4, cannon5;
    public List<GameObject> bullets;
    public int cannonPermit = 1;
    public int type = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
        Guns();

        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Gun Mode Swtiched");
            switch(type)
            {
                case 0:
                    type += 1;
                    break;

                case 1:
                    type -= 1;
                    break;
            }
        }
    }

    void Movement()
    {
        bool Move = false;

        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            Move = true;
        }
        
        if (Move)
        {
            rb2D.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, Input.GetAxis("Vertical") * speed);
        }

        else
        {
            rb2D.velocity = new Vector2(0f, 0f);
        }
    }

    void Guns()
    {
        bool fire = false;

        if (Input.GetKey(KeyCode.Mouse0))
        {
            fire = true;
        }

        if (fire)
        {

            switch(cannonPermit)
            {
                case 1:
                    Fire(cannon);
                    break;

                case 2:
                    Fire(cannon);
                    Fire(cannon2);
                    break;

                case 3:
                    Fire(cannon);
                    Fire(cannon2);
                    Fire(cannon3);
                    break;

                case 4:
                    Fire(cannon);
                    Fire(cannon2);
                    Fire(cannon3);
                    Fire(cannon4);
                    break;

                case 5:
                    Fire(cannon);
                    Fire(cannon2);
                    Fire(cannon3);
                    Fire(cannon4);
                    Fire(cannon5);
                    break;

            }
            // instantate bulllets to cannons
        }
    }

    void Fire(GameObject cannonNum)
    {
        bullets[type].transform.position = cannonNum.transform.position;
        Instantiate(bullets[type]);
    }
}
