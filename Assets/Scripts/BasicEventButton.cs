using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class BasicEventButton : MonoBehaviour
{
    [SerializeField] private Toggle _toggle;
    [SerializeField] private GameManager _gameManagerScript;
    [SerializeField] private Button _scoreButton;

    // Start is called before the first frame update
    void Start()
    {
        _toggle.isOn = false;
        _scoreButton.onClick.AddListener(AddScore);
    }

    private void Update()
    {
        if (_toggle.isOn) this.gameObject.tag = "Basic Event";
        else this.gameObject.tag = "Inactive";
    }

    private void AddScore()
    {
        if (_toggle.isOn)
        {
            _gameManagerScript.AddScore(3); _gameManagerScript.AddEventScore(3); _gameManagerScript.AddBasicEventScore(3);
        } 
    }

}
