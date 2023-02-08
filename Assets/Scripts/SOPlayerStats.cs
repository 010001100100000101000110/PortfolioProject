using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerStats" ,menuName = "ScriptableObject/PlayerStats")]
public class SOPlayerStats : ScriptableObject
{
    public float MovementSpeed;
    public float JumpForce;
}
