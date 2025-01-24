using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDemo // Assembly
{
    public class AccessModifires
    {
        //internal int Address { get; set; } // Property

        //private UserId 
        private int UserId { get; set; } // Property
        protected string EmailAddress { get; set; } // Property

        public string UserName { get; set; }

        public void getData()
        {
            PrivateGetData();
        }

        private void PrivateGetData()
        {

        }

        public void getData12112()
        {
            PrivateGetData();
        }


    }

    public class ChildAccessModifires : AccessModifires // Single Inharitance
    {
        public ChildAccessModifires()
        {
            UserName = "JKigar";
            EmailAddress = "EmailAddress";
        }

    }
}
