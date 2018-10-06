﻿namespace DataAdapter.Inside
{
    public class StudentSearchObject : IDataObject
    {

        public string FirstName { get; }

        public string LastName { get; }

        public string PastName;

        /// <summary> true - is Man </summary>
        public bool Male { get; }

        public string Group;

        public StudentSearchObject(string firstName, string lastName, string pastName, bool male, string group)
        {
            FirstName = firstName;
            LastName = lastName;
            Male = male;
            if (pastName != null)
                PastName = pastName;
            if (group != null)
                Group = group;

            ValidateData();
        }

        public void ValidateData()
        {
            DataValidator.ValidateFieldTextRequired(FirstName, "Имя");
            DataValidator.ValidateFieldTextRequired(LastName, "Фамилия");
            if(PastName != null)
                DataValidator.ValidateFieldText(PastName, "Отчество");
            if(Group != null)
                DataValidator.ValidateFieldTextAdvanced(Group, "Группа");
        }
    }
}
