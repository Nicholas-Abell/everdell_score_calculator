using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class DropDownList : MonoBehaviour
{
    public TMP_Dropdown _dropdown;
    public List<GameObject> _cardList;
    private Transform _cardSpawnPos;
    public GameObject _cardSpawn;
    public bool _isActive = true;
    [SerializeField] private int _yOffset;
    private List<TMP_Dropdown.OptionData> _dropDownOptions;
    private void Awake()
    {
        _cardSpawnPos = this.gameObject.transform;
        _yOffset = 0;
        _dropDownOptions = this._dropdown.options;
    } 

    private void Update()
    {
        Hide();
        CardSelect();
    }

    private void CardSelect()
    {
        switch (_dropdown.value)
        {
            case 0:
                _dropdown.value = 0;
                break;
            case 1:
                _dropdown.value = 1;
                Instantiate(_cardList[1], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[1].name);
                break;
            case 2:
                _dropdown.value = 2;
                Instantiate(_cardList[2], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[2].name);
                break;
            case 3:
                _dropdown.value = 3;
                Instantiate(_cardList[3], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[3].name);
                break;
            case 4:
                _dropdown.value = 4;
                Instantiate(_cardList[4], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[4].name);
                break;
            case 5:
                _dropdown.value = 5;
                Instantiate(_cardList[5], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[5].name);
                break;
            case 6:
                _dropdown.value = 6;
                Instantiate(_cardList[6], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[6].name);
                break;
            case 7:
                _dropdown.value = 7;
                Instantiate(_cardList[7], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[7].name);
                break;
            case 8:
                _dropdown.value = 8;
                Instantiate(_cardList[8], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[8].name);
                break;
            case 9:
                _dropdown.value = 9;
                Instantiate(_cardList[9], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[9].name);
                break;
            case 10:
                _dropdown.value = 10;
                Instantiate(_cardList[10], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[10].name);
                break;
            case 11:
                _dropdown.value = 11;
                Instantiate(_cardList[11], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[11].name);
                break;
            case 12:
                _dropdown.value = 12;
                Instantiate(_cardList[12], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[12].name);
                break;
            case 13:
                _dropdown.value = 13;
                Instantiate(_cardList[13], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[13].name);
                break;
            case 14:
                _dropdown.value = 14;
                Instantiate(_cardList[14], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[14].name);
                break;
            case 15:
                _dropdown.value = 15;
                Instantiate(_cardList[15], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[15].name);
                break;
            case 16:
                _dropdown.value = 16;
                Instantiate(_cardList[16], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[16].name);
                break;
            case 17:
                _dropdown.value = 17;
                Instantiate(_cardList[17], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[17].name);
                break;
            case 18:
                _dropdown.value = 18;
                Instantiate(_cardList[18], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[18].name);
                break;
            case 19:
                _dropdown.value = 19;
                Instantiate(_cardList[19], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[19].name);
                break;
            case 20:
                _dropdown.value = 20;
                Instantiate(_cardList[20], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[20].name);
                break;
            case 21:
                _dropdown.value = 21;
                Instantiate(_cardList[21], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[21].name);
                break;
            case 22:
                _dropdown.value = 22;
                Instantiate(_cardList[22], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[22].name);
                break;
            case 23:
                _dropdown.value = 23;
                Instantiate(_cardList[23], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[23].name);
                break;
            case 24:
                _dropdown.value = 24;
                Instantiate(_cardList[24], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[24].name);
                break;
            case 25:
                _dropdown.value = 25;
                Instantiate(_cardList[25], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[25].name);
                break;
            case 26:
                _dropdown.value = 26;
                Instantiate(_cardList[26], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[26].name);
                break;
            case 27:
                _dropdown.value = 27;
                Instantiate(_cardList[27], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[27].name);
                break;
            case 28:
                _dropdown.value = 28;
                Instantiate(_cardList[28], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[28].name);
                break;
            case 29:
                _dropdown.value = 29;
                Instantiate(_cardList[29], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[29].name);
                break;
            case 30:
                _dropdown.value = 30;
                Instantiate(_cardList[30], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[30].name);
                break;
            case 31:
                _dropdown.value = 31;
                Instantiate(_cardList[31], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[31].name);
                break;
            case 32:
                _dropdown.value = 32;
                Instantiate(_cardList[32], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[32].name);
                break;
            case 33:
                _dropdown.value = 33;
                Instantiate(_cardList[33], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[33].name);
                break;
            case 34:
                _dropdown.value = 34;
                Instantiate(_cardList[34], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[34].name);
                break;
            case 35:
                _dropdown.value = 35;
                Instantiate(_cardList[35], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[35].name);
                break;
            case 36:
                _dropdown.value = 36;
                Instantiate(_cardList[36], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[36].name);
                break;
            case 37:
                _dropdown.value = 37;
                Instantiate(_cardList[37], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[37].name);
                break;
            case 38:
                _dropdown.value = 38;
                Instantiate(_cardList[38], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[38].name);
                break;
            case 39:
                _dropdown.value = 39;
                Instantiate(_cardList[39], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[39].name);
                break;
            case 40:
                _dropdown.value = 40;
                Instantiate(_cardList[40], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[40].name);
                break;
            case 41:
                _dropdown.value = 41;
                Instantiate(_cardList[41], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[41].name);
                break;
            case 42:
                _dropdown.value = 42;
                Instantiate(_cardList[42], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[42].name);
                break;
            case 43:
                _dropdown.value = 43;
                Instantiate(_cardList[43], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[43].name);
                break;
            case 44:
                _dropdown.value = 44;
                Instantiate(_cardList[44], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[44].name);
                break;
            case 45:
                _dropdown.value = 45;
                Instantiate(_cardList[45], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[45].name);
                break;
            case 46:
                _dropdown.value = 46;
                Instantiate(_cardList[46], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[46].name);
                break;
            case 47:
                _dropdown.value = 47;
                Instantiate(_cardList[47], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[47].name);
                break;
            case 48:
                _dropdown.value = 48;
                Instantiate(_cardList[48], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[48].name);
                break;
            case 49:
                _dropdown.value = 49;
                Instantiate(_cardList[49], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[49].name);
                break;
            case 50:
                _dropdown.value = 50;
                Instantiate(_cardList[50], new Vector3(_cardSpawnPos.position.x, _cardSpawnPos.position.y - _yOffset, _cardSpawnPos.position.z), Quaternion.identity, _cardSpawn.transform.parent);
                Debug.Log(_cardList[50].name);
                break;
        }
    }

    private void Hide()
    {
        if (_dropdown.value > 0)
        {
            _isActive = false;
        }
        if (_isActive == false)
        {
            Destroy(this.gameObject);
        }
    }
}
