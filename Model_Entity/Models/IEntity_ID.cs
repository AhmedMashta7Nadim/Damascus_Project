using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model_Entity.Models
{
    public interface IEntity_ID
    {
        public Guid Id { get; set; }
        public bool IsActive { get; set; }

    }
}
