using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI health;
    [SerializeField] private TextMeshProUGUI kills;
    [SerializeField] private TextMeshProUGUI gameOver;

    public static UIManager Instance { get; private set; }

    private void Awake(){
        // If there is an instance, and it's not me, delete myself.
        
        if (Instance != null && Instance != this) 
        { 
            Destroy(this); 
        } 
        else 
        { 
            Instance = this; 
        } 
    }

    public void UpdateHealth(int health_int){
        health.SetText(string.Format("Health: {0}", health_int));
    }

    public void UpdateKills(int kills_int){
        kills.SetText(string.Format("Kills: {0}", kills_int));
    }

    public void GameOver(){
        gameOver.gameObject.SetActive(true);
    }
}
