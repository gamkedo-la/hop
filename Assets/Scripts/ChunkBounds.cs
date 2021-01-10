﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkBounds : MonoBehaviour
{
    public bool chunkStart = true;
    public bool chunkEnd = false;

    private bool chunkStartPrevValue;
    private bool chunkEndPrevValue;

    private void OnValidate()
    {
        // Only allow either chunk start or chunk end to be selected. Should create custom editor for this, but did it this way for now
        if (chunkStart != chunkStartPrevValue)
        {
            chunkStartPrevValue = chunkStart;
            chunkEnd = !chunkStart;
            chunkEndPrevValue = chunkEnd;
        }

        if (chunkEnd != chunkEndPrevValue)
        {
            chunkEndPrevValue = chunkEnd;
            chunkStart = !chunkEnd;
            chunkStartPrevValue = chunkStart;
        }
    }
}
