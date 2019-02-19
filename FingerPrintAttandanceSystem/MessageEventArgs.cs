using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FingerPrintAttandanceSystem
{
    public delegate void MessageDelegate(Object sender, MessageEventArgs e);

    public class MessageEventArgs : EventArgs
    {
        public string Message;
        public MessageEventArgs(string msg)
        {
            this.Message = msg;
        }
    }
    public interface IController
    {
        event MessageDelegate ControllerEvent;
        void InvokeControllerEvent(string msg);
    }
    public class Controller : IController
    {
        #region IController Members

        public event MessageDelegate ControllerEvent;

        public void InvokeControllerEvent(string msg)
        {
            this.OnControllerEvent(new MessageEventArgs(msg));
        }

        #endregion

        protected virtual void OnControllerEvent(MessageEventArgs mea)
        {
            if (this.ControllerEvent != null)
            {
                this.ControllerEvent.Invoke(this, mea);
            }
        }

    }
}
