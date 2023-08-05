using TMPro;
using UnityEngine;
public class PullCubes : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private TMP_Text _points;
    private Transform _pickupCube;
    private void Start() => _pickupCube = GetComponent<Transform>();
    private void OnTriggerEnter(Collider other)
    {
        if (other == _player.GetComponent<Collider>()) Destroy(_pickupCube.gameObject);
    }
}
