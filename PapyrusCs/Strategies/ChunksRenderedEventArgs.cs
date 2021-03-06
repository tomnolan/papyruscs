﻿using System;

namespace PapyrusCs.Strategies
{
    public class ChunksRenderedEventArgs : EventArgs
    {
        public ChunksRenderedEventArgs(int renderedChunks)
        {
            RenderedChunks = renderedChunks;
        }

        public int RenderedChunks { get; }
    }
}