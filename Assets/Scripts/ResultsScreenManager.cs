using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class ResultsScreenManager : MonoBehaviour
{
    [SerializeField] private TMP_Text _finalScoreText;
    [SerializeField] private TMP_Text _commonScoreText;
    [SerializeField] private TMP_Text _uniqueScoreText;
    [SerializeField] private TMP_Text _critterScoreText;
    [SerializeField] private TMP_Text _constructionScoreText;
    [SerializeField] private TMP_Text _basicEventScoreText;
    [SerializeField] private TMP_Text _specialEventScoreText;
    [SerializeField] private TMP_Text _scoreFromPurpleText;
    [SerializeField] private TMP_Text _baseCardScoreText;
    [SerializeField] private TMP_Text _eventScoreText;
    [SerializeField] private TMP_Text _pointTokensText;
    [SerializeField] private TMP_Text _journeyScoreText;
    [SerializeField] private GameManager _gameManagerScript;
    [SerializeField] private Button _scoreButton;

    void Update()
    {
        _finalScoreText.text = _gameManagerScript._finalScore.ToString();
        _commonScoreText.text = _gameManagerScript._scoreFromCommon.ToString();
        _uniqueScoreText.text = _gameManagerScript._scoreFromUnique.ToString();
        _critterScoreText.text = _gameManagerScript._scoreFromCritters.ToString();
        _constructionScoreText.text =_gameManagerScript._scoreFromConstruction.ToString();
        _basicEventScoreText.text = _gameManagerScript._scorefromBasicEvents.ToString(); 
        _specialEventScoreText.text = _gameManagerScript._scoreFromSpecialEvents.ToString();
        _scoreFromPurpleText.text = _gameManagerScript._scoreFromPurple.ToString();
        _baseCardScoreText.text = _gameManagerScript._baseCityScore.ToString();
        _eventScoreText.text = _gameManagerScript._scoreFromEvents.ToString();
        _pointTokensText.text = _gameManagerScript._scoreFromAdditionalCoin.ToString();
        _journeyScoreText.text = _gameManagerScript._scoreFromJourney.ToString();
    }

    public void ShowResultScreen()
    {
        this.gameObject.SetActive(true);
    }

    public void BackToMainScreen()
    {
        _gameManagerScript._finalScore = 0;
        _gameManagerScript._scoreFromCommon = 0;
        _gameManagerScript._scoreFromUnique = 0;
        _gameManagerScript._scoreFromConstruction = 0;
        _gameManagerScript._scoreFromCritters = 0;
        _gameManagerScript._scoreFromSpecialEvents = 0;
        _gameManagerScript._scorefromBasicEvents = 0;
        _gameManagerScript._scoreFromPurple = 0;
        _gameManagerScript._additionCoinsCount = 0;
        _gameManagerScript._baseCityScore = 0;
        _gameManagerScript._scoreFromAdditionalCoin = 0;
        _gameManagerScript._scoreFromJourney = 0;
        _gameManagerScript._scoreFromEvents = 0;
        this.gameObject.SetActive(false);
    }

    public void Reset()
    {
        SceneManager.LoadScene(0);
    }
}
