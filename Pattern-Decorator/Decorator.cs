using System;
using System.Collections.Generic;
using System.Text;

namespace Pattern_Decorator
{
    public abstract class Decorator : SyncItem
    {
        protected SyncItem _componentDataSync;

        public Decorator(SyncItem componentDataSync)
        {
            this._componentDataSync = componentDataSync;
        }

        public override void Sync(int prime)
        {
        }
    }
}
