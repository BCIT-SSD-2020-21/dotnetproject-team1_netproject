using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Parlez.Models
{
    public class BaseEntity
    {
        public virtual int Id { get; protected set; }
    }
}
