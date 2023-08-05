using UnityEngine;
using UnityEngine.AI;
public class EnemyAI : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _enemy;
    [SerializeField] private GameObject _player;
    private void Update() => _enemy.SetDestination(_player.transform.position);
}