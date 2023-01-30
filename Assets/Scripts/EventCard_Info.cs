using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Event Card")]
public class EventCard_Info : ScriptableObject
{
    [Header("Card Visuals")]
    public string _name;
    public string _description;
    public string _description2;
    public string _pointDisplay;
    [Header("Card Values")]
    public int _pointValue;
    public int _multiplier;
}

