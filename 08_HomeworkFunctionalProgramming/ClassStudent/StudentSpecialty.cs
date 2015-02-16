using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassStudent
{
    // Create a class StudentSpecialty that holds specialty name and faculty number. 
    class StudentSpecialty
    {
        private string specialtyName;
        private int facultyNumber;

        public StudentSpecialty(string specialtyName, int facultyNumber)
        {
            this.SpecialtyName = specialtyName;
            this.FacultyNumber = facultyNumber;
        }

        public string SpecialtyName
        {
            get { return this.specialtyName; }
            set
            {
                Validation.CheckForNullOrEmptyString(value, "SpecialtyName");
                this.specialtyName = value;
            }
        }

        public int FacultyNumber
        {
            get { return this.facultyNumber; }
            set
            {
                Validation.CheckForNegativeOrZero(value, "facultyNumber");
                this.facultyNumber = value;
            }
        }
    }
}
