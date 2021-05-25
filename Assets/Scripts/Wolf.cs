using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wolf : MonoBehaviour
{
    private int _score, _lives = 3, _selectedWolf = 0;
    private UIManager _uiManager;
    private PlayerInputs _inputs;

    [SerializeField]
    private GameObject[] _wolf;

    void Awake()
    {
        _uiManager = GameObject.Find("UIManager").GetComponent<UIManager>();
        _inputs = new PlayerInputs();

        _inputs.MiniGame.Q.performed += x => MoveUpLeft();
        _inputs.MiniGame.A.performed += x => MoveDownLeft();
        _inputs.MiniGame.W.performed += x => MoveUpRight();
        _inputs.MiniGame.S.performed += x => MoveDownRight();
    }

    private void OnEnable()
    {
        _inputs.Enable();
    }

    private void OnDisable()
    {
        _inputs.Disable();
    }

    void Update()
    {
        UpdateWolfPosition();
    }

    public void AddScore(int points)
    {
        _score += points;
        _uiManager.UpdateScore(_score);
    }

    public void Removelives()
    {
        _lives--;
        _uiManager.UpdateLives(_lives);
    }

    private int MoveUpLeft()
    {
       return _selectedWolf = 0;
    }
    private int MoveDownLeft()
    {
       return _selectedWolf = 1;
    }
    private int MoveUpRight()
    {
       return _selectedWolf = 2;
    }
    private int MoveDownRight()
    {
       return _selectedWolf = 3;
    }

    private void UpdateWolfPosition()
    {
        for (int i = 0; i < _wolf.Length; i++)
        {
            if (i == _selectedWolf)
            {
                _wolf[i].gameObject.SetActive(true);
            }else
            {
                _wolf[i].gameObject.SetActive(false);
            }
        }
    }
}
