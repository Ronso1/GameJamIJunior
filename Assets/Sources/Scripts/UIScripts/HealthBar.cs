using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Image _imageBar;

    public void ChangeHealth(float playerHealth)
    {
        _imageBar.fillAmount = playerHealth / 100;
    }
}
