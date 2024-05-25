using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Dtos.People
{
    public class GetPeopleAndTypes 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int PersonTypeId { get; set; }
        public string PersonTypeName { get; set; }


    }
}
