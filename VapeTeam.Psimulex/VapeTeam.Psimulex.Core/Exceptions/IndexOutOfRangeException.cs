using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VapeTeam.Psimulex.Core.Exceptions
{
    public class IndexOutOfRangeException : PsimulexCoreException
    {
        public IndexOutOfRangeException(int index, int lowerBound, int upperBound)
            :this (string.Format("Index {0} was out of range ({1}..{2}).", index, lowerBound, upperBound))
        {
        }

        public IndexOutOfRangeException(string message)
            : base(message)
        {

        }

        public IndexOutOfRangeException()
            : this("Index was out of range.")
        {

        }
    }}
