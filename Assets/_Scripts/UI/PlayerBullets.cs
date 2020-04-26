using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBullets : MonoBehaviour
{
    private Player player;
    [SerializeField] public Slider slider;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player(Clone)").GetComponent<Player>();
        slider.maxValue = player.getBullets();
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = player.getCharacter().getCurrentHP();
    }
}
