using UnityEngine;
public class PlayerMovement : MonoBehaviour
{
    private const string HorizontalAxis = "Horizontal";
    private const string VerticalAxis = "Vertical";
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private Transform _root;
    [SerializeField] private float _speed;
    private float _horizontal;
    private float _vertical;
    private void Update()
    {
        _horizontal = Input.GetAxis(HorizontalAxis);
        _vertical = Input.GetAxis(VerticalAxis);
    }
    private void FixedUpdate()
    {
        var moveDirection = _root.TransformDirection(new Vector3(_horizontal, 0, _vertical));
        _rigidBody.MovePosition(_rigidBody.transform.position + moveDirection * _speed * Time.fixedDeltaTime);
    }
}