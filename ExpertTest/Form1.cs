using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Text;
using Oracle.ManagedDataAccess.Client;
using System.Timers;

namespace ExpertTest
{
    public partial class Form1 : Form
    {
        string marketName;
        string ticker;
        private AxITGExpertCtlLib.AxITGExpertCtl axOS_ST03;
        string infoData;

        static int errorBoxCount = 0;
        int tickerNum = 0;
        string todayDate = "";
        int dataCount = 0;

        List<string> marketList = new List<string>();
        List<string> tickerList = new List<string>();

        public Form1()
        {
            InitializeComponent();
            // object가 tr 호출이 한번 일어나야 계좌를 정상적으로 가져올 수 있으므로, 초기화 시 호출
            axTR1.RequestData("FOCP");
        }

        // 계좌조회 버튼 클릭시 처리
        private void button1_Click(object sender, EventArgs e)
        {
            cmbAccount.Items.Clear();
            short i;

            infoData = axTR1.GetOverSeasStockSise().ToString();

            for (i = 0; i < axTR1.GetAccountCount(); i++)
            {
                String Account = (String)axTR1.GetAccount(i);
                String sPdNo = Account.Substring(8);

                cmbAccount.Items.Add(axTR1.GetAccount(i));
                if (cmbAccount.Items.Count > 0)
                {
                    cmbAccount.SelectedIndex = 0;
                }
            }
        }

        private void axTR0_ReceiveData(object sender, EventArgs e)
        {
            ListViewItem item = null;

            dataCount += 1;
            short nBlkCount = axTR0.GetMultiBlockCount();
            //MessageBox.Show(nBlkCount.ToString());
            label11.Text = (tickerNum+1).ToString() + " / " + marketList.Count.ToString();
            //listView1.Items.Clear();
            for (short j = 0; j < nBlkCount; j++)
            {
                for (short i = 0; i < axTR0.GetMultiRecordCount(j); i++)
                {
                    item = new ListViewItem();
                    item.UseItemStyleForSubItems = false;
                    // 0일자, 1종가, 2기호, 3대비, 4등락율, 5시가, 6고가, 7저가, 8거래량, 9거래대금
                    string market = marketName;
                    item.SubItems.Add(market);

                    string symbol = ticker;
                    item.SubItems.Add(symbol);

                    string date = axTR0.GetMultiData(1, i, 0, 0).ToString();
                    item.SubItems.Add(date);

                    string sign = axTR0.GetMultiData(1, i, 2, 0).ToString();

                    string change = axTR0.GetMultiData(1, i, 3, 0).ToString();

                    string open = axTR0.GetMultiData(1, i, 5, 0).ToString();
                    item.SubItems.Add(open);

                    string high = axTR0.GetMultiData(1, i, 6, 0).ToString();
                    item.SubItems.Add(high);

                    string low = axTR0.GetMultiData(1, i, 7, 0).ToString();
                    item.SubItems.Add(low);

                    string close = axTR0.GetMultiData(1, i, 1, 0).ToString();
                    item.SubItems.Add(close);

                    string diff = axTR0.GetMultiData(1, i, 4, 0).ToString();
                    item.SubItems.Add(diff);

                    string volume = axTR0.GetMultiData(1, i, 8, 0).ToString();
                    item.SubItems.Add(volume);

                    string money = axTR0.GetMultiData(1, i, 9, 0).ToString();
                    item.SubItems.Add(money);
                    if (sign.Equals("5") & (change.Replace("-","") != "0.0000"))
                    {
                        change = "-" + change;
                    }
                    //listView1.Items.Add(item);

                    string myDoc = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string filePath = myDoc + @"\해외주식\"+ todayDate + "Ori.txt";

                    StreamWriter writer;
                    writer = File.AppendText(filePath);
                    writer.WriteLine(marketName + "," + ticker + "," + date + "," + open + "," + high + "," + low + "," + close + "," + diff + "," + volume + "," + money + "," + change);
                    writer.Close();
                }
            }
            bool bIsNext = Convert.ToBoolean(axTR0.IsMoreNextData()); // 다음 조회할 데이터가 있는지 확인
            
            /*
            if (bIsNext == true)
            {
                Thread.Sleep(200);
                axTR0.RequestNextData("OS_ST03");
            }
            else
            */
            if (true)
            {
                if (dataCount.Equals(marketList.Count()))
                {
                    this.Close();
                }
                else
                {
                    Thread.Sleep(200);
                    tickerNum += 1;
                    if (tickerNum < marketList.Count)
                    {
                        marketName = marketList[tickerNum];
                        ticker = tickerList[tickerNum];

                        axTR0.SetSingleData(0, infoData); // 사용자권한정보
                        axTR0.SetSingleData(1, marketName); // 거래소 코드
                        axTR0.SetSingleData(2, ticker);
                        axTR0.SetSingleData(3, "0");
                        
                        axTR0.SetSingleData(4, todayDate);  // 조회기준일자
                        //axTR0.SetSingleData(4, "20220529");  // 조회기준일자

                        //axTR0.SetSingleData(5, "1");  // 수정주가
                        axTR0.SetSingleData(5, "0");  // 수정전주가

                        axTR0.SetSingleData(6, "");  // next key value
                        axTR0.RequestData("OS_ST03");   // 잔고조회
                    }
                }
            }
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            marketName = marketList[tickerNum];
            ticker = tickerList[tickerNum];

            axTR0.SetSingleData(0, infoData); // 사용자권한정보
            axTR0.SetSingleData(1, marketName); // 거래소 코드
            axTR0.SetSingleData(2, ticker);       
            axTR0.SetSingleData(3, "0"); 
            axTR0.SetSingleData(4, todayDate);  // 조회기준일자
            axTR0.SetSingleData(5, "1");  // 수정주가
            axTR0.SetSingleData(6, "");  // next key value
            axTR0.RequestData("OS_ST03");   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            todayDate = DateTime.Now.ToString("yyyy-MM-dd").Replace("-", "");
            
            Thread.Sleep(3000);
            StreamReader sr = new StreamReader("D:\\백성운작업\\해외주식목록\\"+todayDate+"allTicker.txt");
            // 스트림의 끝까지 읽기
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();

                string[] data = line.Split(',');
                string marketName0 = data[1].ToString().Replace(" ", "");
                
                if (marketName0 == "NYSE")
                {
                    marketList.Add("NYS");
                    tickerList.Add(data[0].ToString().Replace(" ", ""));
                }
                else if (marketName0 == "NASDAQ")
                {
                    marketList.Add("NAS");
                    tickerList.Add(data[0].ToString().Replace(" ", ""));
                }
                else if (marketName0 == "89")
                {
                    marketList.Add("AMS");
                }
            }
            sr.Close();

            Thread.Sleep(200);

            marketName = marketList[tickerNum];
            ticker = tickerList[tickerNum];

            axTR0.SetSingleData(0, infoData); // 사용자권한정보
            axTR0.SetSingleData(1, marketName); // 거래소 코드
            axTR0.SetSingleData(2, ticker);
            axTR0.SetSingleData(3, "0");
            
            axTR0.SetSingleData(4, todayDate);  // 조회기준일자
            //axTR0.SetSingleData(4, "20220529");  // 조회기준일자
            
            //axTR0.SetSingleData(5, "1");  // 수정주가
            axTR0.SetSingleData(5, "0");  // 수정전주가
            
            axTR0.SetSingleData(6, "");  // next key value
            axTR0.RequestData("OS_ST03");   
        }

        private void tickerBtn_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("버튼눌림");
            //StreamReader sr = new StreamReader("C:\\Users\\thinkpool\\Desktop\\allTicker.csv");
            todayDate = DateTime.Now.ToString("yyyy-MM-dd").Replace("-", "");
            StreamReader sr = new StreamReader("D:\\백성운작업\\해외주식목록\\" + todayDate + "allTicker.txt");
            // 스트림의 끝까지 읽기
            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();

                string[] data = line.Split(',');
                string marketName0 = data[1].ToString().Replace(" ", "");

                if (marketName0 == "NYSE")
                {
                    marketList.Add("NYS");
                    tickerList.Add(data[0].ToString().Replace(" ", ""));

                }
                else if (marketName0 == "NASDAQ")
                {
                    marketList.Add("NAS");
                    tickerList.Add(data[0].ToString().Replace(" ", ""));
                }
                else if (marketName0 == "89")
                {
                    marketList.Add("AMS");
                }
            }
            sr.Close();

            Thread.Sleep(200);
            searchBtn.PerformClick();
        }

        private void searchBtn2_Click(object sender, EventArgs e)
        {

        }
    }
}
