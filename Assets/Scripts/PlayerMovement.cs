using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerMovement : MonoBehaviour
{
    PlayerControls inputs;
    Vector2 lookInput => inputs.Player.Look.ReadValue<Vector2>();
    Vector2 movementDirection => inputs.Player.Move.ReadValue<Vector2>();


    private void Awake()
    {
        inputs = new PlayerControls();
        
    }
    private void OnEnable()
    {
        inputs.Enable();
        inputs.Player.Enable();
    }
    private void OnDisable()
    {
        inputs.Disable();
        inputs.Player.Disable();
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    void Movement()
    {
        //helper.Rb.MovePosition(transform.position + (direction * activeMovementSpeed * Time.deltaTime));
    }
}
