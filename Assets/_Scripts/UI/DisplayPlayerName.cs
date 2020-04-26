using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DisplayPlayerName : MonoBehaviour
{
    [SerializeField] public GameObject player;
    [SerializeField] public TextMeshProUGUI playerName;
    void Start()
    {
        playerName.text = player.GetComponent<Player>().getCharacter().getName();
    }

}
