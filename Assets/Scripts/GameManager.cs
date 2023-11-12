using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Health player1;
    public Health player2;
    public string DieScene;

    private void Update()
    {
        Invoke("Die", 3f);
    }
    public void Die()
    {
        if (player1.health == 0 || player2.health == 0)
        {
            SceneManager.LoadScene(DieScene);

        }
    }

}
