using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats
{
    private Dictionary<string, int> dict = new Dictionary<string, int>(); //variable holding the stats of object
    private Affinity affinity;

    public Stats(int[] stats)
    {

        if (stats.Length != 8)//check that array is correct
        {
            Debug.Log("stats have not been initialized");
        }
        else
        {
            /*starting object stats in an array
            *HP = stats[0]
            *Strength = stats[1]
            *Toughness = stats[2]
            *Shooting = stats[3]
            *Resistance = stats[4]
            *Speed = stats[5]
            *Luck = stats[6]
            *AffinityID = stats[7]*/
            this.dict.Add("HP", stats[0]);
            this.dict.Add("Strength", stats[1]);
            this.dict.Add("Toughness", stats[2]);
            this.dict.Add("Shooting", stats[3]);
            this.dict.Add("Resistance", stats[4]);
            this.dict.Add("Speed", stats[5]);
            this.dict.Add("Luck", stats[6]);
            this.affinity = new Affinity(stats[7]);
        }
    }
    //getters and setters
    public int getSpecStat(string key)
    {
        return dict[key];
    }
    public Affinity getAffinity()
    {
        return affinity;
    }
    public void setDict(string key, int value)
    {
        dict[key] = value;
    }
    public void setAffinity(int id)
    {
        affinity = new Affinity(id);
    }
    public override string ToString()
    {
        return "HP = " + dict["HP"] +
             "\nStrength = " + dict["Strength"] +
             "\nToughness = " + dict["Toughness"] +
             "\nShooting = " + dict["Shooting"] +
             "\nResistance = " + dict["Resistance"] +
             "\nSpeed = " + dict["Speed"] +
             "\nLuck = " + dict["Luck"] +
             "\n"+affinity;
    }
}
