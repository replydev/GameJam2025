using System;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    
    public GameObject childMoves;
    public GameObject monsterMoves;

    public ExitDirection exitDirection;
    
    private bool directionThisTurn = false;
    
    private void Awake()
    {
        Instance = this;
    }

    void OnEnable()
    {
        StateManager.Instance.OnRoundCompleted += RoundCompleted;
    }

    private void OnDisable()
    {
        StateManager.Instance.OnRoundCompleted -= RoundCompleted;
    }

    private void RoundCompleted()
    {
        if (directionThisTurn)
            directionThisTurn = false;
        else
            exitDirection.gameObject.SetActive(false);
        
        if (Globals.PlayerType == PlayerType.Child)
            childMoves.SetActive(true);
        else
            monsterMoves.SetActive(true);
        
    }

    public void ShowExitDirection()
    {
        Debug.Log("check wind");
        directionThisTurn = true;
        exitDirection.gameObject.SetActive(true);
        exitDirection.ShowExitDirection();
    }
}
