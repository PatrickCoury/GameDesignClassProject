using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayHealth : MonoBehaviour
{
    private GameObject player;
    public Text healthText;
    void Start()
    {
       
    }
    void Update()
    {
        player = GameObject.Find("Player(Clone)");
        healthText.text = "HP: " + player.GetComponent<Player>().currentHP;
    }
}
