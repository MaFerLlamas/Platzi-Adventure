using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToPlace : MonoBehaviour
{
    public string newPlaceName = "New Scene Name";
    public string goToPlaceName = "go To place name";
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.tag.Equals("Player")){
            FindObjectOfType<PlayerController>().nextPlaceName = goToPlaceName;
            SceneManager.LoadScene(newPlaceName);
        }
    }
    
}
