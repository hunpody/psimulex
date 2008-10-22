using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using VapeTeam.Psimulex.Core.Factories;
using VapeTeam.Psimulex.Core;
using VapeTeam.Psimulex.Compiler.AST;

namespace VapeTeam.Psimulex.Compiler.Result
{
    public static class SourceInfoUtils
    {
        public static List<int> FindLineLengths(string source)
        {
            List<int> returnList = new List<int>();
            returnList.Add(0);

            int len = 0;
            for (int i = 0; i < source.Length; ++i)
            {
                if (source[i] == '\n')
                {
                    returnList.Add(len + 1);
                    len = -1;
                }
                len++;
            }

            return returnList;
        }

        public static int CountEndOfLines(string source)
        {
            int count = 0;
            foreach (var ch in source)
                if (ch == '\n')
                    count++;
            return count;
        }

        public static Interval CreateInterval(IPsiNode node, string source, List<int> lineLengthList)
        {
            return CreateInterval(node, source, lineLengthList, "");
        }

        public static Interval CreateInterval(IPsiNode node, string source, List<int> lineLengthList, string fileName)
        {
            Interval range =
                    new Interval
                    {
                        FileName = fileName,

                        FromLine = node.NodeValueInfo.StartLine,
                        FromColumn = node.NodeValueInfo.StartColumn,
                        ToLine = node.NodeValueInfo.EndLine,
                        ToColumn = node.NodeValueInfo.EndColumn,
                    };

            range.StartIndex = 0;
            for (int i = 1; i < node.NodeValueInfo.StartLine; i++)
                range.StartIndex += lineLengthList[i];

            range.StartIndex += node.NodeValueInfo.StartColumn;

            range.EndIndex = 0;
            for (int i = 1; i < node.NodeValueInfo.EndLine; i++)
                range.EndIndex += lineLengthList[i];

            range.EndIndex += node.NodeValueInfo.EndColumn;

            // Is it a Leaf Virtual Node or not
            if (range.StartIndex != -1 && range.EndIndex != -1)
                CorrectSelectionIntervalWithFindingClosingChar(range, source);

            return range;
        }

        public static void CorrectSelectionIntervalWithFindingClosingChar(Interval interval, string source)
        {
            int start = interval.StartIndex;
            int end = interval.EndIndex;

            end += FindCharPositionExpceptedChars(end, '(', ";)tTiI",source);


            int parenthesises = 0;		// ()
            int brackets = 0;			// []

            int i = start;
            while ((i < source.Length) && (i < end || parenthesises > 0 || brackets > 0))
            {
                switch (source[i])
                {
                    case '(':
                        ++parenthesises;
                        break;
                    case ')':
                        if (parenthesises > 0)
                            --parenthesises;
                        break;
                    case '[':
                        ++brackets;
                        break;
                    case ']':
                        if (brackets > 0)
                            --brackets;
                        break;
                }
                ++i;
            }

            //while (i < Source.Length && Source[i].ToString().ToLower() != closingChar.ToString().ToLower())
            //    ++i;

            interval.EndIndex = i;
        }

        public static int FindCharPositionExpceptedChars(int from, char findChar, string excepts, string source)
        {
            int ind = 0;
            while (from + ind < source.Length)
            {
                if (excepts.Contains(source[from + ind].ToString()))
                    return 0;

                char ch = source[from + ind];
                if (ch == findChar)
                    return ind + 1;

                ind++;
            }
            return 0;
        }

    }
}
