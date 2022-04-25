namespace CagriMerkezi_200601021_SanerYesil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.musteriTuru = new System.Windows.Forms.Label();
            this.typeTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCall = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.secondEndComCallBtn = new System.Windows.Forms.Button();
            this.firstEndComCallBtn = new System.Windows.Forms.Button();
            this.comInfolbl2 = new System.Windows.Forms.Label();
            this.secondComOpBtn = new System.Windows.Forms.Button();
            this.comInfo1lbl = new System.Windows.Forms.Label();
            this.firstComOpBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comNote = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comListview = new System.Windows.Forms.ListView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.secondEndPerCallBtn = new System.Windows.Forms.Button();
            this.firstEndPerCallBtn = new System.Windows.Forms.Button();
            this.perInfolbl2 = new System.Windows.Forms.Label();
            this.perInfolbl1 = new System.Windows.Forms.Label();
            this.secondPerOpBtn = new System.Windows.Forms.Button();
            this.firstPerOpBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.perNote = new System.Windows.Forms.TextBox();
            this.perListview = new System.Windows.Forms.ListView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.prevCallslv = new System.Windows.Forms.ListView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // musteriTuru
            // 
            this.musteriTuru.AutoSize = true;
            this.musteriTuru.Location = new System.Drawing.Point(53, 19);
            this.musteriTuru.Name = "musteriTuru";
            this.musteriTuru.Size = new System.Drawing.Size(155, 30);
            this.musteriTuru.TabIndex = 0;
            this.musteriTuru.Text = "Ticari arama için 1 yazınız. \r\nBireysel arama için 2 yazınız.";
            // 
            // typeTxt
            // 
            this.typeTxt.Location = new System.Drawing.Point(214, 22);
            this.typeTxt.Name = "typeTxt";
            this.typeTxt.Size = new System.Drawing.Size(102, 23);
            this.typeTxt.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox1.Controls.Add(this.btnCall);
            this.groupBox1.Controls.Add(this.musteriTuru);
            this.groupBox1.Controls.Add(this.typeTxt);
            this.groupBox1.Location = new System.Drawing.Point(4, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 103);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giriş ";
            // 
            // btnCall
            // 
            this.btnCall.Location = new System.Drawing.Point(194, 64);
            this.btnCall.Name = "btnCall";
            this.btnCall.Size = new System.Drawing.Size(143, 23);
            this.btnCall.TabIndex = 5;
            this.btnCall.Text = "Çağrı Yap";
            this.btnCall.UseVisualStyleBackColor = true;
            this.btnCall.Click += new System.EventHandler(this.btnCall_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.secondEndComCallBtn);
            this.groupBox2.Controls.Add(this.firstEndComCallBtn);
            this.groupBox2.Controls.Add(this.comInfolbl2);
            this.groupBox2.Controls.Add(this.secondComOpBtn);
            this.groupBox2.Controls.Add(this.comInfo1lbl);
            this.groupBox2.Controls.Add(this.firstComOpBtn);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.comNote);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comListview);
            this.groupBox2.Location = new System.Drawing.Point(4, 121);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(505, 252);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ticari";
            // 
            // secondEndComCallBtn
            // 
            this.secondEndComCallBtn.Location = new System.Drawing.Point(304, 83);
            this.secondEndComCallBtn.Name = "secondEndComCallBtn";
            this.secondEndComCallBtn.Size = new System.Drawing.Size(147, 23);
            this.secondEndComCallBtn.TabIndex = 9;
            this.secondEndComCallBtn.Text = "Çağrıyı bitir";
            this.secondEndComCallBtn.UseVisualStyleBackColor = true;
            this.secondEndComCallBtn.Click += new System.EventHandler(this.secondEndComCallBtn_Click);
            // 
            // firstEndComCallBtn
            // 
            this.firstEndComCallBtn.Location = new System.Drawing.Point(53, 83);
            this.firstEndComCallBtn.Name = "firstEndComCallBtn";
            this.firstEndComCallBtn.Size = new System.Drawing.Size(147, 23);
            this.firstEndComCallBtn.TabIndex = 8;
            this.firstEndComCallBtn.Text = "Çağrıyı bitir";
            this.firstEndComCallBtn.UseVisualStyleBackColor = true;
            this.firstEndComCallBtn.Click += new System.EventHandler(this.firstEndComCallBtn_Click);
            // 
            // comInfolbl2
            // 
            this.comInfolbl2.AutoSize = true;
            this.comInfolbl2.Location = new System.Drawing.Point(270, 65);
            this.comInfolbl2.Name = "comInfolbl2";
            this.comInfolbl2.Size = new System.Drawing.Size(12, 15);
            this.comInfolbl2.TabIndex = 7;
            this.comInfolbl2.Text = "-";
            // 
            // secondComOpBtn
            // 
            this.secondComOpBtn.Location = new System.Drawing.Point(255, 22);
            this.secondComOpBtn.Name = "secondComOpBtn";
            this.secondComOpBtn.Size = new System.Drawing.Size(240, 40);
            this.secondComOpBtn.TabIndex = 5;
            this.secondComOpBtn.Text = "2. temsilciye çağrı ata. \r\n";
            this.secondComOpBtn.UseVisualStyleBackColor = true;
            this.secondComOpBtn.Click += new System.EventHandler(this.secondComOpBtn_Click);
            // 
            // comInfo1lbl
            // 
            this.comInfo1lbl.AutoSize = true;
            this.comInfo1lbl.Location = new System.Drawing.Point(18, 65);
            this.comInfo1lbl.Name = "comInfo1lbl";
            this.comInfo1lbl.Size = new System.Drawing.Size(12, 15);
            this.comInfo1lbl.TabIndex = 6;
            this.comInfo1lbl.Text = "-";
            // 
            // firstComOpBtn
            // 
            this.firstComOpBtn.Location = new System.Drawing.Point(6, 22);
            this.firstComOpBtn.Name = "firstComOpBtn";
            this.firstComOpBtn.Size = new System.Drawing.Size(240, 40);
            this.firstComOpBtn.TabIndex = 4;
            this.firstComOpBtn.Text = "1. temsilciye çağrı ata. ";
            this.firstComOpBtn.UseVisualStyleBackColor = true;
            this.firstComOpBtn.Click += new System.EventHandler(this.firstComOpBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(255, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Not";
            // 
            // comNote
            // 
            this.comNote.Location = new System.Drawing.Point(255, 142);
            this.comNote.Multiline = true;
            this.comNote.Name = "comNote";
            this.comNote.Size = new System.Drawing.Size(240, 102);
            this.comNote.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Bekleyen Çağrılar";
            // 
            // comListview
            // 
            this.comListview.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.comListview.BackColor = System.Drawing.SystemColors.Window;
            this.comListview.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comListview.Location = new System.Drawing.Point(6, 144);
            this.comListview.Name = "comListview";
            this.comListview.RightToLeftLayout = true;
            this.comListview.Size = new System.Drawing.Size(240, 102);
            this.comListview.TabIndex = 0;
            this.comListview.UseCompatibleStateImageBehavior = false;
            this.comListview.View = System.Windows.Forms.View.List;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.Transparent;
            this.groupBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox3.Controls.Add(this.secondEndPerCallBtn);
            this.groupBox3.Controls.Add(this.firstEndPerCallBtn);
            this.groupBox3.Controls.Add(this.perInfolbl2);
            this.groupBox3.Controls.Add(this.perInfolbl1);
            this.groupBox3.Controls.Add(this.secondPerOpBtn);
            this.groupBox3.Controls.Add(this.firstPerOpBtn);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.perNote);
            this.groupBox3.Controls.Add(this.perListview);
            this.groupBox3.Location = new System.Drawing.Point(4, 379);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(505, 263);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Bireysel";
            // 
            // secondEndPerCallBtn
            // 
            this.secondEndPerCallBtn.Location = new System.Drawing.Point(304, 82);
            this.secondEndPerCallBtn.Name = "secondEndPerCallBtn";
            this.secondEndPerCallBtn.Size = new System.Drawing.Size(147, 23);
            this.secondEndPerCallBtn.TabIndex = 11;
            this.secondEndPerCallBtn.Text = "Çağrıyı bitir";
            this.secondEndPerCallBtn.UseVisualStyleBackColor = true;
            this.secondEndPerCallBtn.Click += new System.EventHandler(this.secondEndPerCallBtn_Click);
            // 
            // firstEndPerCallBtn
            // 
            this.firstEndPerCallBtn.Location = new System.Drawing.Point(53, 82);
            this.firstEndPerCallBtn.Name = "firstEndPerCallBtn";
            this.firstEndPerCallBtn.Size = new System.Drawing.Size(147, 23);
            this.firstEndPerCallBtn.TabIndex = 10;
            this.firstEndPerCallBtn.Text = "Çağrıyı bitir";
            this.firstEndPerCallBtn.UseVisualStyleBackColor = true;
            this.firstEndPerCallBtn.Click += new System.EventHandler(this.firstEndPerCallBtn_Click);
            // 
            // perInfolbl2
            // 
            this.perInfolbl2.AutoSize = true;
            this.perInfolbl2.Location = new System.Drawing.Point(270, 64);
            this.perInfolbl2.Name = "perInfolbl2";
            this.perInfolbl2.Size = new System.Drawing.Size(12, 15);
            this.perInfolbl2.TabIndex = 9;
            this.perInfolbl2.Text = "-";
            // 
            // perInfolbl1
            // 
            this.perInfolbl1.AutoSize = true;
            this.perInfolbl1.Location = new System.Drawing.Point(18, 64);
            this.perInfolbl1.Name = "perInfolbl1";
            this.perInfolbl1.Size = new System.Drawing.Size(12, 15);
            this.perInfolbl1.TabIndex = 8;
            this.perInfolbl1.Text = "-";
            // 
            // secondPerOpBtn
            // 
            this.secondPerOpBtn.Location = new System.Drawing.Point(255, 19);
            this.secondPerOpBtn.Name = "secondPerOpBtn";
            this.secondPerOpBtn.Size = new System.Drawing.Size(240, 42);
            this.secondPerOpBtn.TabIndex = 7;
            this.secondPerOpBtn.Text = "2. temsilciye çağrı ata. \r\n";
            this.secondPerOpBtn.UseVisualStyleBackColor = true;
            this.secondPerOpBtn.Click += new System.EventHandler(this.secondPerOpBtn_Click);
            // 
            // firstPerOpBtn
            // 
            this.firstPerOpBtn.Location = new System.Drawing.Point(6, 19);
            this.firstPerOpBtn.Name = "firstPerOpBtn";
            this.firstPerOpBtn.Size = new System.Drawing.Size(240, 42);
            this.firstPerOpBtn.TabIndex = 6;
            this.firstPerOpBtn.Text = "1. temsilciye çağrı ata. \r\n";
            this.firstPerOpBtn.UseVisualStyleBackColor = true;
            this.firstPerOpBtn.Click += new System.EventHandler(this.firstPerOpBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(255, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Not";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bekleyen Çağrılar";
            // 
            // perNote
            // 
            this.perNote.Location = new System.Drawing.Point(255, 143);
            this.perNote.Multiline = true;
            this.perNote.Name = "perNote";
            this.perNote.Size = new System.Drawing.Size(240, 114);
            this.perNote.TabIndex = 3;
            // 
            // perListview
            // 
            this.perListview.Location = new System.Drawing.Point(6, 143);
            this.perListview.Name = "perListview";
            this.perListview.Size = new System.Drawing.Size(240, 114);
            this.perListview.TabIndex = 0;
            this.perListview.UseCompatibleStateImageBehavior = false;
            this.perListview.View = System.Windows.Forms.View.List;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.Transparent;
            this.groupBox4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.groupBox4.Controls.Add(this.prevCallslv);
            this.groupBox4.Location = new System.Drawing.Point(4, 648);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(505, 176);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Geçmiş Çağrılar";
            // 
            // prevCallslv
            // 
            this.prevCallslv.Location = new System.Drawing.Point(6, 22);
            this.prevCallslv.Name = "prevCallslv";
            this.prevCallslv.Size = new System.Drawing.Size(491, 142);
            this.prevCallslv.TabIndex = 0;
            this.prevCallslv.UseCompatibleStateImageBehavior = false;
            this.prevCallslv.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(514, 826);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Çağrı Merkezi Uygulaması";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Label musteriTuru;
        private TextBox typeTxt;
        private GroupBox groupBox1;
        private Button btnCall;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private ListView comListview;
        private ListView perListview;
        private GroupBox groupBox4;
        private ListView prevCallslv;
        private Label label3;
        private TextBox comNote;
        private Label label1;
        private Label label4;
        private Label label2;
        private TextBox perNote;
        private Button secondComOpBtn;
        private Button firstComOpBtn;
        private Button secondPerOpBtn;
        private Button firstPerOpBtn;
        private Label comInfo1lbl;
        private Label comInfolbl2;
        private Label perInfolbl2;
        private Label perInfolbl1;
        private Button firstEndComCallBtn;
        private Button secondEndComCallBtn;
        private Button secondEndPerCallBtn;
        private Button firstEndPerCallBtn;
    }
}