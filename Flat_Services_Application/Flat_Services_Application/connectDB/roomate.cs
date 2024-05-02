using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flat_Services_Application.connectDB
{
    internal class roomate
    {
        private string _ID_number_room;
        private string _Full_name;
        private bool _Sex;
        private bool _Roles;
        private DateTime _Date_of_birth;
        private string _ID_vehical;
        private string _Home_address;
        private string _Phone_number_roomate;
        private string _ID_number_tenant;

        public roomate()
        {

        }

        public roomate(string iD_number_room, string full_name, bool sex, bool roles, DateTime date_of_birth, string iD_vehical, string home_address, string phone_number_roomate, string iD_number_tenant)
        {
            _ID_number_room = iD_number_room;
            _Full_name = full_name;
            _Sex = sex;
            _Roles = roles;
            _Date_of_birth = date_of_birth;
            _ID_vehical = iD_vehical;
            _Home_address = home_address;
            _Phone_number_roomate = phone_number_roomate;
            _ID_number_tenant = iD_number_tenant;
        }

        public string ID_number_room { get => _ID_number_room; set => _ID_number_room = value; }
        public string Full_name { get => _Full_name; set => _Full_name = value; }
        public bool Sex { get => _Sex; set => _Sex = value; }
        public bool Roles { get => _Roles; set => _Roles = value; }
        public DateTime Date_of_birth { get => _Date_of_birth; set => _Date_of_birth = value; }
        public string ID_vehical { get => _ID_vehical; set => _ID_vehical = value; }
        public string Home_address { get => _Home_address; set => _Home_address = value; }
        public string Phone_number_roomate { get => _Phone_number_roomate; set => _Phone_number_roomate = value; }
        public string ID_number_tenant { get => _ID_number_tenant; set => _ID_number_tenant = value; }
    }
}
