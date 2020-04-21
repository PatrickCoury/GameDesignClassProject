using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Stats stats = new Stats("Player", new int[] { 10, 3, 2, 3, 2, 3, 0, 0}); //gives name to player and list of starting stats
    public int currentHP;
    // Start is called before the first frame update
    void Start()
    {
        currentHP = this.getSpecStat("HP");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            currentHP--;
        }
    }

    //getters and setters
    public Stats getStats()
    {
        return stats;
    }
    public int getSpecStat(string key)
    {
        return stats.getDict(key);
    }
    public int getCurrentHP()
    {
        return currentHP;
    }
    public void setStats(Stats stats)
    {
        this.stats = stats;
    }
}
