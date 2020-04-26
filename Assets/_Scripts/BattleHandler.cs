using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleHandler : MonoBehaviour
{
    [SerializeField] public GameObject pfPlayer;
    [SerializeField] public GameObject pfEnemy;
    // Start is called before the first frame update
    void Awake()
    {
        SpawnCharacter(pfPlayer);
        SpawnCharacter(pfEnemy);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void SpawnCharacter(GameObject character)
    {
        Vector3 position;
        string id = character.tag;
        switch (id)
        {
            case "Player":
                position = new Vector3(-50, 0, 1);
                break;
            case "Enemy":
                position = new Vector3(50, 0, 1);
                break;
            default:
                position = new Vector3(0, 0, 1);
                break;
        }
        Instantiate(character, position, Quaternion.identity);
    }
}
