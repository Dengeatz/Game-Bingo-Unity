﻿using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class BingoCard
{
    public string Dorama;
    public Vector2Int Size;
    public BingoCell[] Cells;

    public int Hearts = 5;
    public int Scores;

    public List<BingoCell> GetActiveCells()
    {
        List<BingoCell> result = new();

        foreach(BingoCell cell in Cells)
        {
            if (!cell.IsNeutral && cell.IsCorrect)
                result.Add(cell);
        }

        return result;
    }
}
