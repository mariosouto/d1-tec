namespace Domain
{
    public class Calculator
    {
        public int Result { get; }

        public Calculator(int initialResult = 0)
        {
            this.Result = initialResult;
        }

        public int Sum(int firstNumer, int secondNumber) => firstNumer + secondNumber;

        public int Divide(int firstNumber, int secondNumber)
        {
            if (secondNumber == 0) throw new CannotDivideByZeroException();

            return firstNumber / secondNumber;
        }

        public int Multiply(int firstNumber, int secondNumber) => firstNumber * secondNumber;

        public int Substract(int firstNumber, int secondNumber) => firstNumber - secondNumber;

        public Calculator SumBy(int number) => new Calculator(this.Result + number);

        public Calculator MultiplyBy(int number) => new Calculator(this.Result * number);

        public Calculator DivideBy(int number)
        {
            if (number == 0) throw new CannotDivideByZeroException();

            return new Calculator(this.Result / number);
        }

        public Calculator SubstractBy(int number) => new Calculator(this.Result - number);
    }
}
