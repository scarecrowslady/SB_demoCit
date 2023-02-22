using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CitadelInventoryManagement : MonoBehaviour
{
    #region General
    public float playerCurrencyAmt;
    public TMP_Text playerCurrencyAmtText;

    public float playerMaxHealth;
    public TMP_Text playerMaxHealthText;

    public float playerCurrentHealth;
    public TMP_Text playerCurrentHealthText;

    public float planetaryImpactAmt;
    public TMP_Text planetaryImpactText;
    #endregion

    #region ALLIE
    public float shieldsOneIncreaseAmt;
    public float shieldsTwoIncreaseAmt;
    public float shieldsThreeIncreaseAmt;
    public float shieldsFourIncreaseAmt;
    public float shieldsOneCost;
    public float shieldsTwoCost;
    public float shieldsThreeCost;
    public float shieldsFourCost;

    public Button shieldsOneButton;
    public Button shieldsTwoButton;
    public Button shieldsThreeButton;
    public Button shieldsFourButton;

    public bool hasShieldsOne;
    public bool hasShieldsTwo;
    public bool hasShieldsThree;
    public bool hasShieldsFour;

    public TMP_Text shieldsOneIncreaseAmtText;
    public TMP_Text shieldsTwoIncreaseAmtText;
    public TMP_Text shieldsThreeIncreaseAmtText;
    public TMP_Text shieldsFourIncreaseAmtText;
    public TMP_Text shieldsOneCostText;
    public TMP_Text shieldsTwoCostText;
    public TMP_Text shieldsThreeCostText;
    public TMP_Text shieldsFourCostText;

    public float planetaryInteractionOneDecreaseAmt;
    public float planetaryInteractionTwoDecreaseAmt;
    public float planetaryIntOneCost;
    public float planetaryIntTwoCost;

    public bool hasPlanetOne;
    public bool hasPlanetTwo;

    public TMP_Text planetaryIntOneDecreaseAmtText;
    public TMP_Text planetaryInttwoDecreaseAmtText;
    public TMP_Text planetaryIntOneCostText;
    public TMP_Text planetaryIntTwoCostText;

    public Button planetaryIntOneButton;
    public Button planetaryIntTwoButton;
    #endregion

    #region ONEESAN
    public float pheninRlshpAmt;
    public float pheninMaxRlshpAmt;
    public float xeronRlshpAmt;
    public float xeronMaxRlshpAmt;

    public Button pheninSecretsButton;
    public Button xeronSecretsButton;

    public bool hasPheninColors;
    public bool hasXeronColors;

    public float pheninSecretsOwned;
    public float xeronSecretsowned;
    public TMP_Text pheninSecretOwnedText;
    public TMP_Text xeronSecretOwnedText;

    public float pheninSecretsRequired;
    public float xeronSecretsRequired;

    public float pheninSecretPrice;
    public float xeronSecretPrice;
    public TMP_Text pheninSecretPriceText;
    public TMP_Text xeronSecretPriceText;
    #endregion

    #region KIL
    public float scavengingRate;

    public float scavengingRateOnePrice;
    public Button scavengingRateOneButton;
    public TMP_Text scavengingRateOnePriceText;
    public bool hasScavRateOne;

    public Button scavengingRateTwoButton;
    public float scavengingRateTwoPrice;
    public TMP_Text scavengingRateTwoPriceText;
    public bool hasScavRateTwo;

    public Button scavengingRateThreeButton;
    public float scavengingRateThreePrice;
    public TMP_Text scavengingRateThreePriceText;
    public bool hasScavRateThree;

    public Button scavengingRateFourButton;
    public float scavengingRateFourPrice;
    public TMP_Text scavengingRateFourPriceText;
    public bool hasScavRateFour;
    #endregion

    #region BERRO
    public float bribeCost;
    public TMP_Text bribeCostText;
    public Button bribeButton;

    public float criminalRating;
    public TMP_Text criminalRatingText;
    #endregion

    #region CRANK
    public GameObject fakeAmmopanel;
    public GameObject realammoPanel;

    public Button buyAmmoButton;

    public float ammoOwnedAmt;
    public TMP_Text ammoOwnedAmtText;
    public float ammoCost;
    public TMP_Text ammoCostText;
    #endregion

    #region LANE
    public float sellingRocksPrice;
    public TMP_Text sellingRocksPriceText;
    public Button sellingRocksButton;
    public float rocksOwnedAmt;
    public TMP_Text rocksOwnedText;

    public float sellingDebrisPrice;
    public TMP_Text sellingDebrisPriceText;
    public Button sellingDebrisButton;
    public float debrisOwnedAmt;
    public TMP_Text debrisOwnedText;

    public float turninBountiesPrice;
    public TMP_Text turninBountiesPriceText;
    public Button turninginBountiesButton;
    public float bountiesOwnedAmt;
    public TMP_Text bountiesOwnedText;
    #endregion

    #region DRAZ
    public float repairsRequiredCostAmt;
    public TMP_Text shipRepairsCostText;
    public Button shipRepairButton;
    private float repairRate;

    private float repairsNeeded;
    #endregion

    #region SHYLAR
    public float debtAmtOwed;
    public TMP_Text debAmtOwedText;

    public float dueDate;
    public float currentdate;
    public float daysLeft;
    public TMP_Text dueDateText;

    public Button pay100;
    public Button pay1000;
    public Button pay5000;
    #endregion

    #region XEL
    public bool enteringLevelOne;
    public GameObject enteringLevelOnePanel;
    public TMP_Text enterL1PanText;

    public float levelTwoCostAmt;
    public TMP_Text levelTwoCostAmtText;
    public Button unlockingLevelTwoButton;
    public Button levelTwoButton;
    public GameObject levelTwoUnlockButton;
    public GameObject levelTwoButton2;
    public bool isLevelTwoOpen;
    public bool enteringLevelTwo;

    public GameObject enteringLevelTwoPanel;
    public TMP_Text enterL2PanText;

    public float levelThreeCostAmt;
    public TMP_Text levelThreeCostAmtText;
    public Button unlockingLevelThreeButton;
    public Button levelThreeButton;
    public GameObject levelThreeUnlockButton;
    public GameObject levelThreeButton2;
    public bool isLevelThreeOpen;
    public bool enteringLevelThree;

    public GameObject enteringLevelThreePanel;
    public TMP_Text enterL3PanText;

    public float levelFourCostAmt;
    public TMP_Text levelFourCostAmtText;
    public Button unlockingLevelFourButton;
    public Button levelFourButton;
    public GameObject levelFourUnlockButton;
    public GameObject levelFourButton2;
    public bool isLevelFourOpen;
    public bool enteringLevelFour;

    public GameObject enteringLevelFourPanel;
    public TMP_Text enterL4PanText;

    public float levelFiveCostAmt;
    public TMP_Text levelFiveCostAmtText;
    public Button unlockingLevelFiveButton;
    public Button levelFiveButton;
    public GameObject levelFiveUnlockButton;
    public GameObject levelFiveButton2;
    public bool isLevelFiveOpen;
    public bool enteringLevelFive;

    public GameObject enteringLevelFivePanel;
    public TMP_Text enterL5PanText;

    public float levelSixCostAmt;
    public TMP_Text levelSixCostAmtText;
    public Button unlockingLevelSixButton;
    public Button levelSixButton;
    public GameObject levelSixUnlockButton;
    public GameObject levelSixButton2;
    public bool isLevelSixOpen;
    public bool enteringLevelSix;

    public GameObject enteringLevelSixPanel;
    public TMP_Text enterL6PanText;

    public float levelSevenCostAmt;
    public TMP_Text levelSevenCostAmtText;
    public Button unlockingLevelSevenButton;
    public Button levelSevenButton;
    public GameObject levelSevenUnlockButton;
    public GameObject levelSevenButton2;
    public bool isLevelSevenOpen;
    public bool enteringLevelSeven;

    public GameObject enteringLevelSevenPanel;
    public TMP_Text enterL7PanText;

    public float levelEightCostAmt;
    public TMP_Text levelEightCostAmtText;
    public Button unlockingLevelEightButton;
    public Button levelEightButton;
    public GameObject levelEightUnlockButton;
    public GameObject levelEightButton2;
    public bool isLevelEightOpen;
    public bool enteringLevelEight;

    public GameObject enteringLevelEightPanel;
    public TMP_Text enterL8PanText;

    public float levelNineCostAmt;
    public TMP_Text levelNineCostAmtText;
    public Button unlockingLevelNineButton;
    public Button levelNineButton;
    public GameObject levelNineUnlockButton;
    public GameObject levelNineButton2;
    public bool isLevelNineOpen;
    public bool enteringLevelNine;

    public GameObject enteringLevelNinePanel;
    public TMP_Text enteringL9PanText;

    public float levelTenCostAmt;
    public TMP_Text levelTenCostAmtText;
    public Button unlockingLevelTenButton;
    public Button levelTenButton;
    public GameObject levelTenUnlockButton;
    public GameObject levelTenButton2;
    public bool isLevelTenOpen;
    public bool enteringLevelTen;

    public GameObject enteringLevelTenPanel;
    public TMP_Text enteringL10PanText;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        #region General
        playerCurrencyAmt = MainManager.Instance.MoneySaved;
        playerCurrencyAmtText.text = playerCurrencyAmt + "";

        playerMaxHealth = MainManager.Instance.PlayerMaxHealth;
        playerMaxHealthText.text = playerMaxHealth + "";

        playerCurrentHealth = MainManager.Instance.PlayerHealth;
        playerCurrentHealthText.text = playerCurrentHealth + "" + " /" + playerMaxHealth;

        planetaryImpactAmt = MainManager.Instance.planetaryImpactAmt;

        criminalRating = MainManager.Instance.crimeRating;

        ammoOwnedAmt = MainManager.Instance.InvBulletCount;

        scavengingRate = MainManager.Instance.scavengingRate;

        pheninSecretsOwned = MainManager.Instance.pheninSecretsAmt;
        xeronSecretsowned = MainManager.Instance.xeronSecretsAmt;
        pheninRlshpAmt = MainManager.Instance.pheninRlshpScore;
        pheninMaxRlshpAmt = MainManager.Instance.pheninRlshpMaxScore;
        xeronRlshpAmt = MainManager.Instance.xeronRlshpScore;
        xeronMaxRlshpAmt = MainManager.Instance.xeronRlshpMaxScore;

        dueDate = MainManager.Instance.dayCountAmt;
        currentdate = MainManager.Instance.currentDayCount;
        daysLeft = dueDate - currentdate;

        if(pheninRlshpAmt >= pheninMaxRlshpAmt)
        {
            pheninSecretsOwned += 1;
            pheninRlshpAmt = 0;
        }
        if(xeronRlshpAmt >= xeronMaxRlshpAmt)
        {
            xeronSecretsowned += 1;
            xeronRlshpAmt = 0;
        }

        rocksOwnedAmt = MainManager.Instance.InvRockCount;
        debrisOwnedAmt = MainManager.Instance.InvDebrisCount;
        bountiesOwnedAmt = MainManager.Instance.InvBountyCount;

        debtAmtOwed = MainManager.Instance.debtLevelAmt;
        dueDate = MainManager.Instance.dayCountAmt;
        #endregion

        #region Setting Amounts by Difficulty
        if (MainManager.Instance.DifficultyLevel == "easy")
        {
            #region ALLIE (Shields)
            shieldsOneIncreaseAmt = 10;
            shieldsTwoIncreaseAmt = 15;
            shieldsThreeIncreaseAmt = 20;
            shieldsFourIncreaseAmt = 25;
            shieldsOneCost = 100;
            shieldsTwoCost = 150;
            shieldsThreeCost = 200;
            shieldsFourCost = 250;

            planetaryInteractionOneDecreaseAmt = -20;
            planetaryInteractionTwoDecreaseAmt = -15;
            planetaryIntOneCost = 1000;
            planetaryIntTwoCost = 2000;
            #endregion

            #region ONEESAN (faction)
            pheninSecretsRequired = 5;
            xeronSecretsRequired = 5;
            pheninSecretPrice = 500;
            xeronSecretPrice = 500;
            #endregion

            #region KIL (scavenging rate)
            scavengingRateOnePrice = 500;
            scavengingRateTwoPrice = 750;
            scavengingRateThreePrice = 1000;
            scavengingRateFourPrice = 1250;
            #endregion

            #region BERRO (criminal rating)
            bribeCost = 500;
            #endregion

            #region CRANK (ammo)
            fakeAmmopanel.SetActive(true);
            realammoPanel.SetActive(false);
            #endregion

            #region LANE (selling stuff)
            sellingRocksPrice = 7;
            sellingDebrisPrice = 10;
            turninBountiesPrice = 15;
            #endregion

            #region DRAZ (ship repairs)
            repairRate = 2;
            repairsRequiredCostAmt = repairRate * repairsNeeded;
            #endregion

            #region SHYLAR (debt)
            debtAmtOwed = 5000;
            dueDate = 30;
            #endregion

            #region XEL
            levelTwoCostAmt = 250;
            levelThreeCostAmt = 500;
            levelFourCostAmt = 750;
            levelFiveCostAmt = 1000;
            levelSixCostAmt = 1250;
            levelSevenCostAmt = 1500;
            levelEightCostAmt = 1750;
            levelNineCostAmt = 2000;
            levelTenCostAmt = 2500;
            #endregion
        }
        if (MainManager.Instance.DifficultyLevel == "medium")
        {
            #region ALLIE (Shields)
            shieldsOneIncreaseAmt = 15;
            shieldsTwoIncreaseAmt = 20;
            shieldsThreeIncreaseAmt = 25;
            shieldsFourIncreaseAmt = 30;
            shieldsOneCost = 150;
            shieldsTwoCost = 200;
            shieldsThreeCost = 250;
            shieldsFourCost = 300;

            planetaryInteractionOneDecreaseAmt = -15;
            planetaryInteractionTwoDecreaseAmt = -10;
            planetaryIntOneCost = 2000;
            planetaryIntTwoCost = 3000;
            #endregion

            #region ONEESAN (faction)
            pheninSecretsRequired = 7;
            xeronSecretsRequired = 7;
            pheninSecretPrice = 750;
            xeronSecretPrice = 750;
            #endregion

            #region KIL (scavenging rate)
            scavengingRateOnePrice = 750;
            scavengingRateTwoPrice = 1000;
            scavengingRateThreePrice = 1250;
            scavengingRateFourPrice = 1500;
            #endregion

            #region BERRO (criminal rating)
            bribeCost = 750;
            #endregion

            #region CRANK (ammo)
            fakeAmmopanel.SetActive(false);
            realammoPanel.SetActive(true);
            #endregion

            #region LANE (selling stuff)
            sellingRocksPrice = 5;
            sellingDebrisPrice = 7;
            turninBountiesPrice = 10;
            #endregion

            #region DRAZ (ship repairs)
            repairRate = 3;
            repairsRequiredCostAmt = repairRate * repairsNeeded;
            #endregion

            #region SHYLAR (debt)
            debtAmtOwed = 10000;
            dueDate = 20;
            #endregion

            #region XEL
            levelTwoCostAmt = 500;
            levelThreeCostAmt = 750;
            levelFourCostAmt = 1000;
            levelFiveCostAmt = 1250;
            levelSixCostAmt = 1500;
            levelSevenCostAmt = 1750;
            levelEightCostAmt = 2000;
            levelNineCostAmt = 2500;
            levelTenCostAmt = 3000;
            #endregion
        }
        if (MainManager.Instance.DifficultyLevel == "hard")
        {
            #region ALLIE (Shields)
            shieldsOneIncreaseAmt = 10;
            shieldsTwoIncreaseAmt = 15;
            shieldsThreeIncreaseAmt = 20;
            shieldsFourIncreaseAmt = 25;
            shieldsOneCost = 200;
            shieldsTwoCost = 250;
            shieldsThreeCost = 300;
            shieldsFourCost = 350;

            planetaryInteractionOneDecreaseAmt = -15;
            planetaryInteractionTwoDecreaseAmt = -10;
            planetaryIntOneCost = 3000;
            planetaryIntTwoCost = 4000;
            #endregion

            #region ONEESAN (faction)
            pheninSecretsRequired = 10;
            xeronSecretsRequired =10;
            pheninSecretPrice = 1000;
            xeronSecretPrice = 100;
            #endregion

            #region KIL (scavenging rate)
            scavengingRateOnePrice = 1000;
            scavengingRateTwoPrice = 1250;
            scavengingRateThreePrice = 1500;
            scavengingRateFourPrice = 2000;
            #endregion

            #region BERRO (criminal rating)
            bribeCost = 1000;
            #endregion

            #region CRANK (ammo)
            fakeAmmopanel.SetActive(false);
            realammoPanel.SetActive(true);
            #endregion

            #region LANE (selling stuff)
            sellingRocksPrice = 3;
            sellingDebrisPrice = 5;
            turninBountiesPrice = 7;
            #endregion

            #region DRAZ (ship repairs)
            repairRate = 4;
            repairsRequiredCostAmt = repairRate * repairsNeeded;
            #endregion

            #region SHYLAR (debt)
            debtAmtOwed = 15000;
            dueDate = 20;
            #endregion

            #region XEL
            levelTwoCostAmt = 750;
            levelThreeCostAmt = 1000;
            levelFourCostAmt = 1250;
            levelFiveCostAmt = 1500;
            levelSixCostAmt = 1750;
            levelSevenCostAmt = 2000;
            levelEightCostAmt = 2500;
            levelNineCostAmt = 3000;
            levelTenCostAmt = 3500;
            #endregion
        }
        #endregion

        #region Setting Text
        //ALLIE
        shieldsOneIncreaseAmtText.text = shieldsOneIncreaseAmt + "";
        shieldsTwoIncreaseAmtText.text = shieldsTwoIncreaseAmt + "";
        shieldsThreeIncreaseAmtText.text = shieldsThreeIncreaseAmt + "";
        shieldsFourIncreaseAmtText.text = shieldsFourIncreaseAmt + "";
        shieldsOneCostText.text = shieldsOneCost + "";
        shieldsTwoCostText.text = shieldsTwoCost + "";
        shieldsThreeCostText.text = shieldsThreeCost + "";
        shieldsFourCostText.text = shieldsFourCost + "";

        planetaryIntOneDecreaseAmtText.text = planetaryInteractionOneDecreaseAmt + "";
        planetaryInttwoDecreaseAmtText.text = planetaryInteractionTwoDecreaseAmt + "";
        planetaryIntOneCostText.text = planetaryIntOneCost + "";
        planetaryIntTwoCostText.text = planetaryIntTwoCost + "";

        //ONEESAN
        pheninSecretOwnedText.text = pheninSecretsOwned + "";
        xeronSecretOwnedText.text = xeronSecretsowned + "";

        pheninSecretPriceText.text = pheninSecretsRequired + " Secrets Required & " + pheninSecretPrice;
        xeronSecretPriceText.text = xeronSecretsRequired + " Secrets Required & " + xeronSecretPrice;

        //KIL
        scavengingRateOnePriceText.text = scavengingRateOnePrice + "";
        scavengingRateTwoPriceText.text = scavengingRateTwoPrice + "";
        scavengingRateThreePriceText.text = scavengingRateThreePrice + "";
        scavengingRateFourPriceText.text = scavengingRateFourPrice + "";

        //BERRO
        bribeCostText.text = bribeCost + "";
        criminalRatingText.text = criminalRating + "";

        //CRANK
        ammoOwnedAmtText.text = ammoOwnedAmt + "";
        ammoCostText.text = ammoCost + "";

        //LANE
        sellingRocksPriceText.text = sellingRocksPrice + "";
        sellingDebrisPriceText.text = sellingDebrisPrice + "";
        turninBountiesPriceText.text = turninBountiesPrice + "";

        rocksOwnedText.text = rocksOwnedAmt + "";
        debAmtOwedText.text = debrisOwnedAmt + "";
        bountiesOwnedText.text = bountiesOwnedText + "";

        //DRAZ
        playerMaxHealthText.text = playerMaxHealth + "";
        playerCurrentHealthText.text = playerCurrentHealth + "";
        shipRepairsCostText.text = repairsRequiredCostAmt + "";

        //SHYLAR
        debAmtOwedText.text = debrisOwnedAmt + "";
        dueDateText.text = daysLeft + " days";

        //XEL
        levelTwoCostAmtText.text = levelTwoCostAmt + "";
        levelThreeCostAmtText.text = levelThreeCostAmt + "";
        levelFourCostAmtText.text = levelFourCostAmt + "";
        levelFiveCostAmtText.text = levelFiveCostAmt + "";
        levelSixCostAmtText.text = levelSixCostAmt + "";
        levelSevenCostAmtText.text = levelSevenCostAmt + "";
        levelEightCostAmtText.text = levelEightCostAmt + "";
        levelNineCostAmtText.text = levelNineCostAmt + "";
        levelTenCostAmtText.text = levelTenCostAmt + "";

        enterL1PanText.text = "The Space Lane";
        enterL2PanText.text = "Terras I";
        enterL3PanText.text = "Korra'ath Zone";
        enterL4PanText.text = "The Orion Gate";
        enterL5PanText.text = "Rigel";
        enterL6PanText.text = "Allendome Field";
        enterL7PanText.text = "Xeronix Nebula";
        enterL8PanText.text = "Betelgeuse";
        enteringL9PanText.text = "Horaxes Moon";
        enteringL10PanText.text = "The Fringe";
        #endregion

        #region setting repairs info
        if (playerCurrentHealth < playerMaxHealth)
        {
            repairsNeeded = playerMaxHealth - playerCurrentHealth;
        }
        #endregion

        #region setting buttons
        #region shields/planetary
        hasShieldsOne = MainManager.Instance.hasShieldsOne;
        hasShieldsTwo = MainManager.Instance.hasShieldsTwo;
        hasShieldsThree = MainManager.Instance.hasShieldsThree;
        hasShieldsFour = MainManager.Instance.hasShieldsFour;

        hasPlanetOne = MainManager.Instance.hasPlanetOne;
        hasPlanetTwo = MainManager.Instance.hasPlanetTwo;
        #endregion

        #region alien colors
        hasPheninColors = MainManager.Instance.hasPheninColors;
        hasXeronColors = MainManager.Instance.hasXeronColors;
        #endregion

        #region scavenging rates
        hasScavRateOne = MainManager.Instance.hasScavengingRateOne;
        hasScavRateTwo = MainManager.Instance.hasScavengingRateTwo;
        hasScavRateThree = MainManager.Instance.hasScavengingRateThree;
        hasScavRateFour = MainManager.Instance.hasScavengingRateFour;
        #endregion

        #region levels
        if (MainManager.Instance.isLevelTwoOpen == false)
        {
            levelTwoUnlockButton.SetActive(true);
            levelTwoButton2.SetActive(false);
        }        
                
        if(MainManager.Instance.isLevelThreeOpen == false)
        {
            levelThreeUnlockButton.SetActive(true);
            levelThreeButton2.SetActive(false);
        }        
        
        if(MainManager.Instance.isLevelFourOpen == false)
        {
            levelFourUnlockButton.SetActive(true);
            levelFourButton2.SetActive(false);
        }        
                
        if(MainManager.Instance.isLevelFiveOpen == false)
        {
            levelFiveUnlockButton.SetActive(true);
            levelFiveButton2.SetActive(false);
        }        
        
        if(MainManager.Instance.isLevelSixOpen == false)
        {
            levelSixUnlockButton.SetActive(true);
            levelSixButton2.SetActive(false);
        }        
        
        if(MainManager.Instance.isLevelSevenOpen == false)
        {
            levelSevenUnlockButton.SetActive(true);
            levelSevenButton2.SetActive(false);
        }       
        
        if(MainManager.Instance.isLevelEightOpen == false)
        {
            levelEightUnlockButton.SetActive(true);
            levelEightButton2.SetActive(false);
        }        
        
        if(MainManager.Instance.isLevelNineOpen == false)
        {
            levelNineUnlockButton.SetActive(true);
            levelNineButton2.SetActive(false);
        }        
        
        if(MainManager.Instance.isLevelTenOpen == false)
        {
            levelTenUnlockButton.SetActive(true);
            levelTenButton2.SetActive(false);
        }
        #endregion

        #endregion

        #region level panels
        enteringLevelOnePanel.SetActive(false);
        enteringLevelTwoPanel.SetActive(false);
        enteringLevelThreePanel.SetActive(false);
        enteringLevelFourPanel.SetActive(false);
        enteringLevelFivePanel.SetActive(false);
        enteringLevelSixPanel.SetActive(false);
        enteringLevelSevenPanel.SetActive(false);
        enteringLevelEightPanel.SetActive(false);
        enteringLevelNinePanel.SetActive(false);
        enteringLevelTenPanel.SetActive(false);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        playerCurrencyAmtText.text = playerCurrencyAmt + "";

        playerMaxHealthText.text = playerMaxHealth + "";

        rocksOwnedText.text = rocksOwnedAmt + "";
        debAmtOwedText.text = debrisOwnedAmt + "";
        bountiesOwnedText.text = bountiesOwnedAmt + "";

        playerCurrencyAmt = MainManager.Instance.MoneySaved;
        playerMaxHealth = MainManager.Instance.PlayerMaxHealth;

        #region setting Main Manager
        MainManager.Instance.xeronSecretAmtRequired = xeronSecretsRequired;
        MainManager.Instance.pheninSecretAmtRequired = pheninSecretsRequired;

        MainManager.Instance.isLevelTwoOpen = isLevelTwoOpen;
        MainManager.Instance.isLevelThreeOpen = isLevelThreeOpen;
        MainManager.Instance.isLevelFourOpen = isLevelFourOpen;
        MainManager.Instance.isLevelFiveOpen = isLevelFiveOpen;
        MainManager.Instance.isLevelSixOpen = isLevelSixOpen;
        MainManager.Instance.isLevelSevenOpen = isLevelSevenOpen;
        MainManager.Instance.isLevelEightOpen = isLevelEightOpen;
        MainManager.Instance.isLevelNineOpen = isLevelNineOpen;
        MainManager.Instance.isLevelTenOpen = isLevelTenOpen;
        #endregion
    }

    #region ALLIE
    public void BuyShieldsOne()
    {
        if (playerCurrencyAmt > shieldsOneCost && hasShieldsOne == false)
        {
            playerMaxHealth += shieldsOneIncreaseAmt;

            playerCurrencyAmt -= shieldsOneCost;

            MainManager.Instance.PlayerMaxHealth = playerMaxHealth;
            MainManager.Instance.MoneySaved = playerCurrencyAmt;

            hasShieldsOne = true;
            MainManager.Instance.hasShieldsOne = hasShieldsOne;

            shieldsOneButton.interactable = false;
        }
    }
    public void BuyShieldsTwo()
    {
        if (playerCurrencyAmt > shieldsTwoCost && hasShieldsTwo == false)
        {
            playerMaxHealth += shieldsTwoIncreaseAmt;

            playerCurrencyAmt -= shieldsTwoCost;

            MainManager.Instance.PlayerMaxHealth = playerMaxHealth;
            MainManager.Instance.MoneySaved = playerCurrencyAmt;

            hasShieldsTwo = true;
            MainManager.Instance.hasShieldsTwo = hasShieldsTwo;

            shieldsTwoButton.interactable = false;
        }
    }
    public void BuyShieldsThree()
    {
        if (playerCurrencyAmt > shieldsThreeCost && hasShieldsThree == false)
        {
            playerMaxHealth += shieldsThreeIncreaseAmt;

            playerCurrencyAmt -= shieldsThreeCost;

            MainManager.Instance.PlayerMaxHealth = playerMaxHealth;
            MainManager.Instance.MoneySaved = playerCurrencyAmt;

            hasShieldsThree = true;
            MainManager.Instance.hasShieldsThree = hasShieldsThree;

            shieldsThreeButton.interactable = false;
        }
    }
    public void BuyShieldsFour()
    {
        if (playerCurrencyAmt > shieldsFourCost && hasShieldsFour == false)
        {
            playerMaxHealth += shieldsFourIncreaseAmt;

            playerCurrencyAmt -= shieldsFourCost;

            MainManager.Instance.PlayerMaxHealth = playerMaxHealth;
            MainManager.Instance.MoneySaved = playerCurrencyAmt;

            hasShieldsFour = true;
            MainManager.Instance.hasShieldsThree = hasShieldsFour;

            shieldsFourButton.interactable = false;
        }
    }

    public void BuyPlanetaryIntOne()
    {
        if (playerCurrencyAmt > planetaryIntOneCost && hasPlanetOne == false)
        {
            planetaryImpactAmt += planetaryInteractionOneDecreaseAmt;

            playerCurrencyAmt -= planetaryIntOneCost;

            MainManager.Instance.planetaryImpactAmt = planetaryImpactAmt;
            MainManager.Instance.MoneySaved = playerCurrencyAmt;

            hasPlanetOne = true;
            MainManager.Instance.hasPlanetOne = hasPlanetOne;

            planetaryIntOneButton.interactable = false;
        }
    }
    public void BuyPlanetaryIntTwo()
    {
        if (playerCurrencyAmt > planetaryIntTwoCost && hasPlanetTwo == false)
        {
            planetaryImpactAmt += planetaryInteractionTwoDecreaseAmt;

            playerCurrencyAmt -= planetaryIntTwoCost;

            MainManager.Instance.planetaryImpactAmt = planetaryImpactAmt;
            MainManager.Instance.MoneySaved = playerCurrencyAmt;

            hasPlanetTwo = true;
            MainManager.Instance.hasPlanetTwo = hasPlanetTwo;

            planetaryIntTwoButton.interactable = false;
        }
    }
    #endregion

    #region ONEESAN
    public void BuyPheninColors()
    {
        if (playerCurrencyAmt >= pheninSecretPrice && pheninSecretsOwned >= pheninSecretsRequired && hasPheninColors == false)
        {
            playerCurrencyAmt -= pheninSecretPrice;
            pheninSecretsOwned -= pheninSecretsRequired;

            pheninSecretsButton.interactable = false;

            MainManager.Instance.MoneySaved = playerCurrencyAmt;
            MainManager.Instance.hasPheninColors = true;
        }
    }
    public void BuyXeronColors()
    {
        if (playerCurrencyAmt >= xeronSecretPrice && xeronSecretsowned >= xeronSecretsRequired && hasXeronColors == false)
        {
            playerCurrencyAmt -= xeronSecretPrice;
            pheninSecretsOwned -= xeronSecretsRequired;

            xeronSecretsButton.interactable = false;

            MainManager.Instance.MoneySaved = playerCurrencyAmt;
            MainManager.Instance.hasXeronColors = true;
        }
    }
    #endregion

    #region KIL
    public void ScavengingRateOne()
    {
        if(playerCurrencyAmt >= scavengingRateOnePrice && hasScavRateOne == false)
        {
            playerCurrencyAmt -= scavengingRateOnePrice;
            scavengingRate += 1;

            scavengingRateOneButton.interactable = false;
            MainManager.Instance.scavengingRate += 1;

            hasScavRateOne = true;
            MainManager.Instance.hasScavengingRateOne = hasScavRateOne;

            MainManager.Instance.MoneySaved = playerCurrencyAmt;
        }        
    }
    public void ScavengingRateTwo()
    {
        if(playerCurrencyAmt >= scavengingRateTwoPrice && hasScavRateTwo == false)
        {
            playerCurrencyAmt -= scavengingRateTwoPrice;
            scavengingRate += 2;

            scavengingRateThreeButton.interactable = false;
            MainManager.Instance.scavengingRate += 2;

            hasScavRateTwo = true;
            MainManager.Instance.hasScavengingRateTwo = hasScavRateTwo;

            MainManager.Instance.MoneySaved = playerCurrencyAmt;
        }        
    }
    public void ScavengingRateThree()
    {
        if(playerCurrencyAmt >= scavengingRateTwoPrice && hasScavRateThree == false)
        {
            playerCurrencyAmt -= scavengingRateThreePrice;
            scavengingRate += 3;

            scavengingRateThreeButton.interactable = false;
            MainManager.Instance.scavengingRate += 3;

            hasScavRateThree = true;
            MainManager.Instance.hasScavengingRateThree = hasScavRateThree;

            MainManager.Instance.MoneySaved = playerCurrencyAmt;
        }        
    }
    public void ScavengingRateFour()
    {
        if(playerCurrencyAmt >= scavengingRateFourPrice && hasScavRateFour == false)
        {
            playerCurrencyAmt -= scavengingRateFourPrice;
            scavengingRate += 4;

            scavengingRateFourButton.interactable = false;
            MainManager.Instance.scavengingRate += 4;

            hasScavRateFour = true;
            MainManager.Instance.hasScavengingRateFour = hasScavRateFour;

            MainManager.Instance.MoneySaved = playerCurrencyAmt;
        }        
    }
    #endregion

    #region BERRO
    public void BribeOfficials()
    {
        if(playerCurrencyAmt >= bribeCost && criminalRating >= 1)
        {
            criminalRating -= 20;
            playerCurrencyAmt -= bribeCost;

            MainManager.Instance.crimeRating = criminalRating;
            MainManager.Instance.MoneySaved = playerCurrencyAmt;

            bribeButton.interactable = false;
        }
    }
    #endregion

    #region CRANK
    public void BuyAmmo()
    {
        if(playerCurrencyAmt >= ammoCost)
        {
            playerCurrencyAmt -= ammoCost;
            ammoOwnedAmt += 25;

            MainManager.Instance.InvBulletCount = ammoOwnedAmt;
            MainManager.Instance.MoneySaved = playerCurrencyAmt;

            buyAmmoButton.interactable = false;
        }        
    }
    #endregion

    #region LANE
    public void SellingRocks()
    {
        if(rocksOwnedAmt >= 1)
        {
            rocksOwnedAmt -= 1;
            playerCurrencyAmt += sellingRocksPrice;

            MainManager.Instance.InvRockCount = rocksOwnedAmt;
            MainManager.Instance.MoneySaved = playerCurrencyAmt;
        }        
    }
    public void SellingDebris()
    {
        if(debrisOwnedAmt >= 1)
        {
            debrisOwnedAmt -= 1;
            playerCurrencyAmt += sellingDebrisPrice;

            MainManager.Instance.InvDebrisCount = debrisOwnedAmt;
            MainManager.Instance.MoneySaved = playerCurrencyAmt;
        }        
    }
    public void TurningInBounties()
    {
        if(bountiesOwnedAmt >= 1)
        {
            bountiesOwnedAmt -= 1;
            playerCurrencyAmt += turninBountiesPrice;

            MainManager.Instance.InvBountyCount = bountiesOwnedAmt;
            MainManager.Instance.MoneySaved = playerCurrencyAmt;
        }        
    }
    #endregion

    #region DRAZ
    public void RepairShip()
    {
        if(playerCurrencyAmt >= repairsRequiredCostAmt)
        {
            playerCurrencyAmt -= repairsRequiredCostAmt;
            playerCurrentHealth = playerMaxHealth;
            repairsRequiredCostAmt = 0;
            repairsNeeded = 0;

            shipRepairButton.interactable = false;

            MainManager.Instance.PlayerHealth = playerMaxHealth;
            MainManager.Instance.MoneySaved = playerCurrencyAmt;
            MainManager.Instance.wasShipRepaired = true;
        }
        
    }
    #endregion

    #region SHYLAR
    public void PayOffHundred()
    {
        if(playerCurrencyAmt >= 100)
        {
            playerCurrencyAmt -= 100;

            MainManager.Instance.debtLevelAmt -= 100;
            MainManager.Instance.MoneySaved = playerCurrencyAmt;
        }        
    }
    public void PayOffThousand()
    {
        if(playerCurrencyAmt >= 1000)
        {
            playerCurrencyAmt -= 1000;

            MainManager.Instance.debtLevelAmt -= 1000;
            MainManager.Instance.MoneySaved = playerCurrencyAmt;
        }        
    }
    public void PayOffFiveThousand()
    {
        if(playerCurrencyAmt >= 5000)
        {
            playerCurrencyAmt -= 5000;

            MainManager.Instance.debtLevelAmt -= 5000;
            MainManager.Instance.MoneySaved = playerCurrencyAmt;
        }        
    }
    #endregion

    #region XEL
    //levelOne
    public void EnteringLevelOne()
    {
        enteringLevelOne = true;
        enteringLevelOnePanel.SetActive(true);
    }

    //levelTwo
    public void UnlockingLevelTwo()
    {
        Debug.Log("i have this money: " + playerCurrencyAmt);

        if (playerCurrencyAmt >= levelTwoCostAmt)
        {
            playerCurrencyAmt -= levelTwoCostAmt;
            levelTwoUnlockButton.SetActive(false);
            levelTwoButton2.SetActive(true);

            isLevelTwoOpen = true;
            MainManager.Instance.isLevelTwoOpen = isLevelTwoOpen;
            levelTwoButton.interactable = true;
        }
    }
    public void EnteringLevelTwo()
    {
        if (isLevelTwoOpen == true)
        {
            enteringLevelTwo = true;
            MainManager.Instance.enteringLevelTwo = enteringLevelTwo;
            enteringLevelTwoPanel.SetActive(true);
        }
    }

    //levelThree
    public void UnlockingLevelThree()
    {
        if (playerCurrencyAmt >= levelThreeCostAmt)
        {
            playerCurrencyAmt -= levelThreeCostAmt;
            levelThreeUnlockButton.SetActive(false);
            levelThreeButton2.SetActive(true);

            isLevelThreeOpen = true;
            MainManager.Instance.isLevelThreeOpen = isLevelThreeOpen;
            levelThreeButton.interactable = true;
        }
    }
    public void EnteringLevelThree()
    {
        if (isLevelThreeOpen == true)
        {
            enteringLevelThree = true;
            MainManager.Instance.enteringLevelThree = enteringLevelThree;
            enteringLevelThreePanel.SetActive(true);
        }
    }

    //levelFour
    public void UnlockingLevelFour()
    {
        if (playerCurrencyAmt >= levelFourCostAmt)
        {
            playerCurrencyAmt -= levelFourCostAmt;
            levelFourUnlockButton.SetActive(false);
            levelFourButton2.SetActive(true);

            isLevelFourOpen = true;
            MainManager.Instance.isLevelFourOpen = enteringLevelFour;
            levelFourButton.interactable = true;
        }
    }
    public void EnteringLevelFour()
    {
        if (isLevelFourOpen == true)
        {
            enteringLevelFour = true;
            MainManager.Instance.enteringLevelFour = enteringLevelFour;
            enteringLevelFourPanel.SetActive(true);
        }
    }

    //levelFive
    public void UnlockingLevelFive()
    {
        if (playerCurrencyAmt >= levelFiveCostAmt)
        {
            playerCurrencyAmt -= levelFiveCostAmt;
            levelFiveUnlockButton.SetActive(false);
            levelFiveButton2.SetActive(true);

            isLevelFiveOpen = true;
            MainManager.Instance.isLevelFiveOpen = enteringLevelFive;
            levelFiveButton.interactable = true;
        }
    }
    public void EnteringLevelFive()
    {
        if (isLevelFiveOpen == true)
        {
            enteringLevelFive = true;
            MainManager.Instance.enteringLevelFive = enteringLevelFive;
            enteringLevelFivePanel.SetActive(true);
        }
    }

    //levelSix
    public void UnlockingLevelSix()
    {
        if (playerCurrencyAmt >= levelSixCostAmt)
        {
            playerCurrencyAmt -= levelSixCostAmt;
            levelSixUnlockButton.SetActive(false);
            levelSixButton2.SetActive(true);

            isLevelSixOpen = true;
            MainManager.Instance.isLevelSixOpen = isLevelSixOpen;
            levelSixButton.interactable = true;
        }
    }
    public void EnteringLevelSix()
    {
        if (isLevelSixOpen == true)
        {
            enteringLevelSix = true;
            MainManager.Instance.enteringLevelSix = enteringLevelSix;
            enteringLevelSixPanel.SetActive(true);
        }
    }

    //levelSeven
    public void UnlockingLevelSeven()
    {
        if (playerCurrencyAmt >= levelSevenCostAmt)
        {
            playerCurrencyAmt -= levelSevenCostAmt;
            levelSevenUnlockButton.SetActive(false);
            levelSevenButton2.SetActive(true);

            isLevelSevenOpen = true;
            MainManager.Instance.isLevelSevenOpen = isLevelSevenOpen;
            levelSevenButton.interactable = true;
        }
    }
    public void EnteringLevelSeven()
    {
        if (isLevelSevenOpen == true)
        {
            enteringLevelSeven = true;
            MainManager.Instance.enteringLevelSeven = enteringLevelSeven;
            enteringLevelSevenPanel.SetActive(true);
        }
    }

    //levelEight
    public void UnlockingLevelEight()
    {
        if(playerCurrencyAmt >= levelEightCostAmt)
        {
            playerCurrencyAmt -= levelEightCostAmt;
            levelEightUnlockButton.SetActive(false);
            levelEightButton2.SetActive(true);

            isLevelEightOpen = true;
            MainManager.Instance.isLevelEightOpen = isLevelEightOpen;
            levelEightButton.interactable = true;
        }
    }
    public void EnteringLevelEight()
    {
        if(isLevelEightOpen == true)
        {
            enteringLevelEight = true;
            MainManager.Instance.enteringLevelEight = enteringLevelEight;
            enteringLevelEightPanel.SetActive(true);
        }
    }

    //levelNine
    public void UnlockingLevelNine()
    {
        if(playerCurrencyAmt >= levelNineCostAmt)
        {
            playerCurrencyAmt -= levelNineCostAmt;
            levelNineUnlockButton.SetActive(false);
            levelNineButton2.SetActive(true);

            isLevelNineOpen = true;
            MainManager.Instance.isLevelNineOpen = isLevelNineOpen;
            levelNineButton.interactable = true;
        }
    }
    public void EnteringLevelNine()
    {
        if(isLevelNineOpen == true)
        {
            enteringLevelNine = true;
            MainManager.Instance.enteringLevelNine = enteringLevelNine;
            enteringLevelNinePanel.SetActive(true);
        }
    }

    //levelTen
    public void UnlockingLevelTen()
    {
        if(playerCurrencyAmt >= levelTenCostAmt)
        {
            playerCurrencyAmt -= levelTenCostAmt;
            levelTenUnlockButton.SetActive(false);
            levelTenButton2.SetActive(true);

            isLevelTenOpen = true;
            MainManager.Instance.isLevelTenOpen = isLevelTenOpen;
            levelTenButton.interactable = true;
        }
    }
    public void EnteringLevelTen()
    {
        if(isLevelTenOpen == true)
        {
            enteringLevelTen = true;
            MainManager.Instance.enteringLevelTen = enteringLevelTen;
            enteringLevelTenPanel.SetActive(true);
        }
    }
    #endregion
}
