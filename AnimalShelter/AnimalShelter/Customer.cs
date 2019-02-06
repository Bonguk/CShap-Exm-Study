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



        public Customer(string firstName, string lastName, DateTime birthday)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this._Birthday = birthday;

            this._IsQualified = Age >= 18;
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

        // Age가 private 일때 Method를 생성하여 다른 공간에서 사용 할 수 있게 만들기
        // IsQualified도 Age 처럼 Method를 생성하여 다른 공간에서 사용 할 수 있게 만듬
        /*
        public int GetAge()
        {
            return _Age;
        }
        public void SetAge(int age)
        {
            _Age = age;
            _IsQualified = age >= 18;
        }
        */

        // 속성은 Get, Set이 있다
        // 속성은 필드 처럼 보이지만 안에 Method 처럼 생성 할 수 있다
        // Get은 return값을 항상 받는다
        // Set은 return값은 받지않고 매개변수는 value 고정
        public int Age
        {
            get { return DateTime.Now.Year - _Birthday.Year; }
        }

        // 읽기전용은 Set을 구지 추가 안해도됨
        // public이지만 get을 사용하면 가져갈수는 있지만 값을 private처럼 보호 할수 있다.
        public bool IsQualified
        {
            get
            {
                return _IsQualified;
            }
        }
        
        // 값은 Customer에서 작성하는걸로 해서 Set은 제외하고 Get으로만 하여 private 처럼 사용한다.
        public string FullName
        {
            get
            {
                return FirstName + " " + LastName;
            }
        }

    }
}
