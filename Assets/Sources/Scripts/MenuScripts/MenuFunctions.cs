using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuFunctions : MonoBehaviour
{
    public void CloseGame() => Application.Quit();
    public void LoadGame() => SceneManager.LoadScene("GameScene");
}
