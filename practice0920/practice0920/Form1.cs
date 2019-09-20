using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace practice0920
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //using System.Collections; 네임스페이스 추가
            //ArrayList 인스턴스 생성
            ArrayList arrayList = new ArrayList();

            //요소 추가 메소드
            arrayList.Add(0);
            arrayList.Add(1);
            arrayList.Add(3);

            //arrayList[0] - 0
            //arrayList[1] - 1
            //arrayList[2] - 3

            arrayList.Insert(2, 2);
            //arrayList[2] - 2
            //원래 있던 arrayList[2]의 값은 [3]으로 밀려남 - 3

            arrayList.Remove(2);
            //arrayList 안의 값이 2인 항목을 제거

            arrayList.RemoveAt(1);
            //arrayList 안의 인덱스가 1인 값을 제거 하고 나머지 값이 앞으로 이동

            //arrayList와 배열의 차이점: 값들이 유동적으로 이동 가능 - LinkedList

            int sum = 0;

            for(int i = 0; i< arrayList.Count; i++)
            {
                //object 타입으로 되어있기 때문에 형 변환 해야함
                int num = (int)arrayList[i];
                //형 변환이 빈번할 경우 처리 속도가 증가
                
                //sum = sum + num;
                sum += num;
            }


            //배열
            int[] intArray = new int[5];

            //ArrayList 인스턴스 생성
            //Object 형식으로 설정되어 있기 때문에 형 변환이 필요
            ArrayList arrayList1 = new ArrayList();

            arrayList1.Add("list");
            arrayList.Add(1);


            //List<T> : <저장할 데이터 타입> 선언 - 형 변환이 필요 없음
            List<int> intList = new List<int>();
            intList.Add(1);
            intList.Add(2);
            //intList.Add("list"); - int 형으로 선언되었기 때문에 에러 발생

            int sum1 = 0;
            for(int i=0;i<intList.Count; i++)
            {
                int su = intList[i]; 
                sum1 += su;
            }

            foreach(int su in intList)
            {
                sum1 += su;
            }

        }
    }
}
