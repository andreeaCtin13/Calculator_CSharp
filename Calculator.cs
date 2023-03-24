using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorCSharp
{
    public enum operation { none, add, minus, multiplicate, divide, equal };

    public class Calculator
    {
        private int total;
        private operation op;
        private int operand1;
        private int operand2;

        public Calculator() {
            this.total = 0;
            this.op = operation.none;
            this.operand1 = 0;
            this.operand2 = 0;
        }

        public void Reset(int total)
        {
            this.total = total;
            this.operand1 = 0;
            this.operand2 = 0;
        }

        public int Operand1
        {
            get { return this.operand1; }
            set { this.operand1 = value; }
        }

        public int Operand2
        {
            get { return this.operand2; }
            set { this.operand2 = value; }
        }

        public void Add()
        {
            this.total += this.operand1+this.operand2;
        }

        public void Minus()
        {
            this.total += this.operand1 - this.operand2;
        }

        public void Multiplicate()
        {
            this.total += this.operand1 * this.operand2;
        }

        public void Divide()
        {
            this.total += this.operand1 / this.operand2;
        }

        public int Total
        {
            get { return this.total; }
        }


        public operation Op
        {
            get { return this.op; }
            set { this.op = value; }
        }

    }
}
