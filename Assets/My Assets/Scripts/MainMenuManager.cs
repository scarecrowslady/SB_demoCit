using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

#if UNITY_EDITOR
using UnityEditor;
#endif

public class MainMenuManager : MonoBehaviour
{
    //starting new game
    public bool isColorSelected;
    public bool isDifficultySelected;
    public bool isPlayerNameSelected;
    public bool isPlayerBackgroundChosen;

    //input button
    public Button btnClick;
    public TMP_InputField inputPlayerName;
    public string inputPlayerNameText;

    //time management
    public int secondsLeft;

    //main menu highscore info
    public TMP_Text lastPlayerName;
    public TMP_Text lastPlayerScore;
    public string lastPlayerNameVar;
    public float lastPlayerScoreVar;

    public TMP_Text bestPlayerName;
    public TMP_Text bestPlayerScore;
    public string bestPlayerNameVar;
    public float bestPlayerScoreVar;

    [SerializeField] HighscoreHandler highscoreHandler;

    //missing info from starting new game
    public GameObject errorCanvasAlert;

    //load button
    public Button loadButton;

    //handling game states
    public bool isGameSaved;
    public bool isGameJustEnded;

    // Start is called before the first frame update
    void Start()
    {
        isColorSelected = false;
        isDifficultySelected = false;
        isPlayerNameSelected = false;
        isPlayerBackgroundChosen = false;

        //attach button event
        btnClick.onClick.AddListener(GetInputOnClickHandler);

        loadButton.enabled = true;

        //handling high score
        SetCurrentBestPlayer();

        //managing game states
        isGameSaved = MainManager.Instance.IsGameSaved;
        isGameJustEnded = MainManager.Instance.IsGameJustEnded;
    }

    public void DisableLoadButton()
    {
        loadButton.enabled = false;
    }
    public void EnableLoadButton()
    {
        loadButton.enabled = true;
    }

    #region Inputting New Game Info
    public void SetColor(Color playerColor)
    {
        MainManager.Instance.PlayerColor = playerColor;

        isColorSelected = true;
    }

    public void SetDifficulty(string input)
    {
        MainManager.Instance.DifficultyLevel = input;

        isDifficultySelected = true;
    }

    public void ChooseBackground(string bkgrdInput)
    {
        MainManager.Instance.PlayerBackground = bkgrdInput;

        isPlayerBackgroundChosen = true;
    }

    public void SetPlayerName(string inputName)
    {
        inputPlayerNameText = inputPlayerName.text;
        MainManager.Instance.PlayerName = inputPlayerNameText;

        isPlayerNameSelected = true;
    }

    public void LimitCharacter()
    {
        inputPlayerName.characterLimit = 10;
    }

    public void GetInputOnClickHandler()
    {
        if (!string.IsNullOrEmpty(inputPlayerNameText))
        {
            isPlayerNameSelected = true;
        }
        else
        {
            isPlayerNameSelected = true;
        }
    }
    #endregion

    #region Dealing With Main Menu HiScore Stuff
    public void SetCurrentBestPlayer()
    {
        lastPlayerNameVar = MainManager.Instance.lastPlayerName;
        lastPlayerScoreVar = MainManager.Instance.lastPlayerScore;

        lastPlayerName.text = lastPlayerNameVar;
        lastPlayerScore.text = lastPlayerScoreVar + "";

        bestPlayerNameVar = MainManager.Instance.bestPlayerName;
        bestPlayerScoreVar = MainManager.Instance.bestPlayerScore;

        bestPlayerName.text = bestPlayerNameVar;
        bestPlayerScore.text = bestPlayerScoreVar + "";

        MainManager.Instance.SaveInfo();
    }
    public void TriggerHiScoreTabulation()
    {
        if (isGameJustEnded == true)
        {
            highscoreHandler.AddHighscoreIfPossible(new HighscoreElement(MainManager.Instance.lastPlayerName, MainManager.Instance.lastPlayerScore));

            isGameJustEnded = false;
            MainManager.Instance.IsGameJustEnded = isGameJustEnded;

            MainManager.Instance.SaveInfo();
        }
    }
    #endregion

    #region Starting A New Game
    public void StartGame()
    {
        if(isColorSelected == true && isDifficultySelected == true && isPlayerBackgroundChosen == true && isPlayerNameSelected == true)
        {
            MainManager.Instance.levelNumber = 1;
            MainManager.Instance.levelName = "The Space Lane";

            MainManager.Instance.IsGameSaved = false;
            isGameJustEnded = false;
            MainManager.Instance.IsGameJustEnded = isGameJustEnded;

            if (MainManager.Instance.DifficultyLevel == "easy")
            {
                MainManager.Instance.PlayerHealth = 50;
                MainManager.Instance.PlayerMaxHealth = 50;

                MainManager.Instance.xeronRlshpMaxScore = 30;
                MainManager.Instance.pheninRlshpMaxScore = 30;

                MainManager.Instance.MoneySaved = 50;

                MainManager.Instance.scavengingRate = 3;
                MainManager.Instance.InvBulletCount = 0;

                MainManager.Instance.dayCountAmt = 30;
                MainManager.Instance.debtLevelAmt = 5000f;

                secondsLeft = 60;
                MainManager.Instance.timeTaken = secondsLeft;
            }
            if (MainManager.Instance.DifficultyLevel == "medium")
            {
                MainManager.Instance.PlayerHealth = 40;
                MainManager.Instance.PlayerMaxHealth = 40;

                MainManager.Instance.xeronRlshpMaxScore = 50;
                MainManager.Instance.pheninRlshpMaxScore = 50;

                MainManager.Instance.MoneySaved = 40;

                MainManager.Instance.scavengingRate = 2;
                MainManager.Instance.InvBulletCount = 100;

                MainManager.Instance.dayCountAmt = 20;
                MainManager.Instance.debtLevelAmt = 10000f;

                secondsLeft = 60;
                MainManager.Instance.timeTaken = secondsLeft;
            }
            if (MainManager.Instance.DifficultyLevel == "hard")
            {
                MainManager.Instance.PlayerHealth = 30;
                MainManager.Instance.PlayerMaxHealth = 30;

                MainManager.Instance.xeronRlshpMaxScore = 75;
                MainManager.Instance.pheninRlshpMaxScore = 75;

                MainManager.Instance.MoneySaved = 30;

                MainManager.Instance.scavengingRate = 1;
                MainManager.Instance.InvBulletCount = 50;

                MainManager.Instance.dayCountAmt = 20;
                MainManager.Instance.debtLevelAmt = 15000f;

                secondsLeft = 50;
                MainManager.Instance.timeTaken = secondsLeft;
            }

            MainManager.Instance.PlayerHiScore = 0;

            MainManager.Instance.currentDayCount = 0;

            MainManager.Instance.crimeRating = 0;

            MainManager.Instance.pheninRlshpScore = 0;
            MainManager.Instance.xeronRlshpScore = 0;
            MainManager.Instance.pheninSecretsAmt = 0;
            MainManager.Instance.xeronSecretsAmt = 0;

            MainManager.Instance.hasXeronColors = false;
            MainManager.Instance.hasPheninColors = false;
            MainManager.Instance.hasturnedonPheninColors = false;
            MainManager.Instance.hasturnedonXeronColors = false;

            MainManager.Instance.InvRockCount = 0;
            MainManager.Instance.InvDebrisCount = 0;
            MainManager.Instance.InvBountyCount = 0;

            MainManager.Instance.planetaryPenetrationRate = 0;

            MainManager.Instance.hasShieldsOne = false;
            MainManager.Instance.hasShieldsTwo = false;
            MainManager.Instance.hasShieldsThree = false;
            MainManager.Instance.hasShieldsFour = false;

            MainManager.Instance.hasPlanetOne = false;
            MainManager.Instance.hasPlanetTwo = false;

            MainManager.Instance.hasScavengingRateOne = false;
            MainManager.Instance.hasScavengingRateTwo = false;
            MainManager.Instance.hasScavengingRateThree = false;
            MainManager.Instance.hasScavengingRateFour = false;

            MainManager.Instance.isLevelTwoOpen = false;
            MainManager.Instance.isLevelThreeOpen = false;
            MainManager.Instance.isLevelFourOpen = false;
            MainManager.Instance.isLevelFiveOpen = false;
            MainManager.Instance.isLevelSixOpen = false;
            MainManager.Instance.isLevelSevenOpen = false;
            MainManager.Instance.isLevelEightOpen = false;
            MainManager.Instance.isLevelNineOpen = false;
            MainManager.Instance.isLevelTenOpen = false;

            MainManager.Instance.enteringLevelOne = true;
            MainManager.Instance.enteringLevelTwo = false;
            MainManager.Instance.enteringLevelThree = false;
            MainManager.Instance.enteringLevelFour = false;
            MainManager.Instance.enteringLevelFive = false;
            MainManager.Instance.enteringLevelSix = false;
            MainManager.Instance.enteringLevelSeven = false;
            MainManager.Instance.enteringLevelEight = false;
            MainManager.Instance.enteringLevelNine = false;
            MainManager.Instance.enteringLevelTen = false;

            MainManager.Instance.timeTaken = secondsLeft;

            SceneManager.LoadScene("Game");
        }
        else
        {
            errorCanvasAlert.gameObject.SetActive(true);

            Debug.Log("you're missing something");
        }
    }
    #endregion

    #region Loading A Game

    public void TriggerLoadedGame()
    {
        if (MainManager.Instance.IsGameSaved == false)
        {
            Debug.Log("there is no saved game");
        }
        else
        {
            LoadGame();
        }
    }
    #endregion

    #region Managing Scenes
    
    public void GoToHighScores()
    {
        SceneManager.LoadScene("High Score");
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Game");
    }

    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }

    #endregion
}
