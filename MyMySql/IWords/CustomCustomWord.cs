﻿using MyMySql.ICustomWords;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyMySql.IWords.ICustomWords
{
    [DebuggerDisplay("CustomCustomInput = {Input}")]
    public class CustomCustomWord : IWord
    {
        public string Input { get; set; }

        public WordTypes WordType { get; set; }

        public Type VarType { get; set; }

        public IComparable Data { get; set; }

        public AllWordTypes AllWordType { get; set; }

        public Func<IWord,  IWord, ParseSyntaxInfo> ParseSyntax { get; set; }

        public List<List<WordRange>> ChildrenRanges { get; set; }

        public List<IWord> Children { get; set; }

        public List<IWord> WordsThisCouldBe { get; set; }
        public bool Initializing { get; set; }
        public List<WordRange> RangesThatWorked { get; set; }
        public CustomCustomWord(string input, Type varType, IComparable data, Func<IWord, IWord, ParseSyntaxInfo> parseSyntax)
        {
            Input = input;
            WordType = WordTypes.CustomCustom;
            VarType = varType;
            Data = data;
            AllWordType = AllWordTypes.CustomCustom;
            ParseSyntax = parseSyntax;

            ChildrenRanges = new List<List<WordRange>>();
            Children = new List<IWord>();
            WordsThisCouldBe = new List<IWord>();
            Initializing = false;
            RangesThatWorked = null;
        }
        
    }
}