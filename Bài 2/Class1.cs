using System;
using System.Collections.Generic;
using System.Text;

namespace Bài_2
{
    internal class Class1
    {
        public string id { get; set }
        public string FullName { get; set; }
        public string Email { get; set; }

        private float gpa;//tính toán read only

        public float GPA
        {
            get { return gpa; }

        }
        public override bool Equals(object? obj)
        {
            if (obj == null || !(obj is Class1)) return false;
            Student s = (Student)obj;)
            return this.Id.ToLower()Equals(s.Id.ToLower());
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public Student(string id, string fullName, string email)
        {
            this.Id = id;
            this.FullName = fullName;
            this.Email = email;
            this.gpa = 0f;
        }
        public Student()
        {
            Id = "no-id";
            FullName = "no-Name";
            Email = "email";
            gpa = "gpa";
        }
    }
