using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    #region Game UI Text
    //difficulty
    [SerializeField]
    private TMP_Text difficultyText;

    //scores
    [SerializeField]
    private TMP_Text scoreText;

    //money
    [SerializeField]
    private TMP_Text showMoney;
    public float moneySaved;

    //game UI panel
    public GameObject mainGameUIPanel;
    public GameObject pauseGamePanel;
    public GameObject gameOverPanel;

    //day count amount
    public float dayCountAmt;
    public float currentDayCount;
    public TMP_Text dayCountAmtText;

    //setting difficulty
    public bool isLevelEasy;
    public bool isLevelMedium;
    public bool isLevelHard;
    #endregion

    #region Player Info
    //player info
    public PlayerController player;
    public GameObject playerRB;
    public float playerSpeed;
    public Vector3 playerStarterPOS;
    private Vector3 playerCurrentPOS;
    private Vector3 playerNewPOS;

    //player health
    public float playerHealth;
    public float playerMaxHealth;
    public GameObject healthBar;
    public Slider healthBarSlider;
    public TMP_Text currentHealth;
    public TMP_Text totalHealth;

    //player name
    public TMP_Text playerName;
    public float playerHiScore;

    //player background
    public TMP_Text playerBackground;
    public GameObject charaPicTrader;
    public GameObject charaPicHunter;
    public GameObject charaPicPirate;

    //player crime status
    public TMP_Text titleOfStatus;
    public TMP_Text numberOfStatus;
    public float crimeRatingAmt;

    //debt management
    public float debtAmountTotal;
    public TMP_Text debtAmountText;
    #endregion

    #region Inventory Management
    //game UI text
    [SerializeField]
    private TMP_Text showRocks;
    [SerializeField]
    private TMP_Text showDebris;
    [SerializeField]
    private TMP_Text showBounty;

    //other stuff to keep track of
    public float leftOverDebris;
    public float leftOverRock;
    public float leftOverBounty;

    //ammo
    public float currentAmmoAmount;
    public GameObject ammoPanel;
    public TMP_Text currentAmmoAmtText;
    #endregion

    #region High Scores Management
    //player hiscore
    [SerializeField]
    private TMP_Text gameReturnHiScore;

    public string lastPlayerName;
    public float lastPlayerScore;
    public string bestPlayerName;
    public float bestPlayerScore;
    #endregion

    #region Alien Management
    //alien relationship
    public Slider pheninSlider;
    public Slider xenonSlider;

    //flag immunity stuff
    public float pheninFactionValue;
    public float xeronFactionValue;
    public float pheninMaxValue;
    public float xeronMaxValue;

    public GameObject pheninFlag;
    public GameObject xeronFlag;

    public Button pheninFlagButton;
    public Button xeronFlagButton;

    public bool hasPheninColors;
    public bool hasXeronColors;
    public bool isPheninFlagOn;
    public bool isXeronFlagOn;

    //secrets owned
    public float pheninSecretsOwned;
    public float xeronSecretsOwned;

    //more UI info
    public TMP_Text pheninMaxScore;
    public TMP_Text currentPheninScore;
    public TMP_Text xeronMaxScore;
    public TMP_Text currentXeronScore;
    #endregion

    #region Level Management
    //special mission
    public TMP_Text backgroundMissionText;

    //levels
    public TMP_Text levelDisplay;
    public string levelName;
    public float levelNumber;
    public bool isLevelEnded;

    //level time limit
    public TMP_Text timeCountdown;
    public int secondsLeft = 60;
    public bool isReset = false;

    public Slider fuelSlider;
    #endregion

    #region Prompting Citadel
    //citadel
    public float citadelSpeed;

    public GameObject citadelPFB;
    public GameObject citadelSpawnZone;
    public Vector3 citadelSpawnPoint;

    public GameObject citadelFinalSpawn;
    public Vector3 citadelFinalPoint;
    #endregion

    public bool isGameJustEnded;

    // Start is called before the first frame update
    void Start()
    {
        #region starting up player
        playerRB.gameObject.SetActive(true);

        //player starting position
        playerStarterPOS = playerRB.transform.position;
        #endregion region

        #region initialize opening display
        difficultyText.text = MainManager.Instance.DifficultyLevel;
        playerName.text = MainManager.Instance.PlayerName;
        scoreText.text = MainManager.Instance.PlayerHiScore + "";

        if(MainManager.Instance.PlayerBackground == "hunter")
        {
            playerBackground.text = "HUNTER";

            backgroundMissionText.text = "HUNT DOWN BOUNTIES";

            charaPicHunter.SetActive(true);
        }
        if (MainManager.Instance.PlayerBackground == "pirate")
        {
            playerBackground.text = "PIRATE";

            backgroundMissionText.text = "TARGET TRADERS";

            charaPicPirate.SetActive(true);
        }
        if (MainManager.Instance.PlayerBackground == "trader")
        {
            playerBackground.text = "TRADER";

            backgroundMissionText.text = "GET RESOURCES";

            charaPicTrader.SetActive(true);
        }

        showMoney.text = MainManager.Instance.MoneySaved + "";
        showRocks.text = MainManager.Instance.InvRockCount + "";
        showDebris.text = MainManager.Instance.InvDebrisCount + "";
        showBounty.text = MainManager.Instance.InvBountyCount + "";
        timeCountdown.text = "00:" + MainManager.Instance.timeTaken;

        currentAmmoAmount = MainManager.Instance.InvBulletCount;
        currentAmmoAmtText.text = currentAmmoAmount + "";

        //debt
        debtAmountTotal = MainManager.Instance.debtLevelAmt;
        debtAmountText.text = debtAmountTotal + "";
        currentDayCount = MainManager.Instance.currentDayCount;
        dayCountAmt = MainManager.Instance.dayCountAmt;
        dayCountAmtText.text = currentDayCount + " / " + dayCountAmt;
        #endregion

        #region ship health stuff
        healthBarSlider.maxValue = MainManager.Instance.PlayerMaxHealth;
        healthBarSlider.minValue = 0;
        healthBarSlider.value = MainManager.Instance.PlayerHealth;

        currentHealth.text = MainManager.Instance.PlayerHealth + "";
        totalHealth.text = "/ " + MainManager.Instance.PlayerMaxHealth + "";

        if (MainManager.Instance.wasShipRepaired == true)
        {
            MainManager.Instance.PlayerHealth = MainManager.Instance.PlayerMaxHealth;
            healthBarSlider.value = MainManager.Instance.PlayerHealth;
            currentHealth.text = MainManager.Instance.PlayerHealth + "";
        }
        #endregion

        #region controlling game states
        //controlling game states
        mainGameUIPanel.SetActive(true);
        pauseGamePanel.SetActive(false);
        gameOverPanel.SetActive(false);

        Time.timeScale = 1;

        MainManager.Instance.IsGameSaved = false;
        MainManager.Instance.IsGameEnded = false;
        MainManager.Instance.isLevelEnded = false;

        isGameJustEnded = false;
        MainManager.Instance.IsGameJustEnded = isGameJustEnded;
        #endregion

        #region registering time
        secondsLeft = MainManager.Instance.timeTaken;

        fuelSlider.maxValue = secondsLeft;
        fuelSlider.minValue = 0;
        fuelSlider.value = MainManager.Instance.timeTaken;
        #endregion

        #region entering the citadel
        playerStarterPOS = playerRB.transform.position;
        citadelSpawnPoint = citadelSpawnZone.transform.position;
        #endregion

        #region managing levels
        levelName = MainManager.Instance.levelName;
        levelNumber = MainManager.Instance.levelNumber;

        levelDisplay.text = levelNumber + "" + ": " + levelName;

        isLevelEnded = false;
        #endregion

        #region crime
        crimeRatingAmt = MainManager.Instance.crimeRating;
        numberOfStatus.GetComponent<Text>();
        #endregion

        #region flag stuff and factions
        pheninSlider.maxValue = MainManager.Instance.pheninRlshpMaxScore;
        pheninMaxValue = MainManager.Instance.pheninRlshpMaxScore;
        pheninSlider.minValue = 0;
        xenonSlider.maxValue = MainManager.Instance.xeronRlshpMaxScore;
        xeronMaxValue = MainManager.Instance.xeronRlshpMaxScore;
        xenonSlider.minValue = 0;

        //pheninFactionValue = MainManager.Instance.pheninRlshpScore;
        //xeronFactionValue = MainManager.Instance.xeronRlshpScore;
        //pheninSlider.value = pheninFactionValue;
        //xenonSlider.value = xeronFactionValue;

        //flag stuff
        hasPheninColors = MainManager.Instance.hasPheninColors;
        hasXeronColors = MainManager.Instance.hasXeronColors;

        isPheninFlagOn = MainManager.Instance.hasturnedonPheninColors;
        isXeronFlagOn = MainManager.Instance.hasturnedonXeronColors;

        //secrets owned
        pheninSecretsOwned = MainManager.Instance.pheninSecretsAmt;
        xeronSecretsOwned = MainManager.Instance.xeronSecretsAmt;

        //initializing text
        //currentPheninScore.text = pheninSlider.value + "";
        //currentXeronScore.text = xenonSlider.value + "";
        //pheninMaxScore.text = MainManager.Instance.pheninRlshpMaxScore + "";
        //xeronMaxScore.text = MainManager.Instance.xeronRlshpMaxScore + "";

        Debug.Log("Game Controller checking whether phenin colors are one " + MainManager.Instance.hasturnedonPheninColors);
        #endregion

        #region set difficulty
        if (MainManager.Instance.DifficultyLevel == "easy")
        {
            isLevelEasy = true;
            ammoPanel.gameObject.SetActive(false);
        }
        if (MainManager.Instance.DifficultyLevel == "medium" || MainManager.Instance.DifficultyLevel == "hard")
        {
            isLevelMedium = true;
            ammoPanel.gameObject.SetActive(true);
        }
        #endregion

    }

    // Update is called once per frame
    void Update()
    {
        //managing ammo
        currentAmmoAmount = MainManager.Instance.InvBulletCount;

        //managing day count
        dayCountAmtText.text = MainManager.Instance.dayCountAmt + "";

        //managing health
        healthBarSlider.value = MainManager.Instance.PlayerHealth;

        //managing fuel
        fuelSlider.value = MainManager.Instance.timeTaken;

        //flag and faction stuff
        pheninFactionValue = MainManager.Instance.pheninRlshpScore;
        xeronFactionValue = MainManager.Instance.xeronRlshpScore;
        pheninSlider.value = pheninFactionValue;
        xenonSlider.value = xeronFactionValue;

        currentPheninScore.text = pheninSlider.value + "";
        currentXeronScore.text = xenonSlider.value + "";
        pheninMaxScore.text = MainManager.Instance.pheninRlshpMaxScore + "";
        xeronMaxScore.text = MainManager.Instance.xeronRlshpMaxScore + "";

        isPheninFlagOn = MainManager.Instance.hasturnedonPheninColors;
        isXeronFlagOn = MainManager.Instance.hasturnedonXeronColors;

        //managing player health and game state
        if (MainManager.Instance.PlayerHealth <= 0)
        {
            MainManager.Instance.IsGameEnded = true;

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

        //managing alien relationships
        if (hasPheninColors == true)
        {
            pheninFlagButton.interactable = true;
        }
        else
        {
            pheninFlagButton.interactable = false;
        }
        if (hasXeronColors == true)
        {
            xeronFlagButton.interactable = true;
        }
        else
        {
            xeronFlagButton.interactable = false;
        }

        //starting up timers
        if (isReset == false && secondsLeft > 0)
        {
            StartCoroutine(TimerTake());
        }

        if (secondsLeft <= 0)
        {
            LevelEnded();
        }

        #region managing crime rating
        //managing crime rating
        if (crimeRatingAmt <= 0)
        {
            titleOfStatus.text = "Lawful";
            numberOfStatus.text = "0";
        }
        if (crimeRatingAmt > 0 && crimeRatingAmt < 25)
        {
            titleOfStatus.text = "Lawful";
            numberOfStatus.text = crimeRatingAmt + "";
        }
        if (crimeRatingAmt > 25 && crimeRatingAmt < 50)
        {
            titleOfStatus.text = "Flagged";
            numberOfStatus.text = crimeRatingAmt + "";
        }
        if (crimeRatingAmt > 50 && crimeRatingAmt < 75)
        {
            titleOfStatus.text = "Criminal";
            numberOfStatus.text = crimeRatingAmt + "";
        }
        if (crimeRatingAmt > 75 && crimeRatingAmt < 100)
        {
            titleOfStatus.text = "Most Wanted";
            numberOfStatus.text = crimeRatingAmt + "";
        }
        #endregion
    }

    #region Managing Game States
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

    public void GoBack()
    {
        Time.timeScale = 0;

        SaveGame();
        SceneManager.LoadScene("Main");
    }

    //with a game ended
    public void EndedGame()
    {
        Time.timeScale = 0;

        isGameJustEnded = true;
        MainManager.Instance.IsGameJustEnded = isGameJustEnded;

        ManageBestLastScores();

        SceneManager.LoadScene("Main");
        MainManager.Instance.IsGameSaved = false;
    }
    #endregion

    #region Managing Inventory AND Stats
    public void AddingScore(float amount)
    {
        MainManager.Instance.PlayerHiScore += amount;

        scoreText.text = MainManager.Instance.PlayerHiScore + "";
    }

    public void AddMoney(float amount)
    {
        MainManager.Instance.MoneySaved += amount;

        showMoney.text = MainManager.Instance.MoneySaved + "";
    }

    //IRIL - negative
    public void AddIrillRlshp(float amount)
    {
        MainManager.Instance.pheninRlshpScore += amount;

        pheninSlider.value += amount;
    }

    //XERON - positive
    public void AddXenonRlshp(float amount)
    {
        MainManager.Instance.xeronRlshpScore += amount;

        xenonSlider.value += amount;
    }

    public void AddRocks(float amount)
    {
        MainManager.Instance.InvRockCount += amount;

        showRocks.text = MainManager.Instance.InvRockCount + "";
    }

    public void AddDebris(float amount)
    {
        MainManager.Instance.InvDebrisCount += amount;

        showDebris.text = MainManager.Instance.InvDebrisCount + "";
    }

    public void AddBounty(float amount)
    {
        MainManager.Instance.InvBountyCount += amount;

        showBounty.text = MainManager.Instance.InvBountyCount + "";
    }

    public void ManageAmmo(float amount)
    {
        MainManager.Instance.InvBulletCount += amount;

        currentAmmoAmtText.text = currentAmmoAmount + "";
    }

    public void BecomeCriminal(float amount)
    {
        MainManager.Instance.crimeRating += amount;
        crimeRatingAmt = MainManager.Instance.crimeRating;
    }

    public void ManagePlayerHealth(float amount)
    {
        MainManager.Instance.PlayerHealth += amount;

        healthBarSlider.value = MainManager.Instance.PlayerHealth;

        currentHealth.text = MainManager.Instance.PlayerHealth + "";
    }
    #endregion

    #region Level Countdown Timer
    //managing timer
    IEnumerator TimerTake()
    {
        isReset = true;
        yield return new WaitForSeconds(1);
        secondsLeft -= 1;

        if (secondsLeft < 10)
        {
            timeCountdown.text = "00:0" + secondsLeft;
        }
        else
        {
            timeCountdown.text = "00:" + secondsLeft;
        }

        MainManager.Instance.timeTaken = secondsLeft;

        isReset = false;
    }
    #endregion

    #region Ending The Level
    //managing level
    public void LevelEnded()
    {
        isLevelEnded = true;
        MainManager.Instance.isLevelEnded = true;

        MainManager.Instance.pheninRlshpScore = pheninFactionValue;
        MainManager.Instance.xeronRlshpScore = xeronFactionValue;

        if (pheninFactionValue >= pheninMaxValue)
        {
            MainManager.Instance.pheninRlshpScore = pheninMaxValue;
        }
        if (xeronFactionValue >= xeronMaxValue)
        {
            MainManager.Instance.xeronRlshpScore = xeronMaxValue;
        }

        MainManager.Instance.SaveInfo();

        //enter citadel
        StartCoroutine(LevelEnding());
    }

    IEnumerator LevelEnding()
    {
        isLevelEnded = true;
        MainManager.Instance.isLevelEnded = true;
        yield return new WaitForSeconds(1);

        //citadel enters screen
        Instantiate(citadelPFB);                       
        yield return new WaitForSeconds(2);

        //move player to middle of screen
        playerCurrentPOS = playerRB.transform.position;
        playerSpeed = 4.0f;
        float step = playerSpeed * Time.deltaTime;
        playerRB.transform.position = Vector3.MoveTowards(playerCurrentPOS, playerStarterPOS, step);

        yield return new WaitForSeconds(1);

        if (playerRB.transform.position.y < citadelSpawnZone.transform.position.y)
        {
            //move into citadel
            playerNewPOS = playerRB.transform.position;
            playerSpeed = 4.0f;
            float stepNew = playerSpeed * Time.deltaTime;
            playerRB.transform.position += transform.up * stepNew;
        }

        yield return new WaitForSeconds(2);

        playerRB.gameObject.SetActive(false);
        playerRB.transform.position = playerStarterPOS;
        Debug.Log(playerRB.transform.position);
        yield return new WaitForSeconds(2);

        Time.timeScale = 0;
        SaveGame();
        LoadCitadel();
    }
    #endregion

    #region Saving and Loading Citadel and Game Over
    public void LoadCitadel()
    {
        SceneManager.LoadScene("Citadel");
    }

    public void SaveGame()
    {
        MainManager.Instance.IsGameSaved = true;

        MainManager.Instance.SaveInfo();
    }

    public void GameOverScreen()
    {
        Time.timeScale = 0;

        gameOverPanel.SetActive(true);
        gameReturnHiScore.text = "HiScore: " + MainManager.Instance.PlayerHiScore + "";

        mainGameUIPanel.SetActive(false);
        pauseGamePanel.SetActive(true);
    }
    #endregion
}
