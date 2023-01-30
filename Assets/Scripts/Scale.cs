using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Scale : MonoBehaviour
{
    [SerializeField] private TMP_Text _countText;
    [SerializeField] private int _count = 0;

    // Update is called once per frame
    void Update()
    {
        _countText.text = _count.ToString();
    }

    public void OnClickAdd()
    {
        if(_count < 99) _count++;
    }

    public void OnClickSubtract()
    {
        if(_count > 0) _count--;
    }
}
