using UnityEngine;
using UnityEngine.SceneManagement;
public class LoopScenes : MonoBehaviour
{
    private void Start()
    {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
    public void WinScene() => SceneManager.LoadScene("WinScene");
    public void LoseScene() => SceneManager.LoadScene("LoseScene");
    
}
