using UnityEngine;
using UnityEngine.AI;
public class EnemyAI : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _enemy;
    [SerializeField] private GameObject _player;
    [SerializeField] private Animator _enemyAnim;
    [SerializeField] private GameObject _goodCube;
    private bool _isTaked = false;
    private void Update()
    {
        if (_enemy.remainingDistance <= 1.5f && _enemy.remainingDistance != Mathf.Infinity && _enemy.remainingDistance != 0f && _isTaked == false)
        {
            _enemy.isStopped = true;
            _enemyAnim.SetBool("IsHolding", true);
            _goodCube.SetActive(true);
            _isTaked = true;

        }
        else
            _enemy.SetDestination(_player.transform.position);
    }
}