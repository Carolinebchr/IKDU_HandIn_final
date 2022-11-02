using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerName : MonoBehaviour
{
    //Defining my PlayerName
    public string CharName_C = "Caro";
    //Defining Level with initial value of 1 
    private int Caro_lvl = 1;
    private int Caro_lvup = 1;


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Player name is: " + CharName_C); //Printing the player name in the console

        Charinfo(CharName_C,Caro_lvl,Caro_lvup); //Call upon Charinfo with pre-defined variables

        Charinfo("Nathan", 5 , 1 );

        Charinfo("Ash", 20, 1);
        //Call upon Charinfo with cuztom variables,
        //Where the first parameter is a string with the value "Nathan",
        //2nd & 3rd Parameter is an int, as the method requires (String,int,int).

    }

    // Update is called once per frame
    void Update()
    {

    }
    
    //Defining Method/Function with 3 parameters Name, Level, Level after leveling up.
    void Charinfo(string Name,int Level,int lvlup)
    {
        Level = lvlup + Level;
        Debug.Log("Player " + Name + " is now Level: " + Level);
    }

}



