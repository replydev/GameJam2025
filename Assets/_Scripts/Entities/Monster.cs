﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : Entity
{
    [Range(1, 5)] public int MoveDistance;
    [Range(1, 5)] public int AttackDistance;

    private void Awake()
    {
        Globals.Monster = this;
    }

    public override IEnumerator C_ExecuteChoice(Choice choice)
    {
        IsExecuting = true;
        switch (choice.actionType)
        {
            case EntityActionType.Move:
                yield return StartCoroutine(C_Move(choice.PositionsPath));
                break;
            case EntityActionType.Attack:
                yield return StartCoroutine(C_Attack(choice.PositionsPath));
                break;
        }
        IsExecuting = false;
    }

    private IEnumerator C_Move(List<Vector3> positionsPath)
    {
        throw new System.NotImplementedException();
    }
    private IEnumerator C_Attack(List<Vector3> positionsPath)
    {
        throw new System.NotImplementedException();
    }
}