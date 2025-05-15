using UnityEngine;

public class LoopGround : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private float _maxWidth = 6f;

    private SpriteRenderer _spriteRenderer;
    private Vector2 _startSize;

    private void Start()
    {
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _startSize = _spriteRenderer.size;
    }

    private void Update()
    {
        // Grow ground width over time
        _spriteRenderer.size = new Vector2(_spriteRenderer.size.x + speed * Time.deltaTime, _spriteRenderer.size.y);

        // Reset when reaching max width
        if (_spriteRenderer.size.x > _maxWidth)
        {
            _spriteRenderer.size = _startSize;
        }
    }
}
