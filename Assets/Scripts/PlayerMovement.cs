using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem; 

public class PlayerMovement : MonoBehaviour
{
    PlayerControls inputs;
    PlayerHelper helper;
    Vector2 lookInput => inputs.Player.Look.ReadValue<Vector2>();
    Vector2 movementDirection => inputs.Player.Move.ReadValue<Vector2>();
    [SerializeField] float activeMovementSpeed;

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
        helper = GetComponent<PlayerHelper>();
        
    }

    void Update()
    {
        Animate();
    }
    private void FixedUpdate()
    {
        Movement();
    }
    void Movement()
    {
        Vector3 direction = movementDirection;
        helper.Rb.MovePosition(transform.position + (direction * activeMovementSpeed * Time.deltaTime));
    }
    void Animate()
    {
        helper.Anim.SetFloat("Speed", inputs.Player.Move.ReadValue<Vector2>().magnitude);
    }
}
