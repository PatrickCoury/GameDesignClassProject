using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : Stats
{
    private Stats stats;
    private string name;
    private bool onTeam;
    private int currentHP;
    //constructor
    public Character(int[] stats, string name, bool onTeam) : base(stats)
    {
        this.stats = new Stats(stats);
        this.name = name;
        this.onTeam = onTeam;
        this.currentHP = getSpecStat("HP");
    }
    //getters and setters
    public Stats getStats()
    {
        return stats;
    }
    public bool getOnTeam()
    {
        return onTeam;
    }
    public void setStats(Stats stats)
    {
        this.stats = stats;
    }
    public void setOnTeam(bool bruh)
    {
        onTeam = bruh;
    }
    public void setName(string name)
    {
        this.name = name;
    }
    public string getName()
    {
        return name;
    }
    public int getCurrentHP()
    {
        return currentHP;
    }
    public void setCurrentHP(int currentHP)
    {
        this.currentHP = currentHP;
    }
}
