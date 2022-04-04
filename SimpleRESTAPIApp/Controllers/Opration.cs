namespace SimpleRESTAPIApp.Controllers
{
    public class Opration
    {
        private double _valueone;
        private double _valueTwo;
        public Opration(double valueOne, double valueTwo)
        {
            this._valueone = valueOne;
            this._valueTwo = valueTwo;
        }
        internal double Sum()
        {
            return this._valueone + this._valueTwo;
        }

        internal double Subtract()
        {
            return this._valueone - this._valueTwo;
        }
        internal double Multiply()
        {
            return this._valueone * this._valueTwo;
        }
        internal double Divide()
        {
            return this._valueone / this._valueTwo;
        }
    }
}
