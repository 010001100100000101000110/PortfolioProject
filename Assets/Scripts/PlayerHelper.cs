using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHelper : MonoBehaviour
{
    public Rigidbody Rb { get; private set; }
    public CharacterController Controller { get; private set; }
    public Animator Anim { get; private set; }

    private void Awake()
    {
        Rb = GetComponent<Rigidbody>();
        Controller = GetComponent<CharacterController>();
        Anim = GetComponent<Animator>();
    }
}
