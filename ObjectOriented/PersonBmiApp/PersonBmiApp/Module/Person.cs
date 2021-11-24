using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonBmiApp.Module
{
    class Person
    {
        private string _name;
        private float _height;
        private float _weight;
        private float _age;
        private string _gender;
        public Person(string n, float h, float w, float a, string g)
        {
            _name = n;
            _height = h;
            _weight = w;
            _age = a;
            _gender = g;
        }
        public float CalcBmiScore()
        {
            float bmi, temp, temp1;
            temp = _weight;
            temp1 = _height * 0.0254f;
            bmi = temp / (temp1 * temp1);
            return bmi;
        }
        public void Workout()
        {
            _weight = _weight - (0.1f * _weight);
            CalcBmiScore();
        }
        public void Eat()
        {
            _height = _height + (0.02f * _height);
            _weight = _weight + (0.05f * _weight);
            CalcBmiScore();
        }
        public string BodyStructure(float bm)
        {
            string bmiRead;
            if (bm < 18.5f)
            {
                bmiRead = "Under Weight";
            }
            else if (bm >= 18.5f && bm < 24.9f)
            {
                bmiRead = "Healthy Weight";
            }
            else if (bm >= 25f && bm < 29.9f)
            {
                bmiRead = "Over Weight";
            }
            else if (bm >= 30.0f)
            {
                bmiRead = "Obesity";
            }
            else
            {
                bmiRead = "Check height and Weight inputs. Something seems wrong";
            }
            return bmiRead;
        }
        public void PrintDetails(Person obj)
        {
            float a = obj.CalcBmiScore();
            Console.WriteLine("Name : " + obj._name + "\t Age : " + obj._age + "\t Gender : " + obj._gender + "\t Height : " + obj._height + "\t Weight : " + obj._weight);
            Console.WriteLine("\n Body Mass Index : "+obj.CalcBmiScore()+"\t Body Structure : "+obj.BodyStructure(a));
        }

    }

}



// create a constructor
// method to calc bmi score //rt :-float
// Workout method ____________ _weight reduces by 10% after this called          //rt :-void
// eat method ________________ _height increased by 2% weight increments by 2%      //rt :-void
// Bmi score will change
// method to return body structure. //rt :-string
// model class will do all the calc
