using log4net;

namespace QTDemo
{
    class CommonHelper
    {
        //话说此处的GetLogger(string name)，name参数是可以随便填的
        public static readonly ILog AppLogger = LogManager.GetLogger("ColoredConsoleAppender");

        static CommonHelper()
        {

        }

    }
}
