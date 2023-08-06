using UnityEngine;
public class DamagePlayer : MonoBehaviour
{
    [SerializeField] private Collider _player;
    public PlayerMovement _playerHealth;
    private void OnTriggerEnter(Collider other)
    {
        if (_player == other)
        {
            _playerHealth.health -= 5f;
            Destroy(transform.gameObject);
        }
    }
}
