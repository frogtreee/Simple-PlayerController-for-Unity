using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecking : MonoBehaviour
{
    public bool isGround;
    // Start is called before the first frame update
    void Start()
    {
        isGround = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other){
        isGround = true;
    }

    void OnTriggerExit2D(Collider2D other){
        isGround = false;
    }
}
