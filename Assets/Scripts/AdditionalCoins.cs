using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AdditionalCoins : MonoBehaviour
{
    [SerializeField] private Button _scoreButton;
    [SerializeField] private GameManager _gameManagerScript;
    [SerializeField] private int _additiionalCoinCount;
    [SerializeField] private TMP_Text _adittionalCoinText;
    private int _noInput = 0;

    // Start is called before the first frame update
    void Start()
    {
        _scoreButton.onClick.AddListener(AddScore);
    }

    // Update is called once per frame
    void Update()
    {
        bool _success = int.TryParse(_adittionalCoinText.text, out _noInput);
        if (_success == true)
        {
            _additiionalCoinCount = int.Parse(_adittionalCoinText.text);
        }
    }

    public void AddScore()
    {
        _gameManagerScript.AddScore(_additiionalCoinCount);
        _gameManagerScript.AddAdditionalCoinScore(_additiionalCoinCount);
    }
}
