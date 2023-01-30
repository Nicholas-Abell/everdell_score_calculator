using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class CardDisplay : MonoBehaviour
{
    [Header("Scripts")]
    public Card_Info _card_Info;
    public GameManager _gameManagerScript;
    private GameObject _gameManager;
    public WandererCount _wandererCountScript;
    [SerializeField] private ResultsScreenManager _resultsScreenManagerScript; 
    [Header("Display")]
    public TMP_Text _nameText;
    public TMP_Text __descriptonText;
    public Image _artworkImage;
    public TMP_Text _points;
    public TMP_Text _buildingPairingText;
    public TMP_Text _creaturePairingText;
    public TMP_Text _amberCostText;
    public TMP_Text _stoneCostText;
    public TMP_Text _woodCostText;
    public TMP_Text _berryCostText;
    [Header("Score Tracker")]
    public TMP_Text _scoreTrackerText;
    public int _cardPointValue;
    [Header("Input Requirements")]
    [SerializeField] private bool _requiresInput;
    [SerializeField] TMP_Text _scaleText;
    public GameObject _scale; //public for Chapel
    private int _noInput = 0;
    [SerializeField] Button _scoreButton;

    private void Awake()
    {
        _gameManager = GameObject.FindGameObjectWithTag("GameManager");
        _gameManagerScript = _gameManager.GetComponent<GameManager>();
        CardDisplayText(); //Displays UI
        CardSubTypeCheck(); //Changes tag to Common or Unique
        _cardPointValue = _card_Info._pointValue;
        ScoreButton(); 
        if (_requiresInput) _scale.SetActive(true); //Enables user input
    }

    private void ScoreButton()
    {
        _scoreButton = GameObject.FindGameObjectWithTag("Score Button").GetComponentInChildren<Button>();
        _scoreButton.onClick.AddListener(AddScore);
    }

    private void CardSubTypeCheck()
    {
        if(_card_Info._isCommon && _card_Info._isCritter)
        {
            this.gameObject.tag = "Common Critter";
        }
        if(_card_Info._isUnique && _card_Info._isCritter)
        {
            this.gameObject.tag = "Unique Critter";
        }
        if(_card_Info._isCommon && _card_Info._isContruction)
        {
            this.gameObject.tag = "Common Construction";
        }
        if (_card_Info._isUnique && _card_Info._isContruction)
        {
            this.gameObject.tag = "Unique Construction";
        }
        if(_card_Info._isCommon && _card_Info._isCritter && _card_Info._purpleProsperity)
        {
            this.gameObject.tag = "Common Purple Critter";
        }
        if (_card_Info._isUnique && _card_Info._isCritter && _card_Info._purpleProsperity)
        {
            this.gameObject.tag = "Unique Purple Critter";
        }
        if (_card_Info._isCommon && _card_Info._isContruction && _card_Info._purpleProsperity)
        {
            this.gameObject.tag = "Common Purple Construction";
        }
        if (_card_Info._isUnique && _card_Info._isContruction && _card_Info._purpleProsperity)
        {
            this.gameObject.tag = "Unique Purple Construction";
        }
        if(_card_Info._isCommon && _card_Info._purpleProsperity && _card_Info._greenProductive && _card_Info._isCritter)
        {
            this.gameObject.tag = "HW";
        }
        
    }

    public void AddScore()  //consider seperate script
    {
        if (_nameText.text == "Theater")
        {
            _gameManagerScript.AddScore(_cardPointValue + _gameManagerScript._findUniqueCritter);
            _gameManagerScript.AddPurpleScore(_gameManagerScript._findUniqueCritter);
            _gameManagerScript.AddBaseCityScore(_cardPointValue);
            _gameManagerScript.AddConstructionScore(_cardPointValue + _gameManagerScript._findUniqueCritter);
            _gameManagerScript.AddUniqueScore(_cardPointValue + _gameManagerScript._findUniqueCritter);
        }
        else if (_nameText.text == "Chapel")
        {
            bool _success = int.TryParse(_scaleText.text, out _noInput);
            if (_success == true)
            {
                GameObject _pristineChapelEvent = GameObject.Find("Pristine Chapel Ceiling(Clone)");
                if (_pristineChapelEvent != null)
                {
                    _gameManagerScript.AddScore(_cardPointValue + int.Parse(_scaleText.text) + (int.Parse(_scaleText.text) * 2));
                    _gameManagerScript.AddBaseCityScore(_cardPointValue);
                    _gameManagerScript.AddConstructionScore(_cardPointValue + int.Parse(_scaleText.text) + (int.Parse(_scaleText.text) * 2));
                    _gameManagerScript.AddUniqueScore(_cardPointValue + int.Parse(_scaleText.text) + (int.Parse(_scaleText.text) * 2));
                    _gameManagerScript.AddAdditionalCoinScore(int.Parse(_scaleText.text));
                    Debug.Log("Pristine Chapel Event Counted");
                }
                else
                {
                    _gameManagerScript.AddScore(_cardPointValue + int.Parse(_scaleText.text));
                    _gameManagerScript.AddBaseCityScore(_cardPointValue);
                    _gameManagerScript.AddAdditionalCoinScore(int.Parse(_scaleText.text));
                    _gameManagerScript.AddConstructionScore(_cardPointValue + int.Parse(_scaleText.text));
                    _gameManagerScript.AddUniqueScore(_cardPointValue + int.Parse(_scaleText.text));
                }
            }
        }
        else if (_nameText.text == "Woodcarver")
        {
            bool _success = int.TryParse(_scaleText.text, out _noInput);
            if (_success == true)
            {
                    _gameManagerScript.AddScore(_cardPointValue + int.Parse(_scaleText.text));
                    _gameManagerScript.AddBaseCityScore(_cardPointValue);
                    _gameManagerScript.AddAdditionalCoinScore(int.Parse(_scaleText.text));
                    _gameManagerScript.AddCritterScore(_cardPointValue + int.Parse(_scaleText.text));
                    _gameManagerScript.AddCommonScore(_cardPointValue + int.Parse(_scaleText.text));
            }
        }
        else if (_nameText.text == "Mayor Adkison" || _nameText.text == "Doctor" || _nameText.text == "Monk" || _nameText.text == "Shepherd")
        {
            bool _success = int.TryParse(_scaleText.text, out _noInput);
            if (_success == true)
            {   
                _gameManagerScript.AddScore(_cardPointValue + int.Parse(_scaleText.text));
                _gameManagerScript.AddBaseCityScore(_cardPointValue);
                _gameManagerScript.AddAdditionalCoinScore(int.Parse(_scaleText.text));
                _gameManagerScript.AddCritterScore(_cardPointValue + int.Parse(_scaleText.text));
                _gameManagerScript.AddUniqueScore(_cardPointValue + int.Parse(_scaleText.text));
            }
        }
        else if (_nameText.text == "Expo Hall")
        {
            bool _success = int.TryParse(_scaleText.text, out _noInput);
            if (_success == true)
            {
                _gameManagerScript.AddScore(_cardPointValue + int.Parse(_scaleText.text));
                _gameManagerScript.AddBaseCityScore(_cardPointValue);
                _gameManagerScript.AddAdditionalCoinScore(int.Parse(_scaleText.text));
                _gameManagerScript.AddConstructionScore(_cardPointValue + int.Parse(_scaleText.text));
                _gameManagerScript.AddUniqueScore(_cardPointValue + int.Parse(_scaleText.text));
            }
        }
        else if (_nameText.text == "Clock Tower") //needs testing
        {
            bool _success = int.TryParse(_scaleText.text, out _noInput);
            if (_success == true)
            {
                if (int.Parse(_scaleText.text) > 3)
                {
                    _cardPointValue = 3;
                    _gameManagerScript.AddScore(3);
                    _gameManagerScript.AddConstructionScore(3);
                    _gameManagerScript.AddUniqueScore(3);
                    _gameManagerScript.AddAdditionalCoinScore(3);
                }
                else
                {
                    _cardPointValue = int.Parse(_scaleText.text);
                    _gameManagerScript.AddScore(int.Parse(_scaleText.text));
                    _gameManagerScript.AddConstructionScore(int.Parse(_scaleText.text));
                    _gameManagerScript.AddUniqueScore(int.Parse(_scaleText.text));
                    _gameManagerScript.AddAdditionalCoinScore(int.Parse(_scaleText.text));
                }
            }
        }
        else if(_nameText.text == "Monastery")
        {
            bool _succes = int.TryParse(_scaleText.text, out _noInput);
            if(_succes == true)
            {
                _gameManagerScript.AddBaseCityScore(_cardPointValue);
                _gameManagerScript.AddAdditionalCoinScore(int.Parse(_scaleText.text));
                _gameManagerScript.AddScore(_cardPointValue + int.Parse(_scaleText.text));
                _gameManagerScript.AddConstructionScore(_cardPointValue + int.Parse(_scaleText.text));
                _gameManagerScript.AddUniqueScore(_cardPointValue + int.Parse(_scaleText.text));
            }      
        }
        else if (_nameText.text == "Bard")
        {
            bool _succes = int.TryParse(_scaleText.text, out _noInput);
            if (_succes == true)
            {
                if (int.Parse(_scaleText.text) > 5)
                {
                    _gameManagerScript.AddAdditionalCoinScore(5);
                    _gameManagerScript.AddScore(5);
                    _gameManagerScript.AddCritterScore(5);
                    _gameManagerScript.AddUniqueScore(5);
                }
                else
                {
                    _gameManagerScript.AddAdditionalCoinScore(int.Parse(_scaleText.text));
                    _gameManagerScript.AddScore(int.Parse(_scaleText.text));
                    _gameManagerScript.AddCritterScore(int.Parse(_scaleText.text));
                    _gameManagerScript.AddUniqueScore(int.Parse(_scaleText.text));
                }
            }
        }
        else if (_nameText.text == "School")
        {
            _gameManagerScript.AddScore(_cardPointValue + _gameManagerScript._findCommonCritter);
            _gameManagerScript.AddBaseCityScore(_cardPointValue);
            _gameManagerScript.AddUniqueScore(_cardPointValue + _gameManagerScript._findCommonCritter);
            _gameManagerScript.AddPurpleScore(_gameManagerScript._findCommonCritter);
            _gameManagerScript.AddConstructionScore(_cardPointValue + _gameManagerScript._findCommonCritter);
        }
        else if (_nameText.text == "Palace")
        {
            _gameManagerScript.AddScore(_cardPointValue + _gameManagerScript._findUniqueConstruction);
            _gameManagerScript.AddConstructionScore(_cardPointValue + _gameManagerScript._findUniqueConstruction);
            _gameManagerScript.AddUniqueScore(_cardPointValue + _gameManagerScript._findUniqueConstruction);
            _gameManagerScript.AddBaseCityScore(_cardPointValue);
            _gameManagerScript.AddPurpleScore(_gameManagerScript._findUniqueConstruction);
        }
        else if (_nameText.text == "Castle")
        {
            _gameManagerScript.AddScore(_cardPointValue + _gameManagerScript._findCommonConstruction);
            _gameManagerScript.AddConstructionScore(_cardPointValue + _gameManagerScript._findCommonConstruction);
            _gameManagerScript.AddUniqueScore(_cardPointValue + _gameManagerScript._findCommonConstruction);
            _gameManagerScript.AddBaseCityScore(_cardPointValue);
            _gameManagerScript.AddPurpleScore(_gameManagerScript._findCommonConstruction);
        }
        else if (_nameText.text == "Ever Tree")
        {
            _gameManagerScript.AddScore(_cardPointValue + _gameManagerScript._purpleCardCount);
            _gameManagerScript.AddConstructionScore(_cardPointValue + _gameManagerScript._purpleCardCount);
            _gameManagerScript.AddUniqueScore(_cardPointValue + _gameManagerScript._purpleCardCount);
            _gameManagerScript.AddBaseCityScore(_cardPointValue);
            _gameManagerScript.AddPurpleScore(_gameManagerScript._purpleCardCount);
        }
        else if (_nameText.text == "King")
        {
            _gameManagerScript.AddScore(_cardPointValue + (_gameManagerScript._findSpecialEvent * 2) + _gameManagerScript._findBasicEvent);
            _gameManagerScript.AddCritterScore(_cardPointValue + (_gameManagerScript._findSpecialEvent * 2) + _gameManagerScript._findBasicEvent);
            _gameManagerScript.AddUniqueScore(_cardPointValue + (_gameManagerScript._findSpecialEvent * 2) + _gameManagerScript._findBasicEvent);
            _gameManagerScript.AddBaseCityScore(_cardPointValue);
            _gameManagerScript.AddPurpleScore((_gameManagerScript._findSpecialEvent * 2) + _gameManagerScript._findBasicEvent);
        }
        else if (_nameText.text == "Architect")
        {
            if (_gameManagerScript._stoneCount + _gameManagerScript._resinCount > 6)
            {
                _gameManagerScript.AddScore(_cardPointValue + 6);
                _gameManagerScript.AddBaseCityScore(_cardPointValue);
                _gameManagerScript.AddPurpleScore(6);
                _gameManagerScript.AddCritterScore(_cardPointValue + 6);
                _gameManagerScript.AddUniqueScore(_cardPointValue + 6);
            }
            else
            {
                _gameManagerScript.AddScore(_cardPointValue + _gameManagerScript._stoneCount + _gameManagerScript._resinCount);
                _gameManagerScript.AddBaseCityScore(_cardPointValue);
                _gameManagerScript.AddPurpleScore(_gameManagerScript._stoneCount + _gameManagerScript._resinCount);
                _gameManagerScript.AddCritterScore(_cardPointValue + _gameManagerScript._stoneCount + _gameManagerScript._resinCount);
                _gameManagerScript.AddUniqueScore(_cardPointValue + _gameManagerScript._stoneCount + _gameManagerScript._resinCount);
            }
        }
        else if(_nameText.text == "Wanderer")
        {
            _gameManagerScript.AddScore(_cardPointValue * _gameManagerScript._wandererCount);
            _gameManagerScript.AddBaseCityScore(_cardPointValue * _gameManagerScript._wandererCount);
            _gameManagerScript.AddCritterScore(_cardPointValue * _gameManagerScript._wandererCount);
            _gameManagerScript.AddCommonScore(_cardPointValue * _gameManagerScript._wandererCount);
        }
        else if (_nameText.text == "Husband & Wife")
        {
            _gameManagerScript.AddScore(_cardPointValue);
            _gameManagerScript.AddBaseCityScore(4);
            _gameManagerScript.AddPurpleScore(3);
            _gameManagerScript.AddCommonScore(_cardPointValue);
            _gameManagerScript.AddCritterScore(_cardPointValue);
            Debug.Log("Husband and Wife scored");
        }
        else
        {
            _gameManagerScript.AddScore(_cardPointValue);
            _gameManagerScript.AddBaseCityScore(_cardPointValue);
            if (_card_Info._isCritter) _gameManagerScript.AddCritterScore(_cardPointValue);
            else if (_card_Info._isContruction) _gameManagerScript.AddConstructionScore(_cardPointValue);
            if (_card_Info._isCommon) _gameManagerScript.AddCommonScore(_cardPointValue);
            else if (_card_Info._isUnique) _gameManagerScript.AddUniqueScore(_cardPointValue);
        }
    }

    private void CardDisplayText()
    {
        _nameText.text = _card_Info._name;
        _points.text = _card_Info._pointsDisplay.ToString();
        //__descriptonText.text = _card_Info._description;
        /*_buildingPairingText.text = _card_Info._buildingPairing;
        _creaturePairingText.text = _card_Info._critterPairing;
        _amberCostText.text = _card_Info._amberCost;
        _stoneCostText.text = _card_Info._stoneCost;
        _woodCostText.text = _card_Info._woodCost;
        _berryCostText.text = _card_Info._berryCost;*/
    }

}
