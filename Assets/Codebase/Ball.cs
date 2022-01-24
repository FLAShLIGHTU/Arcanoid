using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
  public Rigidbody2D Rb;
  public float Speed;
  public Vector2 Direction;
  
  public Vector2 DirectionNormalized;
  public float Velocity;

  private void Start()
  {
    DirectionNormalized = Direction.normalized;
    Rb.velocity = Direction.normalized * Speed;
  }

  private void Update()
  {
    
    
  }
}