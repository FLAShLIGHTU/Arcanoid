using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dawnwall : MonoBehaviour
{
  private void OnCollisionEnter2D(Collision2D col)
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);


  }
}
