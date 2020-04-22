using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayHealth : MonoBehaviour
{
    private Player player;
    public TextMeshProUGUI healthText;
    void Start()
    {
        healthText = gameObject.GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        player = GameObject.Find("Player(Clone)").GetComponent<Player>();
        healthText.text = "HP: " + player.currentHP+"/"+player.getSpecStat("HP");
    }
}
