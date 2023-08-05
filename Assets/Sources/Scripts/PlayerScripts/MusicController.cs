using UnityEngine;
public class MusicController : MonoBehaviour
{
    [SerializeField] private AudioSource _playerSource;
    [SerializeField] private AudioClip _walking;
    private bool _musicChecker = false;
    private void Update()
    {
        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.S) && !Input.GetKey(KeyCode.D)) _musicChecker = false;
        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D)) && _musicChecker == false)
        {
            _playerSource.enabled = true;
            _playerSource.Play();
            _musicChecker = true;
        }
        else if (_musicChecker == false) _playerSource.enabled = false;
    }
}
