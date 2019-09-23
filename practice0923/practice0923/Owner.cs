using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice0923
{
    class Owner
    {
        public string Name;
        public string Address;

        private DateTime _Birthday;
        private bool _IsQualified;

        //new 로 자원을 할당하지 않으면 메소드를 사용할 수 없음
        private List<cat> _MyCat = new List<cat>();
        //읽기 전용 변수 설정
        public List<cat> MyCat
        {
            get { return _MyCat; }
        }

        public bool Adopt(cat cat)
        {
            if (_IsQualified)
            {
                _MyCat.Add(cat);
                return true;
            }
            else
            {
                return false; 
            }
        }

        public Owner(string name, DateTime birthday)
        {
            Name = name;
            _Birthday = birthday;
        }

        
    }
}
