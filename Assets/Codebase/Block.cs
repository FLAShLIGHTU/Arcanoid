using UnityEngine;

public class Block : MonoBehaviour
{
  public int hit;
  public int points;
  public Sprite sprite1;
  public Sprite sprite2;
  private StatsSO StatsSo;

  private SpriteRenderer _spriteRenderer;
  private int numberhit;

  private void Start()
  {
    _spriteRenderer = GetComponent<SpriteRenderer>();
    numberhit = 0;
  }
  
  
  private void OnCollisionEnter2D(Collision2D col)
  {
    ChangeSprite();
    numberhit++;
    

    if (numberhit == hit)
      {
        Destroy(gameObject);
        StatsSo.PlayerStats += points;
      }
  }

  private void ChangeSprite()
  {
    if (_spriteRenderer == sprite1)
    {
      _spriteRenderer.sprite = sprite2;
    }
  }
  
    
}