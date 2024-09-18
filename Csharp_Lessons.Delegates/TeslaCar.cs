namespace Csharp_Lessons.Delegates;

public class TeslaCar
    {
        private float _curSpeed;
        private float _acceleration;
        private readonly float _maxSpeed = 45f;

        #region OverVariants
        /*
         Способ 1-ый, чистое использование делегата с инкапсуляцией ссылок на методы
        public delegate void CheckSpeed(object obj, float speed);
        private CheckSpeed? SpeedUp { get; set; }
        private CheckSpeed? SpeedDown { get; set; }

        public TeslaCar(CheckSpeed? speedUp, CheckSpeed? speedDown) : this()
        {
            if (speedUp != null) SpeedUp += speedUp;
            if (speedDown != null) SpeedDown += speedDown;
        }
        */

        /*
            Способ 2-ой, чистое использование делегата, только ссылки публичны, мы сами можем извне подписываться и отписывать, и если надо вызывать
        public delegate void CheckSpeed(object obj, float speed);
        public CheckSpeed? SpeedUp;
        public CheckSpeed? SpeedDown;

        public TeslaCar(CheckSpeed? speedUp, CheckSpeed? speedDown) : this()
        {
            if (speedUp != null) SpeedUp += speedUp2;
            if (speedDown != null) SpeedDown += speedDown2;
        }
        */

        /*
          Способ 3-ий, представление делегата ввиде action обертки, можно также подписываться из вне
        public event Action<object, float>? SpeedUp;
        public event Action<object, float>? SpeedDown;

        public TeslaCar(Action<object, float>? speedUp, Action<object, float>? speedDown) : this()
        {
            if (speedUp != null) SpeedUp += speedUp1;
            if (speedDown != null) SpeedDown += speedDown1;
        }
        */

        /*
        Способ 4-ый, представление делегата ввиде Func обертки, можно также подписываться из вне, исполььзвуется для передачи параметров и возвращения значения
        public event Func<float, float> ControlUpFunc; // передаем float и возвращаем float
        public event Func<float, float> ControlDownFunc;

        public TeslaCar(Func<float, float>? controlUpFunc, Func<float, float>? controlDownFunc) : this()
        {
            if (controlUpFunc != null) ControlUpFunc += controlUpFunc;
            if (controlDownFunc != null) ControlDownFunc += controlDownFunc;
        }
        */
        #endregion
        
        public event EventHandler<float>? SpeedUp;
        public event EventHandler<float>? SpeedDown;

        // Конструктор с инициализацией делегатов
        public TeslaCar(EventHandler<float>? speedUp, EventHandler<float>? speedDown)
        {
            SpeedUp += speedUp;
            SpeedDown += speedDown;
        }

        public void StartEngine()
        {
            _acceleration = 10f;
            Console.WriteLine($"Engine started! Current speed: {_curSpeed}, Acceleration: {_acceleration}");
        }

        public void Accelerate()
        {
            if (_curSpeed <= _maxSpeed)
            {
                SpeedUp?.Invoke(this, _curSpeed); 
                
                _curSpeed += Math.Min(_acceleration, _maxSpeed - _curSpeed);
            }
            else
            {
                SpeedDown?.Invoke(this, GetRandomDeceleration()); 
            }

            Console.WriteLine($"Current speed: {_curSpeed}, Acceleration: {_acceleration}");
        }

        public void Stop(float deceleration)
        {
            _curSpeed = Math.Max(0, _curSpeed - deceleration);
            _acceleration = 0;
            Console.WriteLine("Car has stopped.");
        }

        private float GetRandomDeceleration()
        {
            Random random = new Random();
            return (float)(random.NextDouble() * (5 - 1) + 1);
        }
    }