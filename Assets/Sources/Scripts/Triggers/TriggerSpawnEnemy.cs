using UnityEngine;
public class TriggerSpawnEnemy : MonoBehaviour
{
    [SerializeField] private GameObject _clown;
    private void OnTriggerEnter (Collider other) => _clown.SetActive(true);
}
