﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Basic_Class
{
    public class Staff
    {

        // Private Data Members 
        private int _StaffId;
        public int StaffId
        {
            get { return _StaffId; }
            set
            {

                if (value < 0)
                {
                    bool valid = true;
                    while (valid)
                    {
                        Console.WriteLine("You have enterd invalid id");
                        Console.WriteLine("Enter Valid ID ");
                        int value_1 = Convert.ToInt32(Console.ReadLine());
                        if (value_1 > 0)
                        {
                            _StaffId = value_1;
                            valid = false;
                        }
                    }
                }
                else
                {
                    _StaffId = value;
                }
            }
        }
        private string _StaffName = string.Empty;
        public string StaffName
        {
            get { return _StaffName; }
            set
            {
                bool temp = true;
                int count = 0;
                while (temp)
                {
                    string spe_char = "@!#$%&/\\|()=?»«@£§€{}\".-;'<>_,1234567890";
                    foreach (char ch in value)
                    {
                        if (spe_char.Contains(ch))
                        {

                            Console.WriteLine();
                            count = 1;
                            break;
                        }
                    }
                    if (count == 1)
                    {
                        Console.WriteLine("You have enterd invalid Name");
                        Console.WriteLine("Enter Correct Name");
                        string UpdatedString = Console.ReadLine();
                        value = UpdatedString;

                    }

                    else
                    {
                        _StaffName = value;

                        temp = false;
                    }

                }
            }
        }
        private string _Email = string.Empty;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }
        private string _DeptName = string.Empty;
        public string DeptName
        {
            get { return _DeptName; }
            set
            {
                if (value == "Cancer" || value == "Heart" || value == "Pathology" || value == "Radiology" || value == "Blood Bank" || value == "Organ" || value == "Orthopeic" || value == "Eye" || value == "Dental")
                {
                    _DeptName = value;
                }
                else
                {
                    Console.WriteLine("Entered Incorrect Department");
                }
            }
        }
        private string _Gender = string.Empty;
        public string Gender
        {
            get { return _Gender; }
            set
            {
                if (value == "Male" || value == "Female" || value == "Transgender")
                {
                    _Gender = value;
                }
                else
                {
                    Console.WriteLine("Enter Correct Gender(Male/Female/Transgender)");

                }
            }
        }
        private DateTime _DateOfBirth;
        public DateTime DateOfBirth
        {
            get { return _DateOfBirth; }
            set
            {
                _DateOfBirth = value;
            }
        }
        private string _StaffCategory = string.Empty;
        public string StaffCategory
        {
            get { return _StaffCategory; }
            set
            {
                if (value == "Doctor" || value == "Nurse" || value == "Wardboy" || value == "Brother" || value == "Technician")
                {

                    _StaffCategory = value;
                }
                else
                {
                    throw new Exception("Entered Incorrect Category ");
                }




            }
        }
        private string _Education = string.Empty;
        public string Education
        {
            get { return _Education; }
            set { _Education = value; }
        }
        private string _ContactNo = String.Empty;
        public string ContatNo
        {
            get { return _ContactNo; }
            set
            {
                _ContactNo = value;
            }
        }
    }
}

