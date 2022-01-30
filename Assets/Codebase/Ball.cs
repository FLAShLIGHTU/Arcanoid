using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;

public class Ball : MonoBehaviour
{
  #region Variables

  public Rigidbody2D Rb;
  public float Speed;
  public Vector2 Direction;

  public Transform PadTransform;
  public float YOffsetFromPad;

  private bool _isStarted;
  #endregion

  #region Unity lifecycle

  private void Start()
  {
  }

  private void Update()
  {
    if (_isStarted)
    {
      return;
    }

    MoveBallWithPad();
      
    if (Input.GetMouseButtonDown(0))
    {
      StartBall();
    }
    
  }

 
  #endregion

  #region Private methods

  private void MoveBallWithPad()
  {
    Vector3 currentPosition = PadTransform.position;
    currentPosition.y += YOffsetFromPad;
    transform.position = currentPosition;
  }

  private void StartBall()
  {
    Rb.velocity = Direction.normalized * Speed;
    _isStarted = true;
  }

  private void OnDrawGizmosSelected()
  {
    Gizmos.color = Color.red;
    Gizmos.DrawRay(transform.position, Direction);
    
  }

  #endregion
}