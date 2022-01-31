using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{

  private int _playerPoints;
  
  
  #region Unity lifecycle

  private void Start()
  {
    _playerPoints = 0;
  }
  private void Update()
  {
    Vector3 mousePosition = Input.mousePosition;
    Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

    Vector3 currentPosition = transform.position;
    currentPosition.x = worldPosition.x;
    transform.position = currentPosition;

  }

  private void addPoints(int points)
  {
    _playerPoints += points;
  }

  #endregion

}
