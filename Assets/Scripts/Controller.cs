using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Controller : MonoBehaviour
{
    private Rigidbody2D m_rigidBody;
    private Vector2 m_moveInput;
    
    void Start()
    {
        m_rigidBody = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        m_rigidBody.velocity = m_moveInput;
    }

    public void readMoveInput(InputAction.CallbackContext _context)
    {
        m_moveInput = _context.ReadValue<Vector2>();
    }
}
