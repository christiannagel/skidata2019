using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace LoggingSample
{
    public delegate void MyDelegate();

    public class MyController
    {
        public void MyAction()
        {

        }

        public void MyAction2()
        {
            throw new Exception("bad bad bad");
        }
        private readonly ILogger _logger;
        public MyController(ILogger<MyController> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public void Foo()
        {
            _logger.LogTrace("Foo called");

            var d1 = new MyDelegate(MyAction);
            d1.Invoke();

            MyDelegate d2 = MyAction;
            d2();

            d2 += MyAction2;
            try
            {
                var delegates = d2.GetInvocationList();

                foreach (MyDelegate del in delegates)
                {
                    try
                    {
                        del();
                    }
                    catch (Exception ex)
                    {
                        Delegate.Remove(d2, del);
                    }
                }
     
            }
            catch
            {

            }
        }

        public void Bar()
        {
            _logger.LogError("some error happened in Bar");
        }

        public int Val1 { get; set; }

        private int _val2;

        public int Val2
        {
            get { return _val2; }
            set { _val2 = value; }
        }

        public event MyDelegate MyEvent;

        private MyDelegate _myEvent1;
        public event MyDelegate MyEvent1
        {
            add
            {
                _myEvent1 += value;
            }
            remove
            {
                _myEvent1 -= value;
            }
        }
    }
}
