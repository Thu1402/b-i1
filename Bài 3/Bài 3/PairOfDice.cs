using System;
using System.Collections.Generic;
using System.Text;

namespace Bài_3.Bài_3_1
{
    internal class PairOfDice
    {
        private Die die1;
        private Die die2;

        public PairOfDice()
        {
            die1 = new Die();
            die2 = new Die();
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
            return $"Die 1: {die1.Face}, Die 2: {die2.Face}, Total: {Total}";
        }
    }
}
