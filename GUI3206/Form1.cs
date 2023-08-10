using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI3206
{
    public partial class Form1 : Form
    {
        List<Store> stores = new List<Store>()
        {
            new Store(){Id=1, Name="다이소 강원점", Kind="천원샵", Location="강원", StartDate=170809},
            new Store(){Id=2, Name="잇쑈니", Kind="천원샵", Location="전주", StartDate=220403},
            new Store(){Id=3, Name="천원가게", Kind="천원샵", Location="전주", StartDate=180613},
            new Store(){Id=4, Name="구멍가게", Kind="천원샵", Location="강원", StartDate=170227},
            new Store(){Id=5, Name="천원점빵", Kind="천원샵", Location="경기", StartDate=200925},

            new Store(){Id=6, Name="소르베", Kind="소품샵", Location="전주", StartDate=161209},
            new Store(){Id=7, Name="테디", Kind="소품샵", Location="서울", StartDate=161105},
            new Store(){Id=8, Name="홍대 소품샵", Kind="소품샵", Location="서울", StartDate=230405},
            new Store(){Id=9, Name="고요서울", Kind="소품샵", Location="서울", StartDate=220808},
            new Store(){Id=10, Name="워니", Kind="소품샵", Location="강원", StartDate=220625},

            new Store(){Id=11, Name="레몬트리", Kind="편집샵", Location="서울", StartDate=200113},
            new Store(){Id=12, Name="별집", Kind="편집샵", Location="서울", StartDate=210903},
            new Store(){Id=13, Name="트레이더스", Kind="편집샵", Location="서울", StartDate=140425},
            new Store(){Id=14, Name="오일리", Kind="편집샵", Location="강원", StartDate=190818},
            new Store(){Id=15, Name="K", Kind="편집샵", Location="충남", StartDate=230717},

            new Store(){Id=16, Name="orange cafe", Kind="카페", Location="제주도", StartDate=160603},
            new Store(){Id=17, Name="정우요", Kind="카페", Location="강원", StartDate=190722},
            new Store(){Id=18, Name="청그릭", Kind="카페", Location="충남", StartDate=200505},
            new Store(){Id=19, Name="스타벅스 경기점", Kind="카페", Location="경기", StartDate=210611},
            new Store(){Id=20, Name="가배도", Kind="카페", Location="경기", StartDate=231107},
        }; 

        public Form1()
        {
            InitializeComponent();
            storeBindingSource.DataSource = stores;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //전체 보기
            storeBindingSource.DataSource = stores;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //이름 오름차순으로 보기
            storeBindingSource.DataSource = from store in stores
                                            orderby store.Name
                                            select store;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //카페만 보기
            storeBindingSource.DataSource = from store in stores
                                            where store.Kind.Equals("카페")
                                            select store;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //서울, 경기에 위치한 가게만 보기
            storeBindingSource.DataSource = from store in stores
                                            where store.Location.Equals("서울") || store.Location.Equals("경기")
                                            select store;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //2020년 이후에 영업을 시작한 가게 보기
            storeBindingSource.DataSource = from store in stores
                                            where store.StartDate/10000 >= 20
                                            orderby store.StartDate
                                            select store;
        }
    }
}
