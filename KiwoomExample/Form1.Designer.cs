namespace KiwoomExample
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnLogin = new System.Windows.Forms.Button();
            this.kiwoomApi = new AxKHOpenAPILib.AxKHOpenAPI();
            this.listBoxLog = new System.Windows.Forms.ListBox();
            this.labelAccountList = new System.Windows.Forms.Label();
            this.comboAccountList = new System.Windows.Forms.ComboBox();
            this.labelEstimatedAssets = new System.Windows.Forms.Label();
            this.labelEstimatedAssetsVal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.kiwoomApi)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(12, 0);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 36);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "로그인";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // kiwoomApi
            // 
            this.kiwoomApi.Enabled = true;
            this.kiwoomApi.Location = new System.Drawing.Point(697, 0);
            this.kiwoomApi.Name = "kiwoomApi";
            this.kiwoomApi.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("kiwoomApi.OcxState")));
            this.kiwoomApi.Size = new System.Drawing.Size(100, 50);
            this.kiwoomApi.TabIndex = 1;
            this.kiwoomApi.OnReceiveTrData += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrDataEventHandler(this.kiwoomApi_OnReceiveTrData);
            this.kiwoomApi.OnReceiveRealData += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealDataEventHandler(this.kiwoomApi_OnReceiveRealData);
            this.kiwoomApi.OnReceiveMsg += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveMsgEventHandler(this.kiwoomApi_OnReceiveMsg);
            this.kiwoomApi.OnEventConnect += new AxKHOpenAPILib._DKHOpenAPIEvents_OnEventConnectEventHandler(this.kiwoomApi_OnEventConnect);
            this.kiwoomApi.OnReceiveRealCondition += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveRealConditionEventHandler(this.kiwoomApi_OnReceiveRealCondition);
            this.kiwoomApi.OnReceiveTrCondition += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveTrConditionEventHandler(this.kiwoomApi_OnReceiveTrCondition);
            this.kiwoomApi.OnReceiveConditionVer += new AxKHOpenAPILib._DKHOpenAPIEvents_OnReceiveConditionVerEventHandler(this.kiwoomApi_OnReceiveConditionVer);
            // 
            // listBoxLog
            // 
            this.listBoxLog.FormattingEnabled = true;
            this.listBoxLog.ItemHeight = 18;
            this.listBoxLog.Location = new System.Drawing.Point(12, 344);
            this.listBoxLog.Name = "listBoxLog";
            this.listBoxLog.Size = new System.Drawing.Size(776, 94);
            this.listBoxLog.TabIndex = 2;
            // 
            // labelAccountList
            // 
            this.labelAccountList.AutoSize = true;
            this.labelAccountList.Location = new System.Drawing.Point(9, 51);
            this.labelAccountList.Name = "labelAccountList";
            this.labelAccountList.Size = new System.Drawing.Size(80, 18);
            this.labelAccountList.TabIndex = 3;
            this.labelAccountList.Text = "계좌목록";
            // 
            // comboAccountList
            // 
            this.comboAccountList.FormattingEnabled = true;
            this.comboAccountList.Location = new System.Drawing.Point(95, 48);
            this.comboAccountList.Name = "comboAccountList";
            this.comboAccountList.Size = new System.Drawing.Size(161, 26);
            this.comboAccountList.TabIndex = 4;
            // 
            // labelEstimatedAssets
            // 
            this.labelEstimatedAssets.AutoSize = true;
            this.labelEstimatedAssets.Location = new System.Drawing.Point(9, 87);
            this.labelEstimatedAssets.Name = "labelEstimatedAssets";
            this.labelEstimatedAssets.Size = new System.Drawing.Size(116, 18);
            this.labelEstimatedAssets.TabIndex = 5;
            this.labelEstimatedAssets.Text = "추정예탁자산";
            // 
            // labelEstimatedAssetsVal
            // 
            this.labelEstimatedAssetsVal.AutoSize = true;
            this.labelEstimatedAssetsVal.Location = new System.Drawing.Point(131, 87);
            this.labelEstimatedAssetsVal.Name = "labelEstimatedAssetsVal";
            this.labelEstimatedAssetsVal.Size = new System.Drawing.Size(36, 18);
            this.labelEstimatedAssetsVal.TabIndex = 6;
            this.labelEstimatedAssetsVal.Text = "0원";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelEstimatedAssetsVal);
            this.Controls.Add(this.labelEstimatedAssets);
            this.Controls.Add(this.comboAccountList);
            this.Controls.Add(this.labelAccountList);
            this.Controls.Add(this.listBoxLog);
            this.Controls.Add(this.kiwoomApi);
            this.Controls.Add(this.btnLogin);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.kiwoomApi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogin;
        private AxKHOpenAPILib.AxKHOpenAPI kiwoomApi;
        private System.Windows.Forms.ListBox listBoxLog;
        private System.Windows.Forms.Label labelAccountList;
        private System.Windows.Forms.ComboBox comboAccountList;
        private System.Windows.Forms.Label labelEstimatedAssets;
        private System.Windows.Forms.Label labelEstimatedAssetsVal;
    }
}

