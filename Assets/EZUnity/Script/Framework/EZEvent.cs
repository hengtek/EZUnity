/* Author:          熊哲
 * CreateTime:      2018-11-26 14:52:00
 * Organization:    #ORGANIZATION#
 * Description:     
 */

namespace EZUnity.Framework.Events
{
    public delegate void EZEventHandler(object sender, object eventArgs);

    public class EZEvent
    {
        public event EZEventHandler handlers;
        public object arg;

        public EZEvent() { }
        public EZEvent(object value) { arg = value; }
        public EZEvent(EZEventHandler handler) { handlers += handler; }

        public void SendEvent(object sender, object value)
        {
            arg = value;
            if (handlers != null) handlers(sender, value);
        }
    }
}
