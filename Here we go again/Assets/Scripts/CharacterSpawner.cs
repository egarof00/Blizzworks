using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterSpawner : MonoBehaviour
{
    public GameObject[] Characters;
    public Transform PlayerSpawnPoint;
    void Start() {
        Instantiate(Characters[CharacterSelect.PlayerNum], PlayerSpawnPoint.position, PlayerSpawnPoint.rotation);
    }

}
