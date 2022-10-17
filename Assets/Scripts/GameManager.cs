using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    private int _score = -2;
    [SerializeField] private Text scoreText;
    [SerializeField] private Text menuTitleText;
    [SerializeField] private GameObject menu;
    [SerializeField] private Transform platformSpawn;
    private bool _gameOver;
    private bool _menuing;
    
    void Start()
    {
        _gameOver = false;
        menu.SetActive(false);
        SetUpScene();
        Time.timeScale = 1;
        StartCoroutine(InstantiateNextPlatform(1.5f, 100));
    }

    private void Update()
    {
        if (_gameOver)
        {
            Time.timeScale = 0;
            menuTitleText.text = "You Lose";
            _menuing = true;
            menu.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Escape) && !_gameOver)
        {
            if (_menuing)
            {
                
                _menuing = false;
                menu.SetActive(false);
                Time.timeScale = 1;
            }
            else
            {
                Time.timeScale = 0;
                menuTitleText.text = "Pause";
                _menuing = true;
                menu.SetActive(true);
            }
        }
    }

    private void SetUpScene()
    {
        Instantiate(Resources.Load("Prefabs/BasePlatform"));
        Instantiate(Resources.Load("Prefabs/Wizard"),transform);
    }
    
    public IEnumerator InstantiateNextPlatform(float interval, int invokeCount)
    {
        for (int i = 0; i < invokeCount; i++)
        {
            GameObject nextPlatform = Resources.Load("Prefabs/Platform") as GameObject;
            nextPlatform.transform.localScale = new Vector3(Random.Range(3,6), Random.Range(2,4), 1);
            Instantiate(nextPlatform,platformSpawn);
            _score += 1;
            if (_score >= 0)
            {
                scoreText.text = "Score : "+_score.ToString();
            }
            yield return new WaitForSeconds(interval);
        }
    }

    public void SetGameOver()
    {
        _gameOver = true;
    }
}
