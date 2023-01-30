using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int _finalScore;
    public int _baseCityScore;
    public int _scoreFromCritters;
    public int _scoreFromConstruction;
    public int _scoreFromSpecialEvents;
    public int _scoreFromCommon;
    public int _scoreFromUnique;
    public int _scorefromBasicEvents;
    public int _scoreFromPurple;
    public int _scoreFromAdditionalCoin;
    public int _scoreFromJourney;
    public int _scoreFromEvents;
    [Header("Card Type Count")]
    public int _findCommonCritter;
    public int _findUniqueCritter;
    public int _findCommonConstruction;
    public int _findUniqueConstruction;
    [Header("Card Sub Type Count")]
    public int _purpleCardCount;
    //public int _redCountCard;
    //public int _blueCardCount;
    //public int _greenCardCount;
    [Header("Event Count")]
    public int _findBasicEvent;
    public int _findSpecialEvent;
    [Header("Event Card Prequisite")]
    public int _husbandWifePairCount;
    [Header("Resource Count")]
    public int _additionCoinsCount;
    [SerializeField] private TMP_Text _additionalCoinsInput;
    public int _wandererCount;
    [SerializeField] private TMP_Text _wandererInput;
    public int _woodCount;
    [SerializeField] private TMP_Text _woodInput;
    public int _berryCount;
    [SerializeField] private TMP_Text _berryInput;
    public int _stoneCount;
    [SerializeField] private TMP_Text _stoneInput;
    public int _resinCount;
    [SerializeField] private TMP_Text _resinInput;
    private int _noInput = 0;
    [SerializeField] private TMP_InputField _chapelInput;
    [SerializeField] private Toggle _basicEvent1;
    [SerializeField] private Toggle _basicEvent2;
    [SerializeField] private Toggle _basicEvent3;
    [SerializeField] private Toggle _basicEvent4;

    private void Update()
    {
        CardTypeCount();
        InputCheck();
    }

    public void AddScore(int _cardPointValue)
    {
        _finalScore += _cardPointValue;
    }

    public void AddBaseCityScore(int _baseCardValue)
    {
        _baseCityScore += _baseCardValue;
    }

    public void AddCritterScore(int _critterPointValue)
    {
        _scoreFromCritters += _critterPointValue;
    }

    public void AddConstructionScore(int _constructionPointValue)
    {
        _scoreFromConstruction += _constructionPointValue;
    }

    public void AddSpecialEventScore(int _specialEventPointValue)
    {
        _scoreFromSpecialEvents += _specialEventPointValue;
    }

    public void AddCommonScore(int _commonCardValue)
    {
        _scoreFromCommon += _commonCardValue;
    }

    public void AddUniqueScore(int _uniqueCardValue)
    {
        _scoreFromUnique += _uniqueCardValue;
    }

    public void AddBasicEventScore(int _basicEventValue)
    {
        _scorefromBasicEvents += _basicEventValue;
    }

    public void AddPurpleScore(int _purplePointValue)
    {
        _scoreFromPurple += _purplePointValue;
    }

    public void AddAdditionalCoinScore(int _additionalCoinCount)
    {
        _scoreFromAdditionalCoin += _additionalCoinCount;
    }

    public void AddJourneyScore(int _journeyScore)
    {
        _scoreFromJourney += _journeyScore;
    }

    public void AddEventScore(int _eventScore)
    {
        _scoreFromEvents += _eventScore;
    }

    private void CardTypeCount()
    {
        _findCommonCritter = GameObject.FindGameObjectsWithTag("Common Critter").Length + GameObject.FindGameObjectsWithTag("Common Purple Critter").Length + (GameObject.FindGameObjectsWithTag("HW").Length * 2);
        _findUniqueCritter = GameObject.FindGameObjectsWithTag("Unique Critter").Length + GameObject.FindGameObjectsWithTag("Unique Purple Critter").Length;
        _findCommonConstruction = GameObject.FindGameObjectsWithTag("Common Construction").Length + GameObject.FindGameObjectsWithTag("Common Purple Construction").Length;
        _findUniqueConstruction = GameObject.FindGameObjectsWithTag("Unique Construction").Length + GameObject.FindGameObjectsWithTag("Unique Purple Construction").Length;
        _purpleCardCount = GameObject.FindGameObjectsWithTag("Common Purple Critter").Length + GameObject.FindGameObjectsWithTag("Unique Purple Critter").Length + GameObject.FindGameObjectsWithTag("Common Purple Construction").Length + GameObject.FindGameObjectsWithTag("Unique Purple Construction").Length + GameObject.FindGameObjectsWithTag("HW").Length;
        _findSpecialEvent = GameObject.FindGameObjectsWithTag("Special Event").Length;
        _findBasicEvent = GameObject.FindGameObjectsWithTag("Basic Event").Length;
        _husbandWifePairCount = GameObject.FindGameObjectsWithTag("HW").Length;
    }

    private void InputCheck()
    {
        bool _success = int.TryParse(_wandererInput.text, out _noInput);
        if (_success == true)
        {
            _wandererCount = int.Parse(_wandererInput.text);
        }
        bool _additionalCoinsSuccess = int.TryParse(_additionalCoinsInput.text, out _noInput);
        if (_additionalCoinsSuccess == true)
        {
            _additionCoinsCount = int.Parse(_additionalCoinsInput.text);
        }
        bool _woodSuccess = int.TryParse(_woodInput.text, out _noInput);
        if (_woodSuccess == true)
        {
            _woodCount = int.Parse(_woodInput.text);
        }
        bool _berrySuccess = int.TryParse(_berryInput.text, out _noInput);
        if (_berrySuccess == true)
        {
            _berryCount = int.Parse(_berryInput.text);
        }
        bool _stoneSuccess = int.TryParse(_stoneInput.text, out _noInput);
        if (_stoneSuccess == true)
        {
            _stoneCount = int.Parse(_stoneInput.text);
        }
        bool _resinSuccess = int.TryParse(_resinInput.text, out _noInput);
        if (_resinSuccess == true)
        {
            _resinCount = int.Parse(_resinInput.text);
        }
    }
}
