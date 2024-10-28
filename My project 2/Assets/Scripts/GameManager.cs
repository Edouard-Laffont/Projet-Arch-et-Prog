using System;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject menu;
    [SerializeField] private GameObject game;
    public enum GameState
    {
        Menu,
        Game
    }

    public GameState m_currentGameState = GameState.Menu;

    public void ChangeGameState(GameState newGameState)
    {
        switch (m_currentGameState)
        {
            case GameState.Menu: DisableMenu(); break;
            case GameState.Game: DisableGame(); break;
        }
        m_currentGameState = newGameState;
        switch (newGameState)
        {
            case GameState.Menu: SetupMenu(); break;
            case GameState.Game: SetupGame(); break;
        }
    }

    public void DisableMenu()
    {
        menu.SetActive(false);
    }
    public void DisableGame()
    {
        game.SetActive(false);
    }

    public void SetupMenu()
    {
        menu.SetActive(true);
    }

    public void SetupGame()
    {
        game.SetActive(true);
    }
}