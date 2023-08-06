using UnityEngine;
public class DamagePlayer : MonoBehaviour
{
    [SerializeField] private Collider _player;
    public PlayerMovement _playerHealth;
    [SerializeField] private HealthBar _healthBarPlayer;
    private void OnTriggerEnter(Collider other)
    {
        if (_player == other)
        {
            _playerHealth.health -= 5f;
            _healthBarPlayer.ChangeHealth(_playerHealth.health);
            Destroy(transform.gameObject);
        }
    }
}
