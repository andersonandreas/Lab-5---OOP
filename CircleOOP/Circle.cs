namespace CircleOOP
{
    public class Circle
    {

        private double _Radius;

        public Circle(double radie)
        {
            _Radius = radie;
        }

        public float getArea() => (float)(_Radius * _Radius * Math.PI);

    }

}


