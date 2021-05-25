using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] 
    private Text _scoreText;
    [SerializeField] 
    private Sprite[] _livesSprites;
    [SerializeField] 
    private Image _livesImg;

    public void UpdateScore(int playerScore)
    {
        _scoreText.text = "Punkty: " + playerScore.ToString();
    }

    public void UpdateLives(int currentLives)
    {
        _livesImg.sprite = _livesSprites[currentLives];

        if (currentLives == 0)
        {
            SceneManager.LoadScene(0);
        }
    }

}
