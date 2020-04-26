using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerTimeSlider : MonoBehaviour
{
    private Player player;
    [SerializeField] public Slider slider;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player(Clone)").GetComponent<Player>();
        slider.value = 0;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value += (float).01*player.getCharacter().getSpecStat("Speed");
        if(slider.value == slider.maxValue && !player.getReady())
        {
            player.setReady(true);
        }
    }
}
