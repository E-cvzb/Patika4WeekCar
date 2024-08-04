using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Patika4WeekCar
{
    public class Car
    {
        public string _carModel;
        public string _carBrand;
        public string _carColour;
        public int _doorNumber;


       public Car(string carBrand ,string carModel , string carColour, int doorNumber)
        { 

           _carBrand =carBrand;
            _carModel=carModel;
            _carColour=carColour;
            _doorNumber= doorNumber;
        }


        public string carModel
        {
            get
            {
                return _carModel;
            }
            set
            { _carModel = value; }
        }
        public string carBrand
        {
            get
            {
                return _carBrand;
            }
            set
            {
                _carBrand = value;
            }
        }
        public string carColour
        {
            get
            {
                return _carColour;
            }
            set
            {
                _carColour = value;
            }
        }
        public int doorNumber
        {
            get { return _doorNumber; }
            
            set
            {
                if (value == 2 || value==4) // 2 veya 4 girilmesi durumunda bizim istediğimiz aracı oluşturmakta 
                {
                    _doorNumber = value;
                }
                 else// Bu değerlerini dışında bir değer girilemi durumunda bize uyarı vermekte 
                {
                    Console.WriteLine("Yanlış değer tanımladınız");
                }
            }

        }
        

        

    }
}
