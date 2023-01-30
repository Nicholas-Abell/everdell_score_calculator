using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using TMPro;
using UnityEngine.UIElements;

public class RemoveButton : MonoBehaviour
{
    [SerializeField] Transform _cardSpawn;
    [SerializeField] private GameObject _dropDownList;
    private Transform _spawnPos;
    [SerializeField] private GameObject _spawnPosObject;
    [SerializeField] private GameObject _children;
    private DropDownList _dropDownScript;

    /*private bool _isPressed;
    private float _pressTime;
    [SerializeField] private float _requiredTime;
    [SerializeField] private GameObject _descriptionCard;
    [SerializeField] private Card_Info _cardDisplayScript;*/

    private void Start()
    {
        _spawnPos = this.transform;
        //_requiredTime = 5f;
    }
    private void Awake()
    {
        this.transform.position = new Vector3(_cardSpawn.position.x, _cardSpawn.position.y, _cardSpawn.position.z);
    }
    private void Update()
    {
        _children = this.gameObject.transform.GetChild(2).gameObject;
        if (_children != null) _dropDownScript = _children.GetComponent<DropDownList>();
        if (_dropDownScript != null) _dropDownScript._cardSpawn = _spawnPosObject;


        /*_cardDisplayScript = this.gameObject.transform.GetComponentInChildren<Card_Info>();
        _pressTime += Time.deltaTime;
        if (_pressTime > _requiredTime && _cardDisplayScript != null)
        {
            _descriptionCard.gameObject.SetActive(true);
        }*/
    }

    public void OnClick()
    {
        Instantiate(_dropDownList, new Vector3(_spawnPos.position.x, _spawnPos.position.y, _spawnPos.position.z), Quaternion.identity, _spawnPosObject.transform.parent);
        Destroy(_children);
    }
}
