
namespace TP3
{
    partial class Liste
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
            this.txtSaisie = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAdd = new System.Windows.Forms.Button();
            this.BtEff1 = new System.Windows.Forms.Button();
            this.Liste1 = new System.Windows.Forms.ListBox();
            this.btTo2 = new System.Windows.Forms.Button();
            this.btTo1 = new System.Windows.Forms.Button();
            this.btAllto2 = new System.Windows.Forms.Button();
            this.btAllto1 = new System.Windows.Forms.Button();
            this.List2 = new System.Windows.Forms.ListBox();
            this.btEffall1 = new System.Windows.Forms.Button();
            this.BtEff2 = new System.Windows.Forms.Button();
            this.btEffall2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSaisie
            // 
            this.txtSaisie.Location = new System.Drawing.Point(111, 54);
            this.txtSaisie.Name = "txtSaisie";
            this.txtSaisie.Size = new System.Drawing.Size(100, 23);
            this.txtSaisie.TabIndex = 0;
            this.txtSaisie.TextChanged += new System.EventHandler(this.txtSaisie_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Entrer saisie";
            // 
            // btAdd
            // 
            this.btAdd.Enabled = false;
            this.btAdd.Location = new System.Drawing.Point(282, 54);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(87, 23);
            this.btAdd.TabIndex = 2;
            this.btAdd.Text = "Ajouter";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // BtEff1
            // 
            this.BtEff1.Enabled = false;
            this.BtEff1.Location = new System.Drawing.Point(33, 314);
            this.BtEff1.Name = "BtEff1";
            this.BtEff1.Size = new System.Drawing.Size(75, 23);
            this.BtEff1.TabIndex = 3;
            this.BtEff1.Text = "Effacer ";
            this.BtEff1.UseVisualStyleBackColor = true;
            this.BtEff1.Click += new System.EventHandler(this.BtEff1_Click);
            // 
            // Liste1
            // 
            this.Liste1.FormattingEnabled = true;
            this.Liste1.ItemHeight = 15;
            this.Liste1.Location = new System.Drawing.Point(40, 129);
            this.Liste1.Name = "Liste1";
            this.Liste1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Liste1.Size = new System.Drawing.Size(218, 154);
            this.Liste1.TabIndex = 4;
            this.Liste1.SelectedIndexChanged += new System.EventHandler(this.Liste1_SelectedIndexChanged_1);
            // 
            // btTo2
            // 
            this.btTo2.Enabled = false;
            this.btTo2.Location = new System.Drawing.Point(328, 129);
            this.btTo2.Name = "btTo2";
            this.btTo2.Size = new System.Drawing.Size(75, 23);
            this.btTo2.TabIndex = 5;
            this.btTo2.Text = ">";
            this.btTo2.UseVisualStyleBackColor = true;
            this.btTo2.Click += new System.EventHandler(this.btTo2_Click);
            // 
            // btTo1
            // 
            this.btTo1.Enabled = false;
            this.btTo1.Location = new System.Drawing.Point(328, 171);
            this.btTo1.Name = "btTo1";
            this.btTo1.Size = new System.Drawing.Size(75, 23);
            this.btTo1.TabIndex = 6;
            this.btTo1.Text = "<";
            this.btTo1.UseVisualStyleBackColor = true;
            this.btTo1.Click += new System.EventHandler(this.btTo1_Click);
            // 
            // btAllto2
            // 
            this.btAllto2.Enabled = false;
            this.btAllto2.Location = new System.Drawing.Point(327, 216);
            this.btAllto2.Name = "btAllto2";
            this.btAllto2.Size = new System.Drawing.Size(75, 23);
            this.btAllto2.TabIndex = 7;
            this.btAllto2.Text = ">>";
            this.btAllto2.UseVisualStyleBackColor = true;
            this.btAllto2.Click += new System.EventHandler(this.btAllto2_Click);
            // 
            // btAllto1
            // 
            this.btAllto1.Enabled = false;
            this.btAllto1.Location = new System.Drawing.Point(327, 258);
            this.btAllto1.Name = "btAllto1";
            this.btAllto1.Size = new System.Drawing.Size(75, 23);
            this.btAllto1.TabIndex = 8;
            this.btAllto1.Text = "<<";
            this.btAllto1.UseVisualStyleBackColor = true;
            this.btAllto1.Click += new System.EventHandler(this.btAllto1_Click);
            // 
            // List2
            // 
            this.List2.FormattingEnabled = true;
            this.List2.ItemHeight = 15;
            this.List2.Location = new System.Drawing.Point(474, 129);
            this.List2.Name = "List2";
            this.List2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.List2.Size = new System.Drawing.Size(238, 154);
            this.List2.TabIndex = 9;
            this.List2.SelectedIndexChanged += new System.EventHandler(this.List2_SelectedIndexChanged);
            // 
            // btEffall1
            // 
            this.btEffall1.Enabled = false;
            this.btEffall1.Location = new System.Drawing.Point(149, 314);
            this.btEffall1.Name = "btEffall1";
            this.btEffall1.Size = new System.Drawing.Size(109, 23);
            this.btEffall1.TabIndex = 10;
            this.btEffall1.Text = "Effacer Tous";
            this.btEffall1.UseVisualStyleBackColor = true;
            this.btEffall1.Click += new System.EventHandler(this.btEffall1_Click);
            // 
            // BtEff2
            // 
            this.BtEff2.Enabled = false;
            this.BtEff2.Location = new System.Drawing.Point(474, 314);
            this.BtEff2.Name = "BtEff2";
            this.BtEff2.Size = new System.Drawing.Size(75, 23);
            this.BtEff2.TabIndex = 11;
            this.BtEff2.Text = "Effacer";
            this.BtEff2.UseVisualStyleBackColor = true;
            this.BtEff2.Click += new System.EventHandler(this.BtEff2_Click);
            // 
            // btEffall2
            // 
            this.btEffall2.Enabled = false;
            this.btEffall2.Location = new System.Drawing.Point(609, 314);
            this.btEffall2.Name = "btEffall2";
            this.btEffall2.Size = new System.Drawing.Size(103, 23);
            this.btEffall2.TabIndex = 12;
            this.btEffall2.Text = "Effacer Tous";
            this.btEffall2.UseVisualStyleBackColor = true;
            this.btEffall2.Click += new System.EventHandler(this.btEffall2_Click);
            // 
            // Liste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 366);
            this.Controls.Add(this.btEffall2);
            this.Controls.Add(this.BtEff2);
            this.Controls.Add(this.btEffall1);
            this.Controls.Add(this.List2);
            this.Controls.Add(this.btAllto1);
            this.Controls.Add(this.btAllto2);
            this.Controls.Add(this.btTo1);
            this.Controls.Add(this.btTo2);
            this.Controls.Add(this.Liste1);
            this.Controls.Add(this.BtEff1);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSaisie);
            this.Name = "Liste";
            this.Text = "ListeBox";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSaisie;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button BtEff1;
        private System.Windows.Forms.ListBox Liste1;
        private System.Windows.Forms.Button btTo2;
        private System.Windows.Forms.Button btTo1;
        private System.Windows.Forms.Button btAllto2;
        private System.Windows.Forms.Button btAllto1;
        private System.Windows.Forms.ListBox List2;
        private System.Windows.Forms.Button btEffall1;
        private System.Windows.Forms.Button BtEff2;
        private System.Windows.Forms.Button btEffall2;
    }
}

