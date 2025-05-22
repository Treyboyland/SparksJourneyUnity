using UnityEngine;

public class BoxColliderFixer : MonoBehaviour
{
    public void FixCollider()
    {
        var collider = GetComponent<BoxCollider2D>();
        var sprite = GetComponent<SpriteRenderer>();

        if (collider != null && sprite != null && sprite.drawMode == SpriteDrawMode.Tiled)
        {
            collider.offset = Vector2.zero;
            collider.size = sprite.size;
        }
    }
}
