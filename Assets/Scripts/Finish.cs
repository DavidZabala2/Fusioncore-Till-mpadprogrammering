using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour {
    public int points = 0;
    public int maxPoints;
    private int nextScene;
   
    public ParticleSystem spark;

    private void Start()
    {
        nextScene = SceneManager.GetActiveScene().buildIndex + 1;
        
    }

    private void OnTriggerEnter(Collider other)
    {
        PointScript coin = other.GetComponent<PointScript>();
        points = coin.points;
        if (points >= maxPoints)
        {
            GameObject.Find("Player1").SendMessage("Finish");
            SceneManager.LoadScene(nextScene);
            coin.points = 0;
            points = 0;
        }
       

        
    }
}
