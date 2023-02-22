using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class MainManager : MonoBehaviour
{
    public static MainManager Instance;

    #region Data Enclosed

    //starting new game
    public string PlayerName;
    public Color PlayerColor;
    public string PlayerBackground;
    public string DifficultyLevel;

    //main menu hiscore info
    public string lastPlayerName;
    public float lastPlayerScore;
    public string bestPlayerName;
    public float bestPlayerScore;

    //managing game states
    public bool isLevelEnded;

    public bool IsGameSaved;
    public bool IsGameEnded;
    public bool IsGameJustEnded;

    //managing game difficulty
    public bool isGameEasy;
    public bool isGameMedium;
    public bool isGameHard;

    //managing player--stats
    public float PlayerHiScore;

    public float PlayerHealth;
    public float PlayerMaxHealth;

    public float crimeRating;

    //managing money
    public float MoneySaved;

    //managing inventory
    public float InvRockCount;
    public float InvDebrisCount;
    public float InvBountyCount;
    public float InvBulletCount;

    //managing time
    public int timeTaken;
    public float dayCountAmt;
    public float currentDayCount;

    //managing ship health & repairs
    public bool wasShipRepaired;

    public bool hasShieldsOne;
    public bool hasShieldsTwo;
    public bool hasShieldsThree;
    public bool hasShieldsFour;

    //managing planetary impact
    public float planetaryImpactAmt;

    public bool hasPlanetOne;
    public bool hasPlanetTwo;

    //managing levels
    public string levelName;
    public float levelNumber;

    //managing alien relationships
    public float pheninRlshpMaxScore;
    public float pheninRlshpScore;
    public bool hasPheninColors;
    public bool hasturnedonPheninColors;
    public float pheninFlagCountdown;
    public float pheninSecretsAmt;
    public float pheninSecretAmtRequired;

    public float xeronRlshpMaxScore;
    public float xeronRlshpScore;
    public bool hasXeronColors;
    public bool hasturnedonXeronColors;
    public float xeronFlagCountdown;
    public float xeronSecretsAmt;
    public float xeronSecretAmtRequired;

    //managing rates
    public float scavengingRate;
    public float planetaryPenetrationRate;

    public bool hasScavengingRateOne;
    public bool hasScavengingRateTwo;
    public bool hasScavengingRateThree;
    public bool hasScavengingRateFour;

    //managing debt
    public float debtLevelAmt;

    //levels
    public float levelTwoCostAmt;
    public float levelThreeCostAmt;
    public float levelFourCostAmt;
    public float levelFiveCostAmt;
    public float levelSixCostAmt;
    public float levelSevenCostAmt;
    public float levelEightCostAmt;
    public float levelNineCostAmt;
    public float levelTenCostAmt;

    public bool isLevelTwoOpen;
    public bool isLevelThreeOpen;
    public bool isLevelFourOpen;
    public bool isLevelFiveOpen;
    public bool isLevelSixOpen;
    public bool isLevelSevenOpen;
    public bool isLevelEightOpen;
    public bool isLevelNineOpen;
    public bool isLevelTenOpen;

    public bool enteringLevelOne;
    public bool enteringLevelTwo;
    public bool enteringLevelThree;
    public bool enteringLevelFour;
    public bool enteringLevelFive;
    public bool enteringLevelSix;
    public bool enteringLevelSeven;
    public bool enteringLevelEight;
    public bool enteringLevelNine;
    public bool enteringLevelTen;
    #endregion

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;

        DontDestroyOnLoad(gameObject);

        LoadInfo();
    }

    [System.Serializable]
    class SaveData
    {
        #region Save Data Enclosed

        //starting new game
        public string PlayerName;
        public Color PlayerColor;
        public string PlayerBackground;
        public string DifficultyLevel;

        //main menu hiscore info
        public string lastPlayerName;
        public float lastPlayerScore;
        public string bestPlayerName;
        public float bestPlayerScore;

        //managing game states
        public bool isLevelEnded;
        public bool IsGameSaved;
        public bool IsGameEnded;
        public bool IsGameJustEnded;

        //managing game difficulty
        public bool isGameEasy;
        public bool isGameMedium;
        public bool isGameHard;

        //managing player--stats
        public float PlayerHiScore;
        public float PlayerHealth;
        public float PlayerMaxHealth;
        public float crimeRating;

        //managing money
        public float MoneySaved;

        //managing inventory
        public float InvRockCount;
        public float InvDebrisCount;
        public float InvBountyCount;
        public float InvBulletCount;

        //managing time
        public int timeTaken;
        public float dayCountAmt;
        public float currentDayCount;

        //managing ship health & repairs
        public bool wasShipRepaired;

        public bool hasShieldsOne;
        public bool hasShieldsTwo;
        public bool hasShieldsThree;
        public bool hasShieldsFour;

        //managing planetary impact
        public float planetaryImpactAmt;

        public bool hasPlanetOne;
        public bool hasPlanetTwo;

        //managing levels
        public string levelName;
        public float levelNumber;

        //managing alien relationships
        public float pheninRlshpMaxScore;
        public float pheninRlshpScore;
        public bool hasPheninColors;
        public bool hasturnedonPheninColors;
        public float pheninFlagCountdown;
        public float pheninSecretsAmt;
        public float pheninSecretAmtRequired;

        public float xeronRlshpMaxScore;
        public float xeronRlshpScore;
        public bool hasXeronColors;
        public bool hasturnedonXeronColors;
        public float xeronFlagCountdown;
        public float xeronSecretsAmt;
        public float xeronSecretAmtRequired;

        //managing rates
        public float scavengingRate;
        public float planetaryPenetrationRate;

        public bool hasScavengingRateOne;
        public bool hasScavengingRateTwo;
        public bool hasScavengingRateThree;
        public bool hasScavengingRateFour;

        //managing debt
        public float debtLevelAmt;

        //levels
        public float levelTwoCostAmt;
        public float levelThreeCostAmt;
        public float levelFourCostAmt;
        public float levelFiveCostAmt;
        public float levelSixCostAmt;
        public float levelSevenCostAmt;
        public float levelEightCostAmt;
        public float levelNineCostAmt;
        public float levelTenCostAmt;

        public bool isLevelTwoOpen;
        public bool isLevelThreeOpen;
        public bool isLevelFourOpen;
        public bool isLevelFiveOpen;
        public bool isLevelSixOpen;
        public bool isLevelSevenOpen;
        public bool isLevelEightOpen;
        public bool isLevelNineOpen;
        public bool isLevelTenOpen;

        public bool enteringLevelOne;
        public bool enteringLevelTwo;
        public bool enteringLevelThree;
        public bool enteringLevelFour;
        public bool enteringLevelFive;
        public bool enteringLevelSix;
        public bool enteringLevelSeven;
        public bool enteringLevelEight;
        public bool enteringLevelNine;
        public bool enteringLevelTen;
        #endregion
    }

    public void SaveInfo()
    {
        SaveData data = new SaveData();

        data.PlayerName = PlayerName;
        data.PlayerColor = PlayerColor;
        data.PlayerBackground = PlayerBackground;
        data.DifficultyLevel = DifficultyLevel;

        data.lastPlayerName = lastPlayerName;
        data.lastPlayerScore = lastPlayerScore;
        data.bestPlayerName = bestPlayerName;
        data.bestPlayerScore = bestPlayerScore;

        data.isLevelEnded = isLevelEnded;
        data.IsGameSaved = IsGameSaved;
        data.IsGameEnded = IsGameEnded;
        data.IsGameJustEnded = IsGameJustEnded;

        data.isGameEasy = isGameEasy;
        data.isGameMedium = isGameMedium;
        data.isGameHard = isGameHard;

        data.PlayerHiScore = PlayerHiScore;
        data.PlayerHealth = PlayerHealth;
        data.PlayerMaxHealth = PlayerMaxHealth;
        data.crimeRating = crimeRating;

        data.MoneySaved = MoneySaved;

        data.InvRockCount = InvRockCount;
        data.InvDebrisCount = InvDebrisCount;
        data.InvBountyCount = InvBountyCount;
        data.InvBulletCount = InvBulletCount;

        data.timeTaken = timeTaken;
        data.dayCountAmt = dayCountAmt;
        data.currentDayCount = currentDayCount;

        data.wasShipRepaired = wasShipRepaired;

        data.hasShieldsOne = hasShieldsOne;
        data.hasShieldsTwo = hasShieldsTwo;
        data.hasShieldsThree = hasShieldsThree;
        data.hasShieldsFour = hasShieldsFour;

        data.planetaryImpactAmt = planetaryImpactAmt;

        data.hasPlanetOne = hasPlanetOne;
        data.hasPlanetTwo = hasPlanetTwo;

        data.levelName = levelName;
        data.levelNumber = levelNumber;

        data.pheninRlshpMaxScore = pheninRlshpMaxScore;
        data.pheninRlshpScore = pheninRlshpScore;
        data.hasPheninColors = hasPheninColors;
        data.hasturnedonPheninColors = hasturnedonPheninColors;
        data.pheninFlagCountdown = pheninFlagCountdown;
        data.pheninSecretsAmt = pheninSecretsAmt;
        data.pheninSecretAmtRequired = pheninSecretAmtRequired;

        data.xeronRlshpMaxScore = xeronRlshpMaxScore;
        data.xeronRlshpScore = xeronRlshpScore;
        data.hasXeronColors = hasXeronColors;
        data.hasturnedonXeronColors = hasturnedonXeronColors;
        data.xeronFlagCountdown = xeronFlagCountdown;
        data.xeronSecretsAmt = xeronSecretsAmt;
        data.xeronSecretAmtRequired = xeronSecretAmtRequired;

        data.scavengingRate = scavengingRate;
        data.planetaryPenetrationRate = planetaryPenetrationRate;

        data.hasScavengingRateOne = hasScavengingRateOne;
        data.hasScavengingRateTwo = hasScavengingRateTwo;
        data.hasScavengingRateThree = hasScavengingRateThree;
        data.hasScavengingRateFour = hasScavengingRateFour;

        data.debtLevelAmt = debtLevelAmt;

        data.levelTwoCostAmt = levelTwoCostAmt;
        data.levelThreeCostAmt = levelThreeCostAmt;
        data.levelFourCostAmt = levelFourCostAmt;
        data.levelFiveCostAmt = levelFiveCostAmt;
        data.levelSixCostAmt = levelSixCostAmt;
        data.levelSevenCostAmt = levelSevenCostAmt;
        data.levelEightCostAmt = levelEightCostAmt;
        data.levelNineCostAmt = levelNineCostAmt;
        data.levelTenCostAmt = levelTenCostAmt;

        data.isLevelTwoOpen = isLevelTwoOpen;
        data.isLevelThreeOpen = isLevelThreeOpen;
        data.isLevelFourOpen = isLevelFourOpen;
        data.isLevelFiveOpen = isLevelFiveOpen;
        data.isLevelSixOpen = isLevelSixOpen;
        data.isLevelSevenOpen = isLevelSevenOpen;
        data.isLevelEightOpen = isLevelEightOpen;
        data.isLevelNineOpen = isLevelNineOpen;
        data.isLevelTenOpen = isLevelTenOpen;

        data.enteringLevelOne = enteringLevelOne;
        data.enteringLevelTwo = enteringLevelTwo;
        data.enteringLevelThree = enteringLevelThree;
        data.enteringLevelFour = enteringLevelFour;
        data.enteringLevelFive = enteringLevelFive;
        data.enteringLevelSix = enteringLevelSix;
        data.enteringLevelSeven = enteringLevelSeven;
        data.enteringLevelEight = enteringLevelEight;
        data.enteringLevelNine = enteringLevelNine;
        data.enteringLevelTen = enteringLevelTen;

        string json = JsonUtility.ToJson(data);
        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }

    public void LoadInfo()
    {
        string path = Application.persistentDataPath + "/savefile.json";

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            PlayerName = data.PlayerName;
            PlayerColor = data.PlayerColor;
            PlayerBackground = data.PlayerBackground;
            DifficultyLevel = data.DifficultyLevel;

            lastPlayerName = data.lastPlayerName;
            lastPlayerScore = data.lastPlayerScore;
            bestPlayerName = data.bestPlayerName;
            bestPlayerScore = data.bestPlayerScore;

            isLevelEnded = data.isLevelEnded;
            IsGameSaved = data.IsGameSaved;
            IsGameEnded = data.IsGameEnded;
            IsGameJustEnded = data.IsGameJustEnded;

            isGameEasy = data.isGameEasy;
            isGameMedium = data.isGameMedium;
            isGameHard = data.isGameHard;

            PlayerHiScore = data.PlayerHiScore;
            PlayerHealth = data.PlayerHealth;
            PlayerMaxHealth = data.PlayerMaxHealth;
            crimeRating = data.crimeRating;

            MoneySaved = data.MoneySaved;

            InvRockCount = data.InvRockCount;
            InvDebrisCount = data.InvDebrisCount;
            InvBountyCount = data.InvBountyCount;
            InvBulletCount = data.InvBulletCount;

            timeTaken = data.timeTaken;
            dayCountAmt = data.dayCountAmt;
            currentDayCount = data.currentDayCount;

            wasShipRepaired = data.wasShipRepaired;

            hasShieldsOne = data.hasShieldsOne;
            hasShieldsTwo = data.hasShieldsTwo;
            hasShieldsThree = data.hasShieldsThree;
            hasShieldsFour = data.hasShieldsFour;

            planetaryImpactAmt = data.planetaryImpactAmt;

            hasPlanetOne = data.hasPlanetOne;
            hasPlanetTwo = data.hasPlanetTwo;

            levelName = data.levelName;
            levelNumber = data.levelNumber;

            pheninRlshpMaxScore = data.pheninRlshpMaxScore;
            pheninRlshpScore = data.pheninRlshpScore;
            hasPheninColors = data.hasPheninColors;
            hasturnedonPheninColors = data.hasturnedonPheninColors;
            pheninFlagCountdown = data.pheninFlagCountdown;
            pheninSecretsAmt = data.pheninSecretsAmt;
            pheninSecretAmtRequired = data.pheninSecretAmtRequired;

            xeronRlshpMaxScore = data.xeronRlshpMaxScore;
            xeronRlshpScore = data.xeronRlshpScore;
            hasXeronColors = data.hasXeronColors;
            hasturnedonXeronColors = data.hasturnedonXeronColors;
            xeronFlagCountdown = data.xeronFlagCountdown;
            xeronSecretsAmt = data.xeronSecretsAmt;
            xeronSecretAmtRequired = data.xeronSecretAmtRequired;

            scavengingRate = data.scavengingRate;
            planetaryPenetrationRate = data.planetaryPenetrationRate;

            hasScavengingRateOne = data.hasScavengingRateOne;
            hasScavengingRateTwo = data.hasScavengingRateTwo;
            hasScavengingRateThree = data.hasScavengingRateThree;
            hasScavengingRateFour = data.hasScavengingRateFour;

            debtLevelAmt = data.debtLevelAmt;

            levelTwoCostAmt = data.levelTwoCostAmt;
            levelThreeCostAmt = data.levelThreeCostAmt;
            levelFourCostAmt = data.levelFourCostAmt;
            levelFiveCostAmt = data.levelFiveCostAmt;
            levelSixCostAmt = data.levelSixCostAmt;
            levelSevenCostAmt = data.levelSevenCostAmt;
            levelEightCostAmt = data.levelEightCostAmt;
            levelNineCostAmt = data.levelNineCostAmt;
            levelTenCostAmt = data.levelTenCostAmt;

            isLevelTwoOpen = data.isLevelTwoOpen;
            isLevelThreeOpen = data.isLevelThreeOpen;
            isLevelFourOpen = data.isLevelFourOpen;
            isLevelFiveOpen = data.isLevelFiveOpen;
            isLevelSixOpen = data.isLevelSixOpen;
            isLevelSevenOpen = data.isLevelSevenOpen;
            isLevelEightOpen = data.isLevelEightOpen;
            isLevelNineOpen = data.isLevelNineOpen;
            isLevelTenOpen = data.isLevelTenOpen;

            enteringLevelOne = data.enteringLevelOne;
            enteringLevelTwo = data.enteringLevelTwo;
            enteringLevelThree = data.enteringLevelThree;
            enteringLevelFour = data.enteringLevelFour;
            enteringLevelFive = data.enteringLevelFive;
            enteringLevelSix = data.enteringLevelSix;
            enteringLevelSeven = data.enteringLevelSeven;
            enteringLevelEight = data.enteringLevelEight;
            enteringLevelNine = data.enteringLevelNine;
            enteringLevelTen = data.enteringLevelTen;
        }
        else
        {
            Debug.Log("there is no save file");
        }
    }
}
