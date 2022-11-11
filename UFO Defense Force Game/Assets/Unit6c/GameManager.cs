using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
   public bool isGameOver;

   private GameObject gameOverText;

   private void Awake()
   {
      Time.timeScale = 1;
      isGameOver = false;
   }

   private void Start()
   {
      gameOverText = GameObject.Find("GameOverText");
   }

   private void Update()
   {
      if (isGameOver)
      {
         EndGame();
      }
      else gameOverText.gameObject.SetActive(false);
   }

   public void EndGame()
   {
      gameOverText.gameObject.SetActive(true);
      Time.timeScale = 0;
   }
}
