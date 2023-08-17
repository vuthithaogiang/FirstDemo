using System;

namespace FirstDemo.learnDelegate
{
    public delegate void ActionDelegate(string ms);

    public class Button
    {
        public event ActionDelegate Click;

        public Button(ActionDelegate onAction)
        {
            Click += onAction;
        }
    }
}
