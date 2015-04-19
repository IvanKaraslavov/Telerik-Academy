using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllStudents
{
    public class Groups
    {
        private int groupNumber;
        private string groupName;

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }
            set
            {
                this.groupNumber = value;
            }
        }

        public string GroupName
        {
            get
            {
                return this.groupName;
            }
            set
            {
                this.groupName = value;
            }
        }

        public Groups(string groupName, int groupNumber)
        {
            this.GroupName = groupName;
            this.groupNumber = groupNumber;
        }

        public Groups()
            :this (null,0)
        {
        }

        
    }
}
