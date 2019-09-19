using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice0918
{
    //클래스 앞에 접근지정자가 없는 경우 - private
    public class Customer
    {
        public string firstName;
        public string lastName;

        //다른 곳에서 임의로 변동할 수 없도록 private 설정
        private int _age;

        private DateTime _birthday;

        public string address;
        public string description;

        //제한 설정을 위한 변수 생성
        //나이를 통해서 제한값 변경
        private bool _isQualified;

        public Customer(string FirstName, string LastName, DateTime birthday)
        {
            this.firstName = FirstName;
            this.lastName = LastName;
            this._age = Age;

            this._birthday = birthday;

            //this._isQualified = Age >= 18;
            this._isQualified = DateTime.Now.Year - birthday.Year >= 18;

        }

        public DateTime Birthday
        {
            get
            {
                return _birthday;
            }
            set
            {
                //매개변수
                _birthday = value;
                //_isQualified = DateTime.Now.Year - value.Year >= 18;
                _isQualified = Age >= 18;

            }
        }

        /*
        public int getAge()
        {
            return _age;
        }

        public void setAge(int Age)
        {
            _age = Age;
            _isQualified = Age >= 10;
        }
        */

        public int Age
        {
            //get { return _age; }

            //생일을 이용해서 나이 구하기
            get
            {
                return DateTime.Now.Year - _birthday.Year;
            }
            set
            {
                _age = value;
                _isQualified = value >= 18;
            }
        }

        /*
        public bool getIsQualified()
        {
            return _isQualified;
        }
        */

        public bool isQualified
        {
            get
            {
                return _isQualified;
            }

            //set이 없음 - 읽기 전용(보호)
            //age의 갑에 따라 isQualified의 값이 변경
        }

        /*
        public string getFullName()
        {
            return firstName + " " + lastName;
        }
        */
        
        public string fullName
        {
            get
            {
                return firstName + " " + lastName;
            }
        }


    }
}
