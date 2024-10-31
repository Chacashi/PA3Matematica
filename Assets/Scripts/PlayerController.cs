using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;


public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed;

      float horizontal;
    Vector2 newPosition;
    
   
    Rigidbody2D _compRigidbody2D;
    private void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }

    public  void AxisX(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<float>();
    }

  


    private void FixedUpdate()
    {
          newPosition = new Vector2(speed * horizontal, _compRigidbody2D.velocity.y);
        
        _compRigidbody2D.AddForce(newPosition);
    }
}
