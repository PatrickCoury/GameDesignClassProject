using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerHPSlider : MonoBehaviour
{
    private Player player;
    [SerializeField] public Slider slider;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player(Clone)").GetComponent<Player>();
        slider.maxValue = player.getCharacter().getSpecStat("HP");
        
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = player.getCharacter().getCurrentHP();
    }
}
