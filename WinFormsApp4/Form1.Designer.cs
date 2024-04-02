namespace WinFormsApp4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txt_MaNV = new TextBox();
            txt_TenNV = new TextBox();
            cmbx_TenPB = new ComboBox();
            dtgView = new DataGridView();
            btn_Them = new Button();
            btn_Xoa = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)dtgView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 37);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã NV";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(28, 75);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 1;
            label2.Text = "Tên NV";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 116);
            label3.Name = "label3";
            label3.Size = new Size(86, 15);
            label3.TabIndex = 2;
            label3.Text = "Tên Phòng Ban";
            // 
            // txt_MaNV
            // 
            txt_MaNV.Location = new Point(129, 34);
            txt_MaNV.Name = "txt_MaNV";
            txt_MaNV.Size = new Size(300, 23);
            txt_MaNV.TabIndex = 3;
            // 
            // txt_TenNV
            // 
            txt_TenNV.Location = new Point(129, 72);
            txt_TenNV.Name = "txt_TenNV";
            txt_TenNV.Size = new Size(300, 23);
            txt_TenNV.TabIndex = 4;
            // 
            // cmbx_TenPB
            // 
            cmbx_TenPB.FormattingEnabled = true;
            cmbx_TenPB.Location = new Point(129, 113);
            cmbx_TenPB.Name = "cmbx_TenPB";
            cmbx_TenPB.Size = new Size(300, 23);
            cmbx_TenPB.TabIndex = 5;
            // 
            // dtgView
            // 
            dtgView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgView.Location = new Point(12, 158);
            dtgView.Name = "dtgView";
            dtgView.Size = new Size(776, 280);
            dtgView.TabIndex = 6;
            dtgView.CellClick += dtgView_CellClick;
            // 
            // btn_Them
            // 
            btn_Them.Location = new Point(549, 29);
            btn_Them.Name = "btn_Them";
            btn_Them.Size = new Size(239, 37);
            btn_Them.TabIndex = 7;
            btn_Them.Text = "Thêm";
            btn_Them.UseVisualStyleBackColor = true;
            btn_Them.Click += btn_Them_Click;
            // 
            // btn_Xoa
            // 
            btn_Xoa.Location = new Point(549, 72);
            btn_Xoa.Name = "btn_Xoa";
            btn_Xoa.Size = new Size(239, 37);
            btn_Xoa.TabIndex = 8;
            btn_Xoa.Text = "Xóa";
            btn_Xoa.UseVisualStyleBackColor = true;
            btn_Xoa.Click += btn_Xoa_Click;
            // 
            // button3
            // 
            button3.Location = new Point(549, 116);
            button3.Name = "button3";
            button3.Size = new Size(239, 37);
            button3.TabIndex = 9;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(btn_Xoa);
            Controls.Add(btn_Them);
            Controls.Add(dtgView);
            Controls.Add(cmbx_TenPB);
            Controls.Add(txt_TenNV);
            Controls.Add(txt_MaNV);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dtgView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txt_MaNV;
        private TextBox txt_TenNV;
        private ComboBox cmbx_TenPB;
        private DataGridView dtgView;
        private Button btn_Them;
        private Button btn_Xoa;
        private Button button3;
    }
}
