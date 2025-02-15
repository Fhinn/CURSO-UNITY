﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class DifficultyButton : MonoBehaviour
{
    private Button _button;
    private GameManager gameManager;

    [Range(1,4)]
    public int difficulty;
    
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        
        _button = GetComponent<Button>();
        _button.onClick.AddListener(SetDifficulty);
    }

    void SetDifficulty()
    {
        Debug.Log("El botón " + gameObject.name + " ha sido pulsado.");
        gameManager.StartGame(difficulty);
    }
    
}
