using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AxKHOpenAPILib;

namespace KiwoomExample
{
    class KiwoomApi
    {
        private AxKHOpenAPI openApi;

        public KiwoomApi()
        {
            openApi = new AxKHOpenAPI();
            this.initEvent();
        }

        public KiwoomApi(AxKHOpenAPI openApi)
        {
            this.openApi = openApi;
            this.initEvent();
        }

        //----------------------------------------------------------- Event  -----------------------------------------------------------
        private void initEvent()
        {
            this.openApi.OnEventConnect += new _DKHOpenAPIEvents_OnEventConnectEventHandler(this.OnEventConnectEventHandler);
        }

        private void OnEventConnectEventHandler(object sender, AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEvent e)
        {
            if (e.nErrCode == 0)
            {
                Console.WriteLine("로그인 완료");
            }
        }
        //----------------------------------------------------------- Event  -----------------------------------------------------------

        //---------------------------------------------------------- Function ----------------------------------------------------------
        public bool openLoginDialog()
        {
            if(openApi.CommConnect() == 0)
            {
                Console.WriteLine("로그인창 열림");

                return true;
            }

            Console.WriteLine("로그인창 안열림");

            return false;
        }
        //---------------------------------------------------------- Function ----------------------------------------------------------
    }
}
