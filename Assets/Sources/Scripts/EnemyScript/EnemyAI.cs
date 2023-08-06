using UnityEngine;
using UnityEngine.AI;
public class EnemyAI : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _enemy;
    [SerializeField] private GameObject _player;
    private void Update()
    {
        if (_enemy.remainingDistance <= 0.9f && _enemy.remainingDistance != Mathf.Infinity && _enemy.remainingDistance != 0f)
        {
            print(_enemy.remainingDistance);
            _enemy.isStopped = true;
        }        
        else
            _enemy.SetDestination(_player.transform.position);
    }
}