using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Affinity can be one of five elements: Earth: ID 1, Electric: ID 2, Water: ID 3, Fire: ID 4, and No Affinity: ID 0. 5 is reserved for no strength or weakness.
public class Affinity
{
    private int strength = 5;
    private int weakness = 5;
    private int id;
    private string name;
    public Affinity(int id)
    {
        //loads id into object
        this.id = id;

        //loads name, strengths and weaknesses into object
        switch (id)
        {
            case 1:
                this.strength = 2;
                this.weakness = 4;
                this.name = "Earth";
                break;
            case 2:
                this.strength = 3;
                this.weakness = 1;
                this.name = "Electric";
                break;
            case 3:
                this.strength = 4;
                this.weakness = 2;
                this.name = "Water";
                break;
            case 4:
                this.strength = 1;
                this.weakness = 3;
                this.name = "Fire";
                break;
            case 0:
                this.name = "No Affinity";
                break;
            default:
                Debug.Log(id + " is not an affinity");
                break;
        }
    }
    public override string ToString()
    {
        return this.name + " ID: " + this.id;
    }
    //so I dont have to remember whats good and bad against what
    public bool isStrength(int strength)
    {
        if (strength == 5) return false;
        else
        {
            return this.strength == strength;
        }
    }
    public bool isWeak(int weakness)
    {
        if (weakness == 5) return false;
        else
        {
            return this.weakness == weakness;
        }
    }
}
