﻿using System.Diagnostics;

namespace Vim.UI.Wpf.Implementation.RelativeLineNumbers
{
    [DebuggerDisplay("{Number} {Baseline}")]
    internal readonly struct Line
    {
        public int Number { get; }

        public double Baseline { get; }

        public bool IsCaretLine { get; }

        public Line(int number, double verticalBaseline, bool isCaretLine)
        {
            Number = number;
            Baseline = verticalBaseline;
            IsCaretLine = isCaretLine;
        }
    }
}
