using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class EventCardDisplay : MonoBehaviour
{
    [Header("Scripts")]
    public EventCard_Info _eventCardInfo;
    public GameManager _gameManagerScript;
    [Header("Display UI")]
    public TMP_Text _name;
    //public TMP_Text _description;
    //public TMP_Text _description2;
    public TMP_Text _pointDisplay;
    [Header("Score Tracker")]
    private GameObject _gameManager;
    public int _cardPointValue;
    public int _cardPointValue2;
    [Header("Input")]
    [SerializeField] private bool _requiresInput;
    [SerializeField] TMP_Text _scaleText;
    public GameObject _scale;
    [SerializeField] TMP_Text _scaleText2;
    public GameObject _scale2; // For Under New Mamagement 
    private int _noInput = 0;
    [SerializeField] private Button _scoreButton;

    void Awake()
    {
        if (_requiresInput) _scale.SetActive(true);
        ScoreButton();
        _gameManager = GameObject.FindGameObjectWithTag("GameManager");
        _gameManagerScript = _gameManager.GetComponent<GameManager>();
        _cardPointValue = _eventCardInfo._pointValue;
        gameObject.tag = "Special Event";
        CardDisplayEventText();
    }

    private void ScoreButton()
    {
        _scoreButton = GameObject.FindGameObjectWithTag("Score Button").GetComponentInChildren<Button>();
        _scoreButton.onClick.AddListener(AddScore);
    }

    private void AddScore()
    {
        if(_name.text == "Flying Doctor Service")
        {
            _gameManagerScript.AddScore(3 * _gameManagerScript._husbandWifePairCount);
            _gameManagerScript.AddSpecialEventScore(3 * _gameManagerScript._husbandWifePairCount);
            _gameManagerScript.AddEventScore(3 * _gameManagerScript._husbandWifePairCount);
        }
        else if(_name.text == "Under New Management")
        {
            bool _success = int.TryParse(_scaleText.text, out _noInput);
            if (_success == true)
            {
                _cardPointValue = int.Parse(_scaleText.text);
            }

            bool _success2 = int.TryParse(_scaleText2.text, out _noInput);
            if (_success == true)
            {
                _cardPointValue2 = int.Parse(_scaleText2.text);
            }
            if(_cardPointValue + _cardPointValue2 < 4)
            {
                _gameManagerScript.AddScore((_cardPointValue * 1) + (_cardPointValue2 * 2));
                _gameManagerScript.AddSpecialEventScore((_cardPointValue * 1) + (_cardPointValue2 * 2));
                _gameManagerScript.AddEventScore((_cardPointValue * 1) + (_cardPointValue2 * 2));
            }
            else
            {
                Debug.Log("Under New Management Error");
            }
        }
        else if(_name.text == "Remembering the Fallen") 
        {
            InputParse();
            if(_cardPointValue > 2)
            {
                _gameManagerScript.AddScore(6);
                _gameManagerScript.AddSpecialEventScore(6);
                _gameManagerScript.AddEventScore(6);
            }
            else
            {
                _gameManagerScript.AddScore(_cardPointValue * 3);
                _gameManagerScript.AddSpecialEventScore(_cardPointValue * 3);
                _gameManagerScript.AddEventScore(_cardPointValue * 3);
            }
        }
        else if (_name.text == "Capture of the Acorn Thieves")
        {
            InputParse();
            if (_cardPointValue > 2) _cardPointValue = 2;
            _gameManagerScript.AddScore(_cardPointValue * 3);
            _gameManagerScript.AddSpecialEventScore(_cardPointValue * 3);
            _gameManagerScript.AddEventScore(_cardPointValue * 3);
        }
        else if (_name.text == "Graduation of Scholars")
        {
            InputParse();
            if (_cardPointValue > 3) _cardPointValue = 3;
            _gameManagerScript.AddScore(_cardPointValue * 2);
            _gameManagerScript.AddSpecialEventScore(_cardPointValue * 2);
            _gameManagerScript.AddEventScore(_cardPointValue * 2);
        }
        else if (_name.text == "Ancient Scrolls Discovered")
        {
            InputParse();
            if (_cardPointValue > 5) _cardPointValue = 5;
            _gameManagerScript.AddScore(_cardPointValue);
            _gameManagerScript.AddSpecialEventScore(_cardPointValue);
            _gameManagerScript.AddEventScore(_cardPointValue);
        }
        else if (_name.text == "Ministering to Miscreants") // needs limit
        {
            InputParse();
            if (_cardPointValue > 2) _cardPointValue = 2;
            _gameManagerScript.AddScore(_cardPointValue * 3);
            _gameManagerScript.AddSpecialEventScore(_cardPointValue * 3);
            _gameManagerScript.AddEventScore(_cardPointValue * 3);
        }
        else if (_name.text == "Path of Pilgrims") //needs limit, 2?, also update text
        {
            InputParse();
            if (_cardPointValue > 2) _cardPointValue = 2;
            _gameManagerScript.AddScore(_cardPointValue * 3);
            _gameManagerScript.AddSpecialEventScore(_cardPointValue * 3);
            _gameManagerScript.AddEventScore(_cardPointValue * 3);
        }
        else if (_name.text == "Performer in Residence")
        {
            InputParse();
            if (_cardPointValue > 3) _cardPointValue = 3;
            _gameManagerScript.AddScore(_cardPointValue * 2);
            _gameManagerScript.AddSpecialEventScore(_cardPointValue * 2);
            _gameManagerScript.AddEventScore(_cardPointValue * 2);
        }
        else if (_name.text == "An Evening of Fireworks")
        {
            InputParse();
            if (_cardPointValue > 3) _cardPointValue = 3;
            _gameManagerScript.AddScore(_cardPointValue * 2);
            _gameManagerScript.AddSpecialEventScore(_cardPointValue * 2);
            _gameManagerScript.AddEventScore(_cardPointValue * 2);
        }
        else if(_name.text == "A Brilliant Marketing Plan")
        {
            InputParse();
            if (_cardPointValue > 6) _cardPointValue = 6;
            _gameManagerScript.AddScore(_cardPointValue);
            _gameManagerScript.AddSpecialEventScore(_cardPointValue);
            _gameManagerScript.AddEventScore(_cardPointValue);
        }
        else
        {
            _gameManagerScript.AddScore(_cardPointValue);
            _gameManagerScript.AddSpecialEventScore(_cardPointValue);
            _gameManagerScript.AddEventScore(_cardPointValue);
        }
    }

    private void InputParse()
    {
        bool _success = int.TryParse(_scaleText.text, out _noInput);
        if (_success == true)
        {
            _cardPointValue = int.Parse(_scaleText.text);
        }
    }

    private void InputParse2()
    {
        bool _success = int.TryParse(_scaleText2.text, out _noInput);
        if (_success == true)
        {
            _cardPointValue = int.Parse(_scaleText2.text);
        }
    }


    private void CardDisplayEventText()
    {
        _name.text = _eventCardInfo._name;
        //_description.text = _eventCardInfo._description;
        //_description2.text = _eventCardInfo._description2;
        _pointDisplay.text = _eventCardInfo._pointDisplay;
    }
}
