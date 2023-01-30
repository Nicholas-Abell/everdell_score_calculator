using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class JourneyCount : MonoBehaviour
{
    [SerializeField] private TMP_Text _scaleText;
    [SerializeField] private Toggle _3Toggle;
    [SerializeField] private Toggle _4Toggle;
    [SerializeField] private Toggle _5Toggle;
    [SerializeField] private GameManager _gameManagerScript;
    [SerializeField] private Button _scoreButton;
    private int _noInput = 0;
    private int _scaleInput;

    // Start is called before the first frame update
    void Start()
    {
        _scoreButton.onClick.AddListener(AddScore);
        _3Toggle.isOn = false;
        _4Toggle.isOn = false;
        _5Toggle.isOn = false;
    }

    private void AddScore()
    {
        bool _success = int.TryParse(_scaleText.text, out _noInput);
        if (_success == true)
        {
            _scaleInput = int.Parse(_scaleText.text) * 2;
            _gameManagerScript.AddScore(_scaleInput);
            _gameManagerScript.AddJourneyScore(_scaleInput);
        }

        if (_3Toggle.isOn)
        {
            _gameManagerScript.AddScore(3); _gameManagerScript.AddJourneyScore(3);
        }
        if (_4Toggle.isOn)
        {
            _gameManagerScript.AddScore(4); _gameManagerScript.AddJourneyScore(4);
        }

        if (_5Toggle.isOn)
        {
            _gameManagerScript.AddScore(5); _gameManagerScript.AddJourneyScore(5);
        } 
    }
}
