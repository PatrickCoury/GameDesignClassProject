using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DisplayHealth : MonoBehaviour
{
    private Character player;
    public TextMeshProUGUI healthText;
    void Start()
    {
        healthText = gameObject.GetComponent<TextMeshProUGUI>();
    }
    void Update()
    {
        player = GameObject.Find("Player(Clone)").GetComponent<Player>().getCharacter();
        healthText.text = player.getCurrentHP()+"/"+player.getSpecStat("HP");
    }
}
