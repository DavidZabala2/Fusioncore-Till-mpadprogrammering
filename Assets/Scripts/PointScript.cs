using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PointScript : MonoBehaviour {
    public int points = 0;
    public AudioSource sound;
    
    
	// Use this for initialization
	void Start () {
        sound = GetComponent<AudioSource>();
	}

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 90 * Time.deltaTime, 75 * Time.deltaTime);
        
    }
  
    public void OnTriggerEnter(Collider other)
    {
         
        if (other.name == "Player1")
        {
            sound.Play();
            points += points;

            Destroy(gameObject);
        }
    }
    

}
