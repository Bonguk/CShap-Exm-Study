using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Customer
    {
        public string FirstName;
        public string LastName;
        private DateTime _Birthday;
        private bool _IsQualified;
        public string Address;
        public string Description;

        // 부모 클래스를 사용하여 Pet리스트 하나로 만들어 Cat과 Dog를 대체
        private List<Pet> _MyPets = new List<Pet>();
        public List<Pet> MyPets
        {
            get { return _MyPets; }
        }
        public bool Adopt(Pet pet)
        {
            if (_IsQualified)
            {
                _MyPets.Add(pet);
                return true;
            }
            else
            {
                return false;
            }
        }

        /*
        // MyCat이 public이면 IsQualified(입양여부)
        // false가 나와도 밖에서도 선언 가능해서 Private으로 변경
        // 속성(Get)만 사용해 읽기전용으로 만들어 준다.
        // List를 바로 생성 해준다.
        private List<Cat> _MyCats = new List<Cat>();
        public List<Cat> MyCats
        {
            get { return _MyCats; }
        }

        public bool Adopt(Cat cat)
        {
            if (_IsQualified)
            {
                _MyCats.Add(cat);
                return true;
            }
            else
            {
                return false;
            }
        }

        private List<Dog> _MyDogs = new List<Dog>();
        public List<Dog> MyDogs
        {
            get { return _MyDogs; }
        }
       
        // 오버로딩 : 매개변수를 다르게해서 얼마든지 함수를 선언 할 수 잇음.
        public bool Adopt(Dog dog)
        {
            if (_IsQualified)
            {
                _MyDogs.Add(dog);
                return true;
            }
            else
            {
                return false;
            }
        }
        */

        public Customer(string firstName, string lastName, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._Birthday = birthday;

            this._IsQualified = DateTime.Now.Year - Age >= 18;
        }

        public DateTime Birthday
        {
            get { return _Birthday; }
            set
            {
                _Birthday = value;
                _IsQualified = Age >= 18;
            }
        }

        public int Age
        {
            get { return DateTime.Now.Year - _Birthday.Year; }
        }
        public bool IsQualified
        {
            get { return _IsQualified; }
        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        
    }
}
