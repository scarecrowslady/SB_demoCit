using UnityEngine;

public class SpawnManager_2 : MonoBehaviour
{
    // Set the array size and drag the prefabs here.
    public GameObject[] spaceObjects;

    // Set the same array size and define the chances for each prefab.
    public int[] chances;

    public float spawnRangeX;
    public float spawnPosZ;
    public float spawnPosY;

    public float startDelay;
    public float spawnInterval;

    //managing level bools
    public bool hasEnteredLevelOne;
    public bool hasEnteredLevelTwo;
    public bool hasEnteredLevelThree;
    public bool hasEnteredLevelFour;
    public bool hasEnteredLevelFive;
    public bool hasEnteredLevelSix;
    public bool hasEnteredLevelSeven;
    public bool hasEnteredLevelEight;
    public bool hasEnteredLevelNine;
    public bool hasEnteredLevelTen;

    void Start()
    {
        hasEnteredLevelOne = MainManager.Instance.enteringLevelOne;
        hasEnteredLevelTwo = MainManager.Instance.enteringLevelTwo;
        hasEnteredLevelThree = MainManager.Instance.enteringLevelThree;
        hasEnteredLevelFour = MainManager.Instance.enteringLevelFour;
        hasEnteredLevelFive = MainManager.Instance.enteringLevelFive;
        hasEnteredLevelSix = MainManager.Instance.enteringLevelSix;
        hasEnteredLevelSeven = MainManager.Instance.enteringLevelSeven;
        hasEnteredLevelEight = MainManager.Instance.enteringLevelEight;
        hasEnteredLevelNine = MainManager.Instance.enteringLevelNine;
        hasEnteredLevelTen = MainManager.Instance.enteringLevelTen;

        InvokeRepeating("RandomSpawn", 1, 2);
    }

    //void RandomSpawn(Vector3 pos, Quaternion rot) ---> WITH DIFFICULTY LEVELING AND LEVELS
    void RandomSpawn()
    {
        //spaceObjects = new GameObject[9];

        if (MainManager.Instance.DifficultyLevel == "easy")
        {
            if (hasEnteredLevelOne == true)
            {
                chances = new int[9] { 25, 25, 5, 0, 0, 0, 0, 0, 45 };
            }
            if (hasEnteredLevelTwo == true)
            {
                chances = new int[9] { 25, 25, 5, 0, 0, 5, 0, 0, 40 };
            }
            if (hasEnteredLevelThree == true)
            {
                chances = new int[9] { 25, 25, 5, 0, 0, 15, 0, 0, 30 };
            }
            if (hasEnteredLevelFour == true)
            {
                chances = new int[9] { 25, 25, 5, 5, 5, 10, 0, 0, 25 };
            }
            if (hasEnteredLevelFive == true)
            {
                chances = new int[9] { 25, 25, 5, 7, 7, 10, 0, 0, 21 };
            }
            if (hasEnteredLevelSix == true)
            {
                chances = new int[9] { 20, 20, 3, 7, 7, 7, 2, 2, 32 };
            }
            if (hasEnteredLevelSeven == true)
            {
                chances = new int[9] { 20, 20, 3, 7, 7, 7, 3, 3, 30 };
            }
            if (hasEnteredLevelEight == true)
            {
                chances = new int[9] { 15, 15, 3, 10, 10, 7, 5, 5, 30 };
            }
            if (hasEnteredLevelNine == true)
            {
                chances = new int[9] { 15, 15, 3, 15, 15, 5, 7, 7, 18 };
            }
            if (hasEnteredLevelTen == true)
            {
                chances = new int[9] { 30, 30, 5, 15, 15, 2, 0, 0, 3 };
            }

        }
        if (MainManager.Instance.DifficultyLevel == "medium")
        {
            if (hasEnteredLevelOne == true)
            {
                chances = new int[9] { 20, 20, 3, 0, 0, 0, 0, 0, 57 };
            }
            if (hasEnteredLevelTwo == true)
            {
                chances = new int[9] { 25, 25, 3, 0, 0, 3, 0, 0, 54 };
            }
            if (hasEnteredLevelThree == true)
            {
                chances = new int[9] { 20, 20, 3, 0, 0, 10, 0, 0, 47 };
            }
            if (hasEnteredLevelFour == true)
            {
                chances = new int[9] { 20, 20, 3, 7, 7, 7, 0, 0, 36 };
            }
            if (hasEnteredLevelFive == true)
            {
                chances = new int[9] { 20, 20, 3, 10, 10, 7, 0, 0, 30 };
            }
            if (hasEnteredLevelSix == true)
            {
                chances = new int[9] { 15, 15, 2, 10, 10, 5, 3, 3, 37 };
            }
            if (hasEnteredLevelSeven == true)
            {
                chances = new int[9] { 15, 15, 2, 10, 10, 5, 5, 5, 33 };
            }
            if (hasEnteredLevelEight == true)
            {
                chances = new int[9] { 10, 10, 2, 15, 15, 10, 7, 7, 24 };
            }
            if (hasEnteredLevelNine == true)
            {
                chances = new int[9] { 10, 10, 2, 20, 20, 7, 10, 10, 11 };
            }
            if (hasEnteredLevelTen == true)
            {
                chances = new int[9] { 25, 25, 3, 20, 20, 3, 0, 0, 4 };
            }
        }
        if (MainManager.Instance.DifficultyLevel == "hard")
        {
            if (hasEnteredLevelOne == true)
            {
                chances = new int[9] { 15, 15, 2, 0, 0, 0, 0, 0, 68 };
            }
            if (hasEnteredLevelTwo == true)
            {
                chances = new int[9] { 15, 15, 2, 0, 0, 2, 0, 0, 66 };
            }
            if (hasEnteredLevelThree == true)
            {
                chances = new int[9] { 15, 15, 2, 0, 0, 5, 0, 0, 63 };
            }
            if (hasEnteredLevelFour == true)
            {
                chances = new int[9] { 15, 15, 2, 5, 5, 5, 0, 0, 53 };
            }
            if (hasEnteredLevelFive == true)
            {
                chances = new int[9] { 15, 15, 2, 5, 5, 5, 0, 0, 53 };
            }
            if (hasEnteredLevelSix == true)
            {
                chances = new int[9] { 10, 10, 1, 15, 15, 3, 5, 5, 36 };
            }
            if (hasEnteredLevelSeven == true)
            {
                chances = new int[9] { 10, 10, 1, 15, 15, 3, 7, 7, 32 };
            }
            if (hasEnteredLevelEight == true)
            {
                chances = new int[9] { 5, 5, 1, 20, 20, 15, 10, 10, 14 };
            }
            if (hasEnteredLevelNine == true)
            {
                chances = new int[9] { 5, 5, 0, 25, 25, 10, 13, 13, 3 };
            }
            if (hasEnteredLevelTen == true)
            {
                chances = new int[9] { 20, 20, 2, 25, 25, 5, 0, 0, 3 };
            }
        }

        // Draw a random int in 0..99 range.
        int rand = Random.Range(0, 100);
        int rangeStart = 0;

        for (int n = 0; n < spaceObjects.Length; n++)
        {
            // Calculate this object's chance range.
            int rangeEnd = rangeStart + chances[n];

            if (rand >= rangeStart && rand < rangeEnd)
            {
                // If random number inside the range, create the corresponding prefab.

                Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), spawnPosY, spawnPosZ);

                Instantiate(spaceObjects[n], spawnPos, spaceObjects[n].transform.rotation);
            }

            // Next range right after the current one.
            rangeStart = rangeEnd;
        }
    }
}