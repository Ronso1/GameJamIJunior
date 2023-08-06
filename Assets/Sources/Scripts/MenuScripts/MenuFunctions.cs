using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuFunctions : MonoBehaviour
{
    [SerializeField] private GameObject _cameraPlayer;
    [SerializeField] private GameObject _menu;
    public void CloseGame() => Application.Quit();
    public void LoadGame() => SceneManager.LoadScene("GameScene");
    public void ResumeGame()
    {
        _menu.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        _cameraPlayer.GetComponent<CameraMovement>().enabled = true;
        Time.timeScale = 1;
    }
    public void ExitToMainMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("MenuScene");
    }
}
