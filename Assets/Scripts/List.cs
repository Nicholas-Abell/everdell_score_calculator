using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class List : MonoBehaviour
{
    //Makes list Spawn in center of screen
    //attach to DropDown
    [SerializeField] private GameObject _list;
    [SerializeField]private Transform _listSpawnPos;

    private void Awake()
    {
        _listSpawnPos = GameObject.Find("List Spawn").transform;//.position
    }

    private void Update()
    {
        if (this.gameObject.transform.childCount > 3)
        {
            _list = this.gameObject.transform.GetChild(3).gameObject;
        }
        if(this.gameObject.transform.childCount > 3 && _list != null) _list.transform.position = new Vector3(_listSpawnPos.position.x, _listSpawnPos.position.y, _listSpawnPos.position.z); 
    }
}
