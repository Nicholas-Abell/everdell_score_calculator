using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Card")]
public class Card_Info : ScriptableObject
{
    [Header("Card Visuals")]
    public string _name;
    public string _description;
    public string _buildingPairing;
    public string _amberCost;
    public string _stoneCost;
    public string _woodCost;
    public string _berryCost;
    public string _critterPairing;
    public Sprite _artwork;
    public string _pointsDisplay;
    [Header("Point Value")]
    public int _pointValue;
    [Header("Card City Limits")]
    public bool _isCommon;
    public bool _isUnique;
    public bool _isCritter;
    public bool _isContruction;
    [Header("Card Type")]
    public bool _tanTraveler;
    public bool _greenProductive;
    public bool _redDestination;
    public bool _blueGovernance;
    public bool _purpleProsperity;
}

