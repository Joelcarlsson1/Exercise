using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Övning : MonoBehaviour
{
    public float userValue;
    int die1;
    int die2;
    public int score;
    public int startscore = 10;
    int dragonHp1;
    int dragonHp2;
    int playerHp = 100;
    int hitChance1;
    int hitChance2;
    int dragonDmg1;
    int dragonDmg2;
    int playerDMG;
    int twoDragons;
    public bool randomPlayerDmg;
    int minDmg;
    int maxDmg;
    int playerCritChance;
    public int gameValue;
    public int streak;
    public int highscore;
    int guessValue;
    public bool isPlaying;

    // Use this for initialization
    void Start()
    {
        print("Leftarrow = Add 2 to your value");
        print("Rightarrow = Divide your value by 2");
        print("Uparrow = Print your value");
        print("Press R to throw 2 dices");
        print("Press Spacebar to fight the dragon");
        print("Press Y to guess that the next value is higher");
        print("Press H to guees that the next value is lower");
        
        score = startscore;
        dragonHp1 = Random.Range(100, 151);
        dragonHp2 = Random.Range(100, 151);
        playerHp = 100;
        print("The first dragon has " + dragonHp1 + " HP this game");
        twoDragons = Random.Range(1, 11);
        if (twoDragons == 1)
        {
            print("You face two dragons this round");
            print("The second dragon has " + dragonHp2 + " Hp this game");
        }

    }

    // Update is called once per frame
    void Update()
    {
        uppgift1();
        uppgift2();
        uppgift3();
        uppgift4();
    }



    //varför läser du detta?
    void uppgift1()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            userValue = (userValue + 2);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            userValue = (userValue / 2);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            print(userValue);
        }
    }
    void uppgift2()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            die1 = Random.Range(1, 7);
            die2 = Random.Range(1, 7);
            score = score + (die1 - die2);
            if (score >= 20)
            {
                print("You win");
            }
            if (score <= 0)
            {
                print("You lose");
            }

            else
            {
                print(score);
            }
        }
    }
    void uppgift3()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (twoDragons == 1)
            {
                print("The first dragon attacks");
                hitChance1 = Random.Range(1, 3);
                hitChance2 = Random.Range(1, 3);
                if (hitChance1 == 1)
                {
                    print("The dragon misses");
                }
                if (hitChance1 == 2)
                {
                    dragonDmg1 = Random.Range(10, 21);
                    print("The dragon hits for " + dragonDmg1 + " damage");
                    playerHp = playerHp - dragonDmg1;
                    print("You have " + playerHp + " Hp left");
                }
                print("The second dragon attacks");
                if (hitChance2 == 1)
                {
                    print("The dragon misses");
                }
                if (hitChance2 == 2)
                {
                    dragonDmg2 = Random.Range(10, 21);
                    print("The dragon hits for " + dragonDmg2 + " damage");
                    playerHp = playerHp - dragonDmg2;
                    print("You have " + playerHp + " Hp left");
                }


                if (playerHp <= 0)
                {
                    print("The dragon killed you");
                }
                if (dragonHp1 <= 0)
                {
                    print("The first dragon died");
                }
                if (dragonHp2 <= 0)
                {
                    print("The second dragon died");
                }
                print("You attack");
                if (randomPlayerDmg == true)
                {
                    minDmg = Random.Range(1, 11);
                    maxDmg = Random.Range(11, 30);
                }
                if (randomPlayerDmg == false)
                {
                    minDmg = 5;
                    maxDmg = 25;
                }
                playerDMG = Random.Range(minDmg, maxDmg);
                if (dragonHp1 >= 0)
                {
                    print("You hit the first dragon for " + playerDMG + " damage");
                    playerCritChance = Random.Range(1, 21);
                    if (playerCritChance == 1)
                    {
                        dragonHp1 = 0;
                        print("The hit was a critical strike");
                    }
                    if (playerCritChance >= 1)
                    {
                        dragonHp1 = dragonHp1 - playerDMG;
                        print("The first dragon has " + dragonHp1 + " HP left");
                    }
                }
                if (dragonHp1 <= 0)
                {
                    print("You hit the second dragon for " + playerDMG + " damage");
                    playerCritChance = Random.Range(1, 21);
                    if (playerCritChance == 1)
                    {
                        dragonHp1 = 0;
                        print("The hit was a critical strike");
                    }
                    if (playerCritChance >= 1)
                    {
                        dragonHp2 = dragonHp2 - playerDMG;
                        print("The second dragon has " + dragonHp2 + " HP left");
                    }
                }
            }

            if (twoDragons > 1)
            {
                print("The dragon attacks");
                hitChance1 = Random.Range(1, 3);
                if (hitChance1 == 1)
                {
                    print("The dragon misses");
                }
                if (hitChance1 == 2)
                {
                    dragonDmg1 = Random.Range(10, 21);
                    print("The dragon hits for " + dragonDmg1 + " damage");
                    playerHp = playerHp - dragonDmg1;
                    print("You have " + playerHp + " Hp left");
                }
                if (playerHp <= 0)
                {
                    print("The dragon killed you");
                }
                if (dragonHp1 <= 0)
                {
                    print("The dragon died");
                }
                print("You attack");
                if (randomPlayerDmg == true)
                {
                    minDmg = Random.Range(1, 11);
                    maxDmg = Random.Range(11, 30);
                }
                if (randomPlayerDmg == false)
                {
                    minDmg = 5;
                    maxDmg = 25;
                }
                playerDMG = Random.Range(minDmg, maxDmg);
                print("You hit the dragon for " + playerDMG + " damage");
                dragonHp1 = dragonHp1 - playerDMG;
                print("The dragon has " + dragonHp1 + " HP left");
            }
        }
    }
    void uppgift4()
    {
        if (isPlaying == false)
        {
            gameValue = 50;
            isPlaying = true;
        }

        if (Input.GetKeyDown(KeyCode.Y) || Input.GetKeyDown(KeyCode.H))
        {
            guessValue = Random.Range(0, 101);
        }
        if (Input.GetKeyDown(KeyCode.Y) && gameValue <= guessValue)
        {
            print("You guessed right");
            streak = streak + 1;
            gameValue = guessValue;
            print("The value was " + gameValue);
            print("Your streak is " + streak);
        }
        else if (Input.GetKeyDown(KeyCode.Y) && gameValue >= guessValue)
        {
            print("You guessed wrong");
            print("The value was " + guessValue);
            print("Your streak was " + streak);
            print("Your highscore is " + highscore);
            streak = 0;
        }
        else if (Input.GetKeyDown(KeyCode.H) && gameValue >= guessValue)
        {
            print("You guessed right");
            streak = streak + 1;
            gameValue = guessValue;
            print("The value was " + guessValue);
            print("Your streak is " + streak);
        }
        else if (Input.GetKeyDown(KeyCode.H) && gameValue <= guessValue)
        {
            print("You guessed wrong");
            print("The value was " + guessValue);
            print("Your streak was " + streak);
            print("Your highscore is " + highscore);
            streak = 0;
        }
        if (streak > highscore)
        {
            highscore = streak;
        }
    }
}
