using UnityEngine;

public class Enemy : Character
{
    [SerializeField] private int _damage = 10;

    private void Update()
    {
        EnemyBehaviour();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.TryGetComponent(out Player player))
        {
            player.TakeDamage(_damage);
            gameObject.SetActive(false);
        }
    }

    protected override void OnEnableSetting()
    {
        EnemySetting();
    }

    protected override void OnDie()
    {
        gameObject.SetActive(false);
    }

    protected virtual void EnemySetting()
    {

    }

    protected virtual void EnemyBehaviour()
    {

    }
}