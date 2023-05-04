using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace State
{
    public class NightState : IState
    {
        // Singletonパターン
        public static NightState Singleton { get; } = new NightState();
        private NightState() { }

        public void DoClock(IContext context, int hour)
        {
            if (9 <= hour && hour < 17)
            {
                context.ChangeState(DayState.Singleton);
            }
        }

        public void DoUse(IContext context)
        {
            context.CallSecurityCenter("非常:夜間の金庫使用！");
        }

        public void DoAlarm(IContext context)
        {
            context.CallSecurityCenter("非常ベル(夜間)");
        }

        public void DoPhone(IContext context)
        {
            context.CallSecurityCenter("夜間の通話録音");
        }

        public override string ToString()
        {
            return "[夜間]";
        }
    }
}
