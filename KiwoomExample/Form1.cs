using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KiwoomExample
{
    public partial class Form1 : Form
    {
        private string SCREEN_NO_ESTIMATED_ASSETS = "1001";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            // 로그아웃 기능이 없어져서 로그인만 처리
            Button clickedButton = (Button)sender;

            // 클릭 시 버튼 비활성화
            clickedButton.Enabled = false;

            // 로그인창 오픈
            if (kiwoomApi.CommConnect() == 0)
            {
                listBoxLog.Items.Add("로그인 창이 열렸습니다.");
            } else
            {
                listBoxLog.Items.Add("로그인 창을 열지 못했습니다.");

                // 로그인창 오픈 실패 시 다시 버튼 활성화
                clickedButton.Enabled = true;
            }
        }

        //***********************************************************************************************************************
        // 공통 함수 선언부
        //***********************************************************************************************************************
        private string convertMoneyFormat(string price)
        {
            return String.Format("{0:#,###0}", long.Parse(price));
        }

        private string convertPercentFormat(string percent)
        {
            return String.Format("{0:f2}", double.Parse(percent));
        }

        private string getSeletedAccountNo()
        {
            return comboAccountList.SelectedItem.ToString().Trim();
        }

        private void initAccountList()
        {
            int cnt = int.Parse(kiwoomApi.GetLoginInfo("ACCOUNT_CNT"));

            if (cnt > 0)
            {
                comboAccountList.Items.AddRange(kiwoomApi.GetLoginInfo("ACCLIST").Split(new string[] { ";" }, StringSplitOptions.RemoveEmptyEntries));

                comboAccountList.SelectedIndex = 0;
            }
        }

        //***********************************************************************************************************************
        // 키움 OpenApi TR요청 선언부
        //***********************************************************************************************************************
        private void requestTrEstimatedAssets()
        {
            kiwoomApi.SetInputValue("계좌번호", getSeletedAccountNo());
            kiwoomApi.SetInputValue("비밀번호", "");
            kiwoomApi.SetInputValue("상장폐지조회구분", "0");

            // TR명 : 추정자산조회요청
            kiwoomApi.CommRqData("trEstimatedAssets", "OPW00003", 0, SCREEN_NO_ESTIMATED_ASSETS);
        }

        //***********************************************************************************************************************
        // 키움 OpenApi TR요청 결과 처리부
        //***********************************************************************************************************************
        private void trEstimatedAssets(AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            string 추정예탁자산 = kiwoomApi.GetCommData(e.sTrCode, e.sRQName, 0, "추정예탁자산").Trim();
            labelEstimatedAssetsVal.Text = convertMoneyFormat(추정예탁자산) + "원";
        }

        //***********************************************************************************************************************
        // 키움 OpenApi 이벤트 선언부
        //***********************************************************************************************************************
        private void kiwoomApi_OnReceiveMsg(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveMsgEvent e)
        {
            Console.WriteLine("[DEBUG] 화면번호:" + e.sScrNo + ", 사용자구분명:" + e.sRQName + ", TR명:" + e.sTrCode + ", 메시지:" + e.sMsg);
        }

        private void kiwoomApi_OnEventConnect(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            listBoxLog.Items.Add("로그인 결과 (ErrCode:" + e.nErrCode + ")");

            // 로그인 성공
            if (e.nErrCode == 0)
            {
                // 계좌 비밀번호 입력창 띄움
                kiwoomApi.KOA_Functions("ShowAccountWindow", "");

                // 로그인 완료 후 처리 로직
                initAccountList();
                requestTrEstimatedAssets(); // 추정자산조회
            }
        }

        private void kiwoomApi_OnReceiveTrData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEvent e)
        {
            Console.WriteLine("RQName : " + e.sRQName);
            this.GetType().GetMethod(e.sRQName, System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic).Invoke(this, new object[] { e });
        }

        private void kiwoomApi_OnReceiveRealData(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEvent e)
        {

        }

        private void kiwoomApi_OnReceiveConditionVer(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveConditionVerEvent e)
        {

        }

        private void kiwoomApi_OnReceiveTrCondition(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrConditionEvent e)
        {

        }

        private void kiwoomApi_OnReceiveRealCondition(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealConditionEvent e)
        {

        }
    }
}
