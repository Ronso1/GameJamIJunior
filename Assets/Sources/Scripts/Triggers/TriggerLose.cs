using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerLose : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) => SceneManager.LoadScene("LoseScene");
}