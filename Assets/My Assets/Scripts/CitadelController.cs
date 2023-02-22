using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using UnityEngine.UI;

public class CitadelController : MonoBehaviour
{
    //important info to load
    public float levelNumber;
    public string lavelName;

    public Color playerColor;
    public string difficultyLevel;
    public string playerName;

    public float playerHealth;
    public float playerMaxHealth;
    public float moneySaved;

    public float inventoryRockCt;
    public float inventoryDebrisCt;
    public float inventoryBountyCt;

    public int secondsLeft;
    public int timerRate;

    public bool newLevelActivated;

    public GameObject gameOverPanel;
    public TMP_Text gameReturnHiScore;

    public CitadelManagement citadelManagement;

    //ending game triggers
    public float debtAmount;
    public float dueDate;
    public float currentDate;

    private void Start()
    {
        MainManager.Instance.isLevelEnded = false;

        MainManager.Instance.SaveInfo();

        debtAmount = MainManager.Instance.debtLevelAmt;
        dueDate = MainManager.Instance.dayCountAmt;
        currentDate = MainManager.Instance.currentDayCount;

        newLevelActivated = false;

        timerRate = 30;

        citadelManagement.GetComponent<CitadelManagement>();
    }

    public void Update()
    {
        if(dueDate >= currentDate && debtAmount >= 1)
        {
            MainManager.Instance.lastPlayerName = MainManager.Instance.PlayerName;
            MainManager.Instance.lastPlayerScore = MainManager.Instance.PlayerHiScore;

            if (MainManager.Instance.PlayerHiScore > MainManager.Instance.bestPlayerScore)
            {
                MainManager.Instance.bestPlayerScore = MainManager.Instance.PlayerHiScore;
                MainManager.Instance.bestPlayerName = MainManager.Instance.PlayerName;
            }

            MainManager.Instance.SaveInfo();

            GameOverScreen();
        }
    }

    public void ReturnToMenu()
    {
        MainManager.Instance.SaveInfo();

        SceneManager.LoadScene("Main");
    }

