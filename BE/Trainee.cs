using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Trainee: Person
    {
        public VehicleType VehicleType { get; set; }

        public override string ToString()
        {
            String result = "";
            result += base.ToString();
            result += String.Format("VehicleType: {0}\n", VehicleType);
            return result;
        }

        public Trainee Clone()
        {
            return new Trainee
            {
                Address = this.Address,
                BirthDay = this.BirthDay,
                FirstName = this.FirstName,
                LastName = this.LastName,
                Email = this.Email,
                Gender = this.Gender,
                ID = this.ID,
                VehicleType = this.VehicleType,
                PhoneNumber = this.PhoneNumber
            };
        }
    }
}
