using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScaler : MonoBehaviour
{
    [SerializeField] private float _screenWidthX;
    [SerializeField] private float _screenHeightY;
    [SerializeField] CanvasScaler _canvasScaler;

    void Start()
    {
        SetInfo();
    }

    // Update is called once per frame
    void SetInfo()
    {
        _screenWidthX = (float)Screen.width;
        _screenHeightY = (float)Screen.height;

        _canvasScaler.referenceResolution = new Vector2(_screenWidthX, _screenHeightY);
    }
}
