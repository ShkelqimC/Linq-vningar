using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLibrary
{
    public class Fighter
    {
        private int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public int age { get; set; }
        public int IDItterator = 0;
        public String FullName
        {
            get => $"{firstName} {lastName}";

        }

        public string FullInfo
        {
            get => $"{firstName} {lastName} is a {age} years old {gender} with id: {Id}";
        }

        public Fighter()
        {
            Id = IDItterator;
            IDItterator++;
        }
    }
}
