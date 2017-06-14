using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class AggregateRoot<TAggregateRootId> : IAggregateRoot
    {
        protected TAggregateRootId _id;
        public TAggregateRootId Id
        {
            get { return _id; }
            protected set { _id = value; }
        }

        string IAggregateRoot.UniqueId
        {
            get
            {
                if (Id != null)
                {
                    return Id.ToString();
                }
                return null;
            }
        }
    }
}
