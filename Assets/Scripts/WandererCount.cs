using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class WandererCount : MonoBehaviour
{
    [SerializeField] private GameManager _gamemaManagerScript;
    [SerializeField] private GameObject _wandererCard;

    void Update()
    {
        if(_gamemaManagerScript._wandererCount > 0)
        {
            _wandererCard.SetActive(true);
        }
        else
        {
            _wandererCard.SetActive(false);
        }
    }


}
