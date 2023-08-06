using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    private const string HorizontalAxis = "Horizontal";
    private const string VerticalAxis = "Vertical";
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private Transform _root;
    [SerializeField] private GameObject _camera;
    [SerializeField] private float _speed;
    [SerializeField] private Canvas _canvas;
    private float _horizontal;
    private float _vertical;
    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            GamePause();
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            _camera.GetComponent<CameraMovement>().enabled = false;
            _canvas.gameObject.SetActive(true);
        }      
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