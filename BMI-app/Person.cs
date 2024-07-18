using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_app
{
    internal class Person
    {
        public static int DEFAULF_HEIGHT = 5;
        public static int DEFAULF_WEIGHT = 50;
        public float FEET_METERS = 0.3048F;
        public int _id { get; set; }
        public string _name { get; set; }
        public int _age { get; set; }
        public  double _height { get; set; }
        public double _weight { get; set; }
        public double _bmi { get; set; }

        public Person(int id, string name, int age) : 
            this(id,name, age, DEFAULF_HEIGHT, DEFAULF_WEIGHT ) { }

        public Person(int id, string name, int age, double height, double weight) 
        {
            _id = id;
            _name = name;
            _age = age;
            _height = height;
            _weight = weight;
        }

        public string PrintDetails()
        {
            return ("\nId : " + this._id + "\nName : " + this._name + "\nAge : " + this._age + 
                "\nHeight : " + this._height + "\nWeight : " + this._weight + 
                "\nBMI Score : " + CalculateBMIScore() + "\nResult : " + DetermineBodyType() );
        }

        public float CalculateBMIScore()
        {
            double height = this._height * FEET_METERS;
            float score = (float)(this._weight / (height * height));
            this._bmi = score;
            return score;
        }
        public string DetermineBodyType()
        {
            float bmiScore = CalculateBMIScore();

            if (bmiScore < 18.5) return "Underweight";
            if (bmiScore >= 18.5 && bmiScore < 25) return "Normal weight";
            if (bmiScore >= 25 && bmiScore < 30) return "Overweight";
            return "Obese";
        }

        public static Person CalculateHighestBMI(Person[] persons)
        {
            Person highestBMIPerson = persons[0];
            double highestBMI = highestBMIPerson._bmi;

            foreach (Person person in persons)
            {
                double bmi = person._bmi;
                if (bmi > highestBMI)
                {
                    highestBMI = bmi;
                    highestBMIPerson = person;
                }
            }        
            return highestBMIPerson;
        }

    }
}
