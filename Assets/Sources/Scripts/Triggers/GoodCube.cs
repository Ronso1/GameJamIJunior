using UnityEngine;
public class GoodCube : MonoBehaviour
{
    [SerializeField] private GameObject _enemy;
    public PlayerMovement playerPoints;
    private void OnTriggerEnter(Collider other)
    {
        playerPoints.points++;
        Destroy(_enemy);
        Destroy(transform.gameObject);
    }
}