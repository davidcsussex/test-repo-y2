
public class YourScript : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Sprite firstSprite;
    public Sprite secondSprite;





    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            spriteRenderer = GetComponent<SpriteRenderer>(); 
            spriteRenderer.sprite = firstSprite;
        }
    }

}