﻿using Paint.Tools;

namespace Paint
{
    internal class ToolState
    {
        public bool IsActive { get; set; }
        public int BrushSize { get; set; }
        public ITool CurrentTool { get; set; }

        public ToolState(int brushSize)
        {
            this.BrushSize = brushSize;
            this.IsActive = false;
        }
    }

}
