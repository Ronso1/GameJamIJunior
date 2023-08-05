using UnityEngine;
public class TriggerWin : MonoBehaviour
{
    [SerializeField] private Collider _player;
    private void OnTriggerEnter(Collider other)
    {
        if (other == _player) print("You win!");
    }
}
