namespace QuestionSystem
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.radioButtonA = new System.Windows.Forms.RadioButton();
            this.radioButtonB = new System.Windows.Forms.RadioButton();
            this.radioButtonC = new System.Windows.Forms.RadioButton();
            this.radioButtonD = new System.Windows.Forms.RadioButton();
            this.buttonNext = new System.Windows.Forms.Button();
            this.panelQuestion = new System.Windows.Forms.Panel();
            this.panelReady = new System.Windows.Forms.Panel();
            this.groupBoxNumber = new System.Windows.Forms.GroupBox();
            this.radioButtonNumberAll = new System.Windows.Forms.RadioButton();
            this.groupBoxOrder = new System.Windows.Forms.GroupBox();
            this.radioButtonOrderShuffle = new System.Windows.Forms.RadioButton();
            this.groupBoxMode = new System.Windows.Forms.GroupBox();
            this.radioButtonModeHide = new System.Windows.Forms.RadioButton();
            this.groupBoxDataset = new System.Windows.Forms.GroupBox();
            this.radioButtonDatasetGrammar = new System.Windows.Forms.RadioButton();
            this.buttonStart = new System.Windows.Forms.Button();
            this.radioButtonNumberCustom = new System.Windows.Forms.RadioButton();
            this.numericUpDownNumber = new System.Windows.Forms.NumericUpDown();
            this.radioButtonOrderInOrder = new System.Windows.Forms.RadioButton();
            this.radioButtonModeCheck = new System.Windows.Forms.RadioButton();
            this.radioButtonModeShow = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelQuestion.SuspendLayout();
            this.panelReady.SuspendLayout();
            this.groupBoxNumber.SuspendLayout();
            this.groupBoxOrder.SuspendLayout();
            this.groupBoxMode.SuspendLayout();
            this.groupBoxDataset.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 47);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(776, 229);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.Color.GreenYellow;
            this.progressBar1.Location = new System.Drawing.Point(12, 11);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(776, 23);
            this.progressBar1.TabIndex = 1;
            // 
            // radioButtonA
            // 
            this.radioButtonA.AutoSize = true;
            this.radioButtonA.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonA.Location = new System.Drawing.Point(50, 294);
            this.radioButtonA.Name = "radioButtonA";
            this.radioButtonA.Size = new System.Drawing.Size(54, 26);
            this.radioButtonA.TabIndex = 2;
            this.radioButtonA.TabStop = true;
            this.radioButtonA.Text = "(a)";
            this.radioButtonA.UseVisualStyleBackColor = true;
            this.radioButtonA.CheckedChanged += new System.EventHandler(this.radioButtonA_CheckedChanged);
            // 
            // radioButtonB
            // 
            this.radioButtonB.AutoSize = true;
            this.radioButtonB.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonB.Location = new System.Drawing.Point(200, 294);
            this.radioButtonB.Name = "radioButtonB";
            this.radioButtonB.Size = new System.Drawing.Size(55, 26);
            this.radioButtonB.TabIndex = 3;
            this.radioButtonB.TabStop = true;
            this.radioButtonB.Text = "(b)";
            this.radioButtonB.UseVisualStyleBackColor = true;
            this.radioButtonB.CheckedChanged += new System.EventHandler(this.radioButtonB_CheckedChanged);
            // 
            // radioButtonC
            // 
            this.radioButtonC.AutoSize = true;
            this.radioButtonC.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonC.Location = new System.Drawing.Point(350, 294);
            this.radioButtonC.Name = "radioButtonC";
            this.radioButtonC.Size = new System.Drawing.Size(54, 26);
            this.radioButtonC.TabIndex = 4;
            this.radioButtonC.TabStop = true;
            this.radioButtonC.Text = "(c)";
            this.radioButtonC.UseVisualStyleBackColor = true;
            this.radioButtonC.CheckedChanged += new System.EventHandler(this.radioButtonC_CheckedChanged);
            // 
            // radioButtonD
            // 
            this.radioButtonD.AutoSize = true;
            this.radioButtonD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonD.Location = new System.Drawing.Point(500, 294);
            this.radioButtonD.Name = "radioButtonD";
            this.radioButtonD.Size = new System.Drawing.Size(55, 26);
            this.radioButtonD.TabIndex = 5;
            this.radioButtonD.TabStop = true;
            this.radioButtonD.Text = "(d)";
            this.radioButtonD.UseVisualStyleBackColor = true;
            this.radioButtonD.CheckedChanged += new System.EventHandler(this.radioButtonD_CheckedChanged);
            // 
            // buttonNext
            // 
            this.buttonNext.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(650, 289);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(108, 36);
            this.buttonNext.TabIndex = 6;
            this.buttonNext.Text = "Next!";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // panelQuestion
            // 
            this.panelQuestion.Controls.Add(this.buttonNext);
            this.panelQuestion.Controls.Add(this.radioButtonD);
            this.panelQuestion.Controls.Add(this.radioButtonC);
            this.panelQuestion.Controls.Add(this.radioButtonB);
            this.panelQuestion.Controls.Add(this.radioButtonA);
            this.panelQuestion.Controls.Add(this.progressBar1);
            this.panelQuestion.Controls.Add(this.pictureBox1);
            this.panelQuestion.Location = new System.Drawing.Point(0, 1);
            this.panelQuestion.Name = "panelQuestion";
            this.panelQuestion.Size = new System.Drawing.Size(804, 338);
            this.panelQuestion.TabIndex = 7;
            this.panelQuestion.Visible = false;
            // 
            // panelReady
            // 
            this.panelReady.Controls.Add(this.groupBoxNumber);
            this.panelReady.Controls.Add(this.groupBoxOrder);
            this.panelReady.Controls.Add(this.groupBoxMode);
            this.panelReady.Controls.Add(this.groupBoxDataset);
            this.panelReady.Controls.Add(this.buttonStart);
            this.panelReady.Location = new System.Drawing.Point(0, 0);
            this.panelReady.Name = "panelReady";
            this.panelReady.Size = new System.Drawing.Size(803, 343);
            this.panelReady.TabIndex = 8;
            // 
            // groupBoxNumber
            // 
            this.groupBoxNumber.Controls.Add(this.numericUpDownNumber);
            this.groupBoxNumber.Controls.Add(this.radioButtonNumberCustom);
            this.groupBoxNumber.Controls.Add(this.radioButtonNumberAll);
            this.groupBoxNumber.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxNumber.Location = new System.Drawing.Point(12, 198);
            this.groupBoxNumber.Name = "groupBoxNumber";
            this.groupBoxNumber.Size = new System.Drawing.Size(776, 56);
            this.groupBoxNumber.TabIndex = 12;
            this.groupBoxNumber.TabStop = false;
            this.groupBoxNumber.Text = "# of Questions";
            // 
            // radioButtonNumberAll
            // 
            this.radioButtonNumberAll.AutoSize = true;
            this.radioButtonNumberAll.Enabled = false;
            this.radioButtonNumberAll.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNumberAll.Location = new System.Drawing.Point(17, 24);
            this.radioButtonNumberAll.Name = "radioButtonNumberAll";
            this.radioButtonNumberAll.Size = new System.Drawing.Size(57, 26);
            this.radioButtonNumberAll.TabIndex = 8;
            this.radioButtonNumberAll.TabStop = true;
            this.radioButtonNumberAll.Text = "All";
            this.radioButtonNumberAll.UseVisualStyleBackColor = true;
            this.radioButtonNumberAll.CheckedChanged += new System.EventHandler(this.radioButtonNumberAll_CheckedChanged);
            // 
            // groupBoxOrder
            // 
            this.groupBoxOrder.Controls.Add(this.radioButtonOrderInOrder);
            this.groupBoxOrder.Controls.Add(this.radioButtonOrderShuffle);
            this.groupBoxOrder.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxOrder.Location = new System.Drawing.Point(12, 136);
            this.groupBoxOrder.Name = "groupBoxOrder";
            this.groupBoxOrder.Size = new System.Drawing.Size(776, 56);
            this.groupBoxOrder.TabIndex = 11;
            this.groupBoxOrder.TabStop = false;
            this.groupBoxOrder.Text = "Order";
            // 
            // radioButtonOrderShuffle
            // 
            this.radioButtonOrderShuffle.AutoSize = true;
            this.radioButtonOrderShuffle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOrderShuffle.Location = new System.Drawing.Point(17, 24);
            this.radioButtonOrderShuffle.Name = "radioButtonOrderShuffle";
            this.radioButtonOrderShuffle.Size = new System.Drawing.Size(87, 26);
            this.radioButtonOrderShuffle.TabIndex = 7;
            this.radioButtonOrderShuffle.TabStop = true;
            this.radioButtonOrderShuffle.Text = "Shuffle";
            this.radioButtonOrderShuffle.UseVisualStyleBackColor = true;
            this.radioButtonOrderShuffle.CheckedChanged += new System.EventHandler(this.radioButtonOrderShuffle_CheckedChanged);
            // 
            // groupBoxMode
            // 
            this.groupBoxMode.Controls.Add(this.radioButtonModeShow);
            this.groupBoxMode.Controls.Add(this.radioButtonModeCheck);
            this.groupBoxMode.Controls.Add(this.radioButtonModeHide);
            this.groupBoxMode.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxMode.Location = new System.Drawing.Point(12, 74);
            this.groupBoxMode.Name = "groupBoxMode";
            this.groupBoxMode.Size = new System.Drawing.Size(776, 56);
            this.groupBoxMode.TabIndex = 10;
            this.groupBoxMode.TabStop = false;
            this.groupBoxMode.Text = "Mode";
            // 
            // radioButtonModeHide
            // 
            this.radioButtonModeHide.AutoSize = true;
            this.radioButtonModeHide.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonModeHide.Location = new System.Drawing.Point(17, 24);
            this.radioButtonModeHide.Name = "radioButtonModeHide";
            this.radioButtonModeHide.Size = new System.Drawing.Size(144, 26);
            this.radioButtonModeHide.TabIndex = 6;
            this.radioButtonModeHide.TabStop = true;
            this.radioButtonModeHide.Text = "Hide Answers";
            this.radioButtonModeHide.UseVisualStyleBackColor = true;
            this.radioButtonModeHide.CheckedChanged += new System.EventHandler(this.radioButtonModeHide_CheckedChanged);
            // 
            // groupBoxDataset
            // 
            this.groupBoxDataset.Controls.Add(this.radioButtonDatasetGrammar);
            this.groupBoxDataset.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxDataset.Location = new System.Drawing.Point(12, 12);
            this.groupBoxDataset.Name = "groupBoxDataset";
            this.groupBoxDataset.Size = new System.Drawing.Size(776, 56);
            this.groupBoxDataset.TabIndex = 9;
            this.groupBoxDataset.TabStop = false;
            this.groupBoxDataset.Text = "Dataset";
            // 
            // radioButtonDatasetGrammar
            // 
            this.radioButtonDatasetGrammar.AutoSize = true;
            this.radioButtonDatasetGrammar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDatasetGrammar.Location = new System.Drawing.Point(17, 20);
            this.radioButtonDatasetGrammar.Name = "radioButtonDatasetGrammar";
            this.radioButtonDatasetGrammar.Size = new System.Drawing.Size(187, 26);
            this.radioButtonDatasetGrammar.TabIndex = 6;
            this.radioButtonDatasetGrammar.TabStop = true;
            this.radioButtonDatasetGrammar.Text = "Grammar Exercises";
            this.radioButtonDatasetGrammar.UseVisualStyleBackColor = true;
            this.radioButtonDatasetGrammar.CheckedChanged += new System.EventHandler(this.radioButtonDatasetGrammar_CheckedChanged);
            // 
            // buttonStart
            // 
            this.buttonStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.Location = new System.Drawing.Point(608, 270);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(161, 48);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start!";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // radioButtonNumberCustom
            // 
            this.radioButtonNumberCustom.AutoSize = true;
            this.radioButtonNumberCustom.Enabled = false;
            this.radioButtonNumberCustom.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonNumberCustom.Location = new System.Drawing.Point(273, 24);
            this.radioButtonNumberCustom.Name = "radioButtonNumberCustom";
            this.radioButtonNumberCustom.Size = new System.Drawing.Size(90, 26);
            this.radioButtonNumberCustom.TabIndex = 9;
            this.radioButtonNumberCustom.TabStop = true;
            this.radioButtonNumberCustom.Text = "Custom";
            this.radioButtonNumberCustom.UseVisualStyleBackColor = true;
            this.radioButtonNumberCustom.CheckedChanged += new System.EventHandler(this.radioButtonNumberCustom_CheckedChanged);
            // 
            // numericUpDownNumber
            // 
            this.numericUpDownNumber.Enabled = false;
            this.numericUpDownNumber.Location = new System.Drawing.Point(373, 24);
            this.numericUpDownNumber.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.numericUpDownNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumber.Name = "numericUpDownNumber";
            this.numericUpDownNumber.Size = new System.Drawing.Size(120, 25);
            this.numericUpDownNumber.TabIndex = 10;
            this.numericUpDownNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownNumber.ValueChanged += new System.EventHandler(this.numericUpDownNumber_ValueChanged);
            // 
            // radioButtonOrderInOrder
            // 
            this.radioButtonOrderInOrder.AutoSize = true;
            this.radioButtonOrderInOrder.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOrderInOrder.Location = new System.Drawing.Point(273, 24);
            this.radioButtonOrderInOrder.Name = "radioButtonOrderInOrder";
            this.radioButtonOrderInOrder.Size = new System.Drawing.Size(78, 26);
            this.radioButtonOrderInOrder.TabIndex = 8;
            this.radioButtonOrderInOrder.TabStop = true;
            this.radioButtonOrderInOrder.Text = "Order";
            this.radioButtonOrderInOrder.UseVisualStyleBackColor = true;
            this.radioButtonOrderInOrder.CheckedChanged += new System.EventHandler(this.radioButtonOrderInOrder_CheckedChanged);
            // 
            // radioButtonModeCheck
            // 
            this.radioButtonModeCheck.AutoSize = true;
            this.radioButtonModeCheck.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonModeCheck.Location = new System.Drawing.Point(273, 24);
            this.radioButtonModeCheck.Name = "radioButtonModeCheck";
            this.radioButtonModeCheck.Size = new System.Drawing.Size(154, 26);
            this.radioButtonModeCheck.TabIndex = 7;
            this.radioButtonModeCheck.TabStop = true;
            this.radioButtonModeCheck.Text = "Check Answers";
            this.radioButtonModeCheck.UseVisualStyleBackColor = true;
            this.radioButtonModeCheck.CheckedChanged += new System.EventHandler(this.radioButtonModeCheck_CheckedChanged);
            // 
            // radioButtonModeShow
            // 
            this.radioButtonModeShow.AutoSize = true;
            this.radioButtonModeShow.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonModeShow.Location = new System.Drawing.Point(529, 24);
            this.radioButtonModeShow.Name = "radioButtonModeShow";
            this.radioButtonModeShow.Size = new System.Drawing.Size(150, 26);
            this.radioButtonModeShow.TabIndex = 8;
            this.radioButtonModeShow.TabStop = true;
            this.radioButtonModeShow.Text = "Show Answers";
            this.radioButtonModeShow.UseVisualStyleBackColor = true;
            this.radioButtonModeShow.CheckedChanged += new System.EventHandler(this.radioButtonModeShow_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 337);
            this.Controls.Add(this.panelReady);
            this.Controls.Add(this.panelQuestion);
            this.Name = "Form1";
            this.Text = "Question System";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelQuestion.ResumeLayout(false);
            this.panelQuestion.PerformLayout();
            this.panelReady.ResumeLayout(false);
            this.groupBoxNumber.ResumeLayout(false);
            this.groupBoxNumber.PerformLayout();
            this.groupBoxOrder.ResumeLayout(false);
            this.groupBoxOrder.PerformLayout();
            this.groupBoxMode.ResumeLayout(false);
            this.groupBoxMode.PerformLayout();
            this.groupBoxDataset.ResumeLayout(false);
            this.groupBoxDataset.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNumber)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RadioButton radioButtonA;
        private System.Windows.Forms.RadioButton radioButtonB;
        private System.Windows.Forms.RadioButton radioButtonC;
        private System.Windows.Forms.RadioButton radioButtonD;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Panel panelQuestion;
        private System.Windows.Forms.Panel panelReady;
        private System.Windows.Forms.RadioButton radioButtonNumberAll;
        private System.Windows.Forms.RadioButton radioButtonOrderShuffle;
        private System.Windows.Forms.RadioButton radioButtonModeHide;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBoxNumber;
        private System.Windows.Forms.GroupBox groupBoxOrder;
        private System.Windows.Forms.GroupBox groupBoxMode;
        private System.Windows.Forms.GroupBox groupBoxDataset;
        private System.Windows.Forms.RadioButton radioButtonDatasetGrammar;
        private System.Windows.Forms.NumericUpDown numericUpDownNumber;
        private System.Windows.Forms.RadioButton radioButtonNumberCustom;
        private System.Windows.Forms.RadioButton radioButtonOrderInOrder;
        private System.Windows.Forms.RadioButton radioButtonModeCheck;
        private System.Windows.Forms.RadioButton radioButtonModeShow;
    }
}