    #region Activate Levels
    public void ActivateLvlOne()
    {
        MainManager.Instance.isLevelEnded = false;

        secondsLeft = timerRate;
        MainManager.Instance.timeTaken = secondsLeft;

        levelNumber = 1;
        MainManager.Instance.levelNumber = levelNumber;

        MainManager.Instance.levelName = "The Space Lane";

        MainManager.Instance.currentDayCount += 1;

        MainManager.Instance.SaveInfo();
        SceneManager.LoadScene("Game");
    }
    public void ActivatedLvlTwo()
    {
        MainManager.Instance.isLevelEnded = false;

        secondsLeft = timerRate;
        MainManager.Instance.timeTaken = secondsLeft;

        levelNumber = 2;
        MainManager.Instance.levelNumber = levelNumber;

        MainManager.Instance.levelName = "Terras I";

        MainManager.Instance.currentDayCount += 1;

        MainManager.Instance.SaveInfo();
        SceneManager.LoadScene("Game");
    }
    public void ActivatedLvlThree()
    {
        MainManager.Instance.isLevelEnded = false;

        secondsLeft = timerRate;
        MainManager.Instance.timeTaken = secondsLeft;

        levelNumber = 3;
        MainManager.Instance.levelNumber = levelNumber;

        MainManager.Instance.levelName = "Korra'ath Zone";

        MainManager.Instance.currentDayCount += 1;

        MainManager.Instance.SaveInfo();
        SceneManager.LoadScene("Game");
    }
    public void ActivatedLvlFour()
    {
        MainManager.Instance.isLevelEnded = false;

        secondsLeft = timerRate;
        MainManager.Instance.timeTaken = secondsLeft;

        levelNumber = 4;
        MainManager.Instance.levelNumber = levelNumber;

        MainManager.Instance.levelName = "The Orion Gate";

        MainManager.Instance.currentDayCount += 1;

        MainManager.Instance.SaveInfo();
        SceneManager.LoadScene("Game");
    }
    public void ActivatedLvlFive()
    {
        MainManager.Instance.isLevelEnded = false;

        secondsLeft = timerRate;
        MainManager.Instance.timeTaken = secondsLeft;

        levelNumber = 5;
        MainManager.Instance.levelNumber = levelNumber;

        MainManager.Instance.levelName = "Rigel";

        MainManager.Instance.currentDayCount += 1;

        MainManager.Instance.SaveInfo();
        SceneManager.LoadScene("Game");
    }
    public void ActivatedLvlSix()
    {
        MainManager.Instance.isLevelEnded = false;

        secondsLeft = timerRate;
        MainManager.Instance.timeTaken = secondsLeft;

        levelNumber = 6;
        MainManager.Instance.levelNumber = levelNumber;

        MainManager.Instance.levelName = "Allendome Field";

        MainManager.Instance.currentDayCount += 1;

        MainManager.Instance.SaveInfo();
        SceneManager.LoadScene("Game");
    }
    public void ActivatedLvlSeven()
    {
        MainManager.Instance.isLevelEnded = false;

        secondsLeft = timerRate;
        MainManager.Instance.timeTaken = secondsLeft;

        levelNumber = 7;
        MainManager.Instance.levelNumber = levelNumber;

        MainManager.Instance.levelName = "Xeronix Nebula";

        MainManager.Instance.currentDayCount += 1;

        MainManager.Instance.SaveInfo();
        SceneManager.LoadScene("Game");
    }
    public void ActivatedLvlEight()
    {
        MainManager.Instance.isLevelEnded = false;

        secondsLeft = timerRate;
        MainManager.Instance.timeTaken = secondsLeft;

        levelNumber = 8;
        MainManager.Instance.levelNumber = levelNumber;

        MainManager.Instance.levelName = "Betelgeuse";

        MainManager.Instance.currentDayCount += 1;

        MainManager.Instance.SaveInfo();
        SceneManager.LoadScene("Game");
    }
    public void ActivatedLvlNine()
    {
        MainManager.Instance.isLevelEnded = false;

        secondsLeft = timerRate;
        MainManager.Instance.timeTaken = secondsLeft;

        levelNumber = 9;
        MainManager.Instance.levelNumber = levelNumber;

        MainManager.Instance.levelName = "Horaxes Moon";

        MainManager.Instance.currentDayCount += 1;

        MainManager.Instance.SaveInfo();
        SceneManager.LoadScene("Game");
    }
    public void ActivatedLvlTen()
    {
        MainManager.Instance.isLevelEnded = false;

        secondsLeft = timerRate;
        MainManager.Instance.timeTaken = secondsLeft;

        levelNumber = 10;
        MainManager.Instance.levelNumber = levelNumber;

        MainManager.Instance.levelName = "The Fringe";

        MainManager.Instance.currentDayCount += 1;

        MainManager.Instance.SaveInfo();
        SceneManager.LoadScene("Game");
    }
    #endregion

    #region End Game
    public void ManageBestLastScores()
    {
        MainManager.Instance.lastPlayerName = MainManager.Instance.PlayerName;
        MainManager.Instance.lastPlayerScore = MainManager.Instance.PlayerHiScore;

        if (MainManager.Instance.PlayerHiScore > MainManager.Instance.bestPlayerScore)
        {
            MainManager.Instance.bestPlayerScore = MainManager.Instance.PlayerHiScore;
            MainManager.Instance.bestPlayerName = MainManager.Instance.PlayerName;
        }

        MainManager.Instance.SaveInfo();
    }

    public void GameOverScreen()
    {
        gameOverPanel.SetActive(true);
        gameReturnHiScore.text = MainManager.Instance.PlayerHiScore + "";
    }

    public void EndedGame()
    {
        Time.timeScale = 0;

        ManageBestLastScores();

        SceneManager.LoadScene("Main");
        MainManager.Instance.IsGameSaved = false;
        MainManager.Instance.IsGameJustEnded = true;
    }
    #endregion
}
