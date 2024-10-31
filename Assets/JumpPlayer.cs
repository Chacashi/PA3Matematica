using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlayer : MonoBehaviour
{
    public GameObject jumpPlayer;
    public float x;
    public float y;
    
    void Update()
    {
        Rigidbody2D rb2 = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
       
    }
    
}
