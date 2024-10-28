using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class MenuUI : MonoBehaviour
{
    [SerializeField] private Button boutonplay;
    [SerializeField] private GameManager m_GameManager;
    public void GoToGame()
    {
        
    }

    public void ClickOnPlay()
    {
        m_GameManager.ChangeGameState(GameManager.GameState.Game);
    }
}
