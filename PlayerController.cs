using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D rb;
    public float speed = 6.0f;
    public float jump = 800;
    public GameObject obj;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Player Movement
        if(Input.GetKey(KeyCode.D)){
            this.transform.Translate(speed, 0,0);
            GetComponent<SpriteRenderer>().flipX = false;
        }
        if(Input.GetKey(KeyCode.A)){
            this.transform.Translate(-speed, 0,0);
            GetComponent<SpriteRenderer>().flipX = true;
        }

        if(obj.GetComponent<GroundChecking>().isGround == true){
            if(Input.GetKey(KeyCode.Space)){
                rb.AddForce(new Vector2(rb.velocity.x, jump));
            }
        }

    }
}
