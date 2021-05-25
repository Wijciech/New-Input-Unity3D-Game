using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Interaction : MonoBehaviour, IInteractable
{
    private PlayerInputs _inputs;
    public PlayerController _playerController;
    private bool _isInteracting;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);

        _inputs = new PlayerInputs();
        _inputs.Interaction.Interaction.performed += x => Interact();
    }
    private void OnEnable()
    {
        _inputs.Enable();
    }
    private void OnDisable()
    {
        _inputs.Disable();
    }
    public void Interact()
    {
        if (_isInteracting == false && _playerController.RangeCheck())
        {
            _isInteracting = true;
            SceneManager.LoadScene(1);
        }
        else if(_isInteracting)
        {
            StopInteract();
        }
    }
    public void StopInteract()
    {
        _isInteracting = false;
        SceneManager.LoadScene(0);
        Destroy(this.gameObject);
    }
}
