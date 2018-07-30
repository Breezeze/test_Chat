using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandServices
{
    public class BaseCommand : ICommand, IStore
    {
        public virtual string Behavior
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual string CommandName
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual bool IsStore
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public virtual void Do(params string[] parameter)
        {
            throw new NotImplementedException();
        }


        public void Store(string[] parameters)
        {
            if (this.IsStore)
            {
                LogProcessor.StoreLog.StoreExecutiveOutcome(this.CommandName, this.Behavior, parameters, true, null);
            }
        }
    }
}
