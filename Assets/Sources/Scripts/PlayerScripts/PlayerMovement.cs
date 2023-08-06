using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    private const string HorizontalAxis = "Horizontal";
    private const string VerticalAxis = "Vertical";
    [SerializeField] private TMPro.TMP_Text _healthText;
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private Transform _root;
    [SerializeField] private GameObject _camera;
    [SerializeField] private float _speed;
    [SerializeField] private Canvas _canvas;
    public float health = 100f;
    public int points = 0;
    private float _horizontal;
    private float _vertical;
    private void Update()
    {
        _healthText.text = $"Health: {health}";
        if (Input.GetKey(KeyCode.Escape))
        {
            GamePause();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _camera.GetComponent<CameraMovement>().enabled = false;
            _canvas.gameObject.SetActive(true);
        }
        if (health <= 0f) SceneManager.LoadScene("LoseScene");
        _horizontal = Input.GetAxis(HorizontalAxis);
        _vertical = Input.GetAxis(VerticalAxis);
    }
    private void FixedUpdate()
    {
        var moveDirection = _root.TransformDirection(new Vector3(_horizontal, 0, _vertical));
        if (Input.GetKey(KeyCode.LeftShift))
            _rigidBody.MovePosition(_rigidBody.transform.position + moveDirection * (_speed + 1f) * Time.fixedDeltaTime);
        else
            _rigidBody.MovePosition(_rigidBody.transform.position + moveDirection * _speed * Time.fixedDeltaTime);
    }
    private void GamePause() => Time.timeScale = 0f;
}