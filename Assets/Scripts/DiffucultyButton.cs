using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DiffucultyButton : MonoBehaviour
{
    public int difficulty;
    private Button button;
    private GameManager gameManager;
    void Start()
    {
        button = GetComponent<Button>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        button.onClick.AddListener(SetDifficulty);//butonlardan  birine onclick yapt���m zaman SetDiffuclty metodunu �a��r�yor.

        
    }

    void SetDifficulty()
	{
        gameManager.StartGame(difficulty);
        
	}
}
