using UnityEngine;

public class Block : MonoBehaviour
{
  public int hit;
  private int numberhit;

  private void Start()
  {
    numberhit = 0;
  }
  
  
  private void OnCollisionEnter2D(Collision2D col)
  {
    numberhit++;

      if (numberhit == hit)
      {
        Destroy(gameObject);
      }
  }
    
}