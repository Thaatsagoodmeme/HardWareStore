using Database.Model.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database.Model
{
    public class EmergencyContact
    {
        public EmergencyContact(string name, string contactInfo, RelationshipType relationship)
        {
            this.Name = name;
            this.PhoneNumber = contactInfo;
            this.Relationship = relationship;
        }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public RelationshipType Relationship { get; set; }
    }
}
