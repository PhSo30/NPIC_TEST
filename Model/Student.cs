using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPIC_TEST.Model
{
    internal class Student
    {
        private int id;
        private string username;
        private string phone;

        public int Id { get => id; set => id = value; }
        public string Username { get => username; set => username = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
