using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private CharacterController _characterController;

    [SerializeField]
    private Camera _camera;

    [SerializeField]
    private MiniGame[] _miniGameArray;

    [SerializeField]
    private float _speed, _lookSensitivity, _cameraRotationOnX, _minimalDistance = 5f;

     private PlayerInputs _inputs;
     private PlayerInputs.PlayerMovementActions _playerMovement;

    private void Awake()
    {
        _inputs = new PlayerInputs();
        _playerMovement = _inputs.PlayerMovement;

        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
    private void OnEnable()
    {
        _inputs.Enable();
    }
    private void OnDisable()
    {
        _inputs.Disable();
    }
    private Vector2 OnMovement()
    {
        return _playerMovement.Movement.ReadValue<Vector2>();
    }
    private Vector2 OnLook()
    {
        return _playerMovement.Look.ReadValue<Vector2>();
    }
    private void PlayerMovement()
    {
        Vector3 _horizontalMovement = _camera.transform.forward * OnMovement().y + _camera.transform.right * OnMovement().x;
        _horizontalMovement.y = 0f;
        _characterController.Move(_horizontalMovement * _speed * Time.deltaTime);
    }
    private void PlayerCamera()
    {
        var lookX = OnLook().x * _lookSensitivity * Time.deltaTime;
        var lookY = OnLook().y * _lookSensitivity * Time.deltaTime;

        _cameraRotationOnX -= lookY;
        _cameraRotationOnX = Mathf.Clamp(_cameraRotationOnX, -75f, 75f);

        _camera.transform.localRotation = Quaternion.Euler(_cameraRotationOnX, 0, 0);
        transform.Rotate(Vector3.up * lookX);
    }
    public bool RangeCheck()
    {
        foreach (MiniGame miniGame in _miniGameArray)
        {
            float distToMiniGame = (miniGame.transform.position - this.transform.position).sqrMagnitude;
            if (distToMiniGame < _minimalDistance)
            {
                return true;
            }
        }
        return false;
    }
    private void FixedUpdate()
    {
        PlayerMovement();
        PlayerCamera();
        RangeCheck();
    }

}
