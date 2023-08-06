using UnityEngine;
using UnityEngine.SceneManagement;
public class TriggerWin : MonoBehaviour
{
    [SerializeField] private Collider _player;
    private void OnTriggerEnter(Collider other)
    {
        if (other == _player) SceneManager.LoadScene("WinScene");
    }
}
