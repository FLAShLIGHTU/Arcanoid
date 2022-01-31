using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pad : MonoBehaviour
{

  private int _playerPoints;
  private StatsSO _currentPoints;
  public Text points;
  
  #region Unity lifecycle

  private void Start()
  {
    points.text = ($"Score {_currentPoints.PlayerStats}");
  }
  private void Update()
  {
    Vector3 mousePosition = Input.mousePosition;
    Vector3 worldPosition = Camera.main.ScreenToWorldPoint(mousePosition);

    Vector3 currentPosition = transform.position;
    currentPosition.x = worldPosition.x;
    transform.position = currentPosition;

  }

  #endregion

}
