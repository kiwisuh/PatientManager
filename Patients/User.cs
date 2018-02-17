using System;

    public class User
    {
        //attributes
        private string name;
        private int age;
        private string gender;
        private string healthConcern;

        //constructors
        public User(string name, int age, string gender, string healthConcern)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.healthConcern = healthConcern;
        }
        public User(string name, int age, string healthConcern)
        {
            this.name = name;
            this.age = age;
            this.gender = "";
            this.healthConcern = healthConcern;
        }

        //encapsulation of methods
        public string GetName()
        {
            return this.name;
        }
        public int GetAge()
        {
            return this.age;
        }
        public string GetGender()
        {
            return this.gender;
        }
        public string GetHealthConcern()
        {
            return this.healthConcern;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetAge(int age)
        {
            this.age = age;
        }
        public void SetGender(string gender)
        {
            this.gender = gender;
        }
        public void SetHealthConcern(string healthConcern)
        {
            this.healthConcern = healthConcern;
        }
    }

