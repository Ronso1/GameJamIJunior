using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayerMovement : MonoBehaviour
{
    private const string HorizontalAxis = "Horizontal";
    private const string VerticalAxis = "Vertical";
    [SerializeField] TMPro.TMP_Text _pointsCount;
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private Transform _root;
    [SerializeField] private GameObject _camera;
    [SerializeField] private float _speed;
    [SerializeField] private Canvas _canvas;
    [SerializeField] private GameObject _enter;
    [SerializeField] private GameObject _exit;
    public float health = 100f;
    public int points = 0;
    private float _horizontal;
    private float _vertical;
    private void Update()
    {   
        _pointsCount.text = $"Points: {points} / 2";
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
        if (points == 2)
        {
            _enter.SetActive(false);
            _exit.SetActive(false);
        }
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