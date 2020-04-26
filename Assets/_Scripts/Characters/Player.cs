using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    private Character character = new Character(new int[] { 10, 3, 2, 3, 2, 3, 0, 0 }, "Player", true);
    private int bullets = 3;
    private bool incap = false;
    private bool ready = false;
    void Start()
    {
        
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int HP = character.getCurrentHP();
            character.setCurrentHP(HP - 1);
            if (HP <= 0)
            {
                incap = true;
            }
        }
    }

    //getters and setters
    public Character getCharacter()
    {
        return character;
    }
    public void setCharacter(Character character)
    {
        this.character = character;
    }
    public bool getReady()
    {
        return ready;
    }
    public void setReady(bool ready)
    {
        this.ready = ready;
    }
    public int getBullets()
    {
        return bullets;
    }
    public void setBullets(int bullets)
    {
        this.bullets = bullets;
    }
}
