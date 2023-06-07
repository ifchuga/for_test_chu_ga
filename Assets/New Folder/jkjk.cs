using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jkjk : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player1 = new Player();
        player1.health = 5;
        player1.damage =10;

        player1.Attack();
        
        Player player2 = new Player();
        player2.health = 10;
        player2.damage = 8;
    }
}
