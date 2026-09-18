using System;
using System.Collections.Generic;
using System.Text;

namespace Bài_3
{
    internal class Class2
    {
        private Class1 die1;
        private Class1 die2;

        public Class2()
        {
            die1 = new Class1();
            die2 = new Class1();
        }

        public void Roll()
        {
            die1.roll();
            die2.roll();
        }
        /// <summary>
        /// Tổng số điểm của hai con xúc xắc
        /// </summary>
        public int GetPoints()
        {
            return die1.Face + die2.Face;
        }
        public bool IsBothOne()
        {
            return die1.Face == 1 && die2.Face == 1;
        }
        public bool IsBothSix()
        {
            return die1.Face == 6 && die2.Face == 6;
        }
        public override string ToString()
        {
            return $"Die 1: {die1.Face}, Die 2: {die2.Face}, Total: {GetPoints}";
        }
    }
}
