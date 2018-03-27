namespace SkyrimAlchemyApp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.IngLB = new System.Windows.Forms.ListBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.Eff1Lbl = new System.Windows.Forms.Label();
            this.Eff2Lbl = new System.Windows.Forms.Label();
            this.Eff3Lbl = new System.Windows.Forms.Label();
            this.Eff4Lbl = new System.Windows.Forms.Label();
            this.s_WeightLbl = new System.Windows.Forms.Label();
            this.s_Value = new System.Windows.Forms.Label();
            this.WeightLbl = new System.Windows.Forms.Label();
            this.ValueLbl = new System.Windows.Forms.Label();
            this.InfoLbl = new System.Windows.Forms.Label();
            this.SearchIngBtn = new System.Windows.Forms.Button();
            this.SearchIngTB = new System.Windows.Forms.TextBox();
            this.ShowAllBtn = new System.Windows.Forms.Button();
            this.SearchEffBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IngLB
            // 
            this.IngLB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IngLB.FormattingEnabled = true;
            this.IngLB.ItemHeight = 20;
            this.IngLB.Location = new System.Drawing.Point(12, 71);
            this.IngLB.Name = "IngLB";
            this.IngLB.Size = new System.Drawing.Size(242, 264);
            this.IngLB.TabIndex = 0;
            this.IngLB.SelectedIndexChanged += new System.EventHandler(this.IngLB_SelectedIndexChanged);
            // 
            // NameLbl
            // 
            this.NameLbl.AutoEllipsis = true;
            this.NameLbl.AutoSize = true;
            this.NameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLbl.Location = new System.Drawing.Point(283, 71);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(51, 20);
            this.NameLbl.TabIndex = 1;
            this.NameLbl.Text = "Name";
            // 
            // Eff1Lbl
            // 
            this.Eff1Lbl.AutoEllipsis = true;
            this.Eff1Lbl.AutoSize = true;
            this.Eff1Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eff1Lbl.Location = new System.Drawing.Point(283, 105);
            this.Eff1Lbl.Name = "Eff1Lbl";
            this.Eff1Lbl.Size = new System.Drawing.Size(65, 20);
            this.Eff1Lbl.TabIndex = 2;
            this.Eff1Lbl.Text = "Effect 1";
            // 
            // Eff2Lbl
            // 
            this.Eff2Lbl.AutoEllipsis = true;
            this.Eff2Lbl.AutoSize = true;
            this.Eff2Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eff2Lbl.Location = new System.Drawing.Point(283, 136);
            this.Eff2Lbl.Name = "Eff2Lbl";
            this.Eff2Lbl.Size = new System.Drawing.Size(65, 20);
            this.Eff2Lbl.TabIndex = 3;
            this.Eff2Lbl.Text = "Effect 2";
            // 
            // Eff3Lbl
            // 
            this.Eff3Lbl.AutoEllipsis = true;
            this.Eff3Lbl.AutoSize = true;
            this.Eff3Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eff3Lbl.Location = new System.Drawing.Point(505, 105);
            this.Eff3Lbl.Name = "Eff3Lbl";
            this.Eff3Lbl.Size = new System.Drawing.Size(65, 20);
            this.Eff3Lbl.TabIndex = 4;
            this.Eff3Lbl.Text = "Effect 3";
            // 
            // Eff4Lbl
            // 
            this.Eff4Lbl.AutoEllipsis = true;
            this.Eff4Lbl.AutoSize = true;
            this.Eff4Lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Eff4Lbl.Location = new System.Drawing.Point(505, 136);
            this.Eff4Lbl.Name = "Eff4Lbl";
            this.Eff4Lbl.Size = new System.Drawing.Size(65, 20);
            this.Eff4Lbl.TabIndex = 5;
            this.Eff4Lbl.Text = "Effect 4";
            // 
            // s_WeightLbl
            // 
            this.s_WeightLbl.AutoSize = true;
            this.s_WeightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_WeightLbl.Location = new System.Drawing.Point(283, 172);
            this.s_WeightLbl.Name = "s_WeightLbl";
            this.s_WeightLbl.Size = new System.Drawing.Size(63, 20);
            this.s_WeightLbl.TabIndex = 6;
            this.s_WeightLbl.Text = "Weight:";
            // 
            // s_Value
            // 
            this.s_Value.AutoSize = true;
            this.s_Value.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.s_Value.Location = new System.Drawing.Point(283, 199);
            this.s_Value.Name = "s_Value";
            this.s_Value.Size = new System.Drawing.Size(54, 20);
            this.s_Value.TabIndex = 7;
            this.s_Value.Text = "Value:";
            // 
            // WeightLbl
            // 
            this.WeightLbl.AutoSize = true;
            this.WeightLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeightLbl.Location = new System.Drawing.Point(356, 172);
            this.WeightLbl.Name = "WeightLbl";
            this.WeightLbl.Size = new System.Drawing.Size(18, 20);
            this.WeightLbl.TabIndex = 8;
            this.WeightLbl.Text = "0";
            // 
            // ValueLbl
            // 
            this.ValueLbl.AutoSize = true;
            this.ValueLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueLbl.Location = new System.Drawing.Point(356, 199);
            this.ValueLbl.Name = "ValueLbl";
            this.ValueLbl.Size = new System.Drawing.Size(18, 20);
            this.ValueLbl.TabIndex = 9;
            this.ValueLbl.Text = "0";
            // 
            // InfoLbl
            // 
            this.InfoLbl.AutoEllipsis = true;
            this.InfoLbl.AutoSize = true;
            this.InfoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoLbl.Location = new System.Drawing.Point(12, 350);
            this.InfoLbl.Name = "InfoLbl";
            this.InfoLbl.Size = new System.Drawing.Size(92, 20);
            this.InfoLbl.TabIndex = 11;
            this.InfoLbl.Text = "Placeholder";
            // 
            // SearchIngBtn
            // 
            this.SearchIngBtn.AutoSize = true;
            this.SearchIngBtn.Location = new System.Drawing.Point(287, 242);
            this.SearchIngBtn.Name = "SearchIngBtn";
            this.SearchIngBtn.Size = new System.Drawing.Size(116, 23);
            this.SearchIngBtn.TabIndex = 12;
            this.SearchIngBtn.Text = "Search by Ingredient";
            this.SearchIngBtn.UseVisualStyleBackColor = true;
            this.SearchIngBtn.Click += new System.EventHandler(this.SearchIngBtn_Click);
            // 
            // SearchIngTB
            // 
            this.SearchIngTB.Location = new System.Drawing.Point(287, 289);
            this.SearchIngTB.Name = "SearchIngTB";
            this.SearchIngTB.Size = new System.Drawing.Size(237, 20);
            this.SearchIngTB.TabIndex = 13;
            // 
            // ShowAllBtn
            // 
            this.ShowAllBtn.Location = new System.Drawing.Point(12, 12);
            this.ShowAllBtn.Name = "ShowAllBtn";
            this.ShowAllBtn.Size = new System.Drawing.Size(75, 23);
            this.ShowAllBtn.TabIndex = 14;
            this.ShowAllBtn.Text = "Show All";
            this.ShowAllBtn.UseVisualStyleBackColor = true;
            this.ShowAllBtn.Click += new System.EventHandler(this.ShowAllBtn_Click);
            // 
            // SearchEffBtn
            // 
            this.SearchEffBtn.AutoSize = true;
            this.SearchEffBtn.Location = new System.Drawing.Point(428, 242);
            this.SearchEffBtn.Name = "SearchEffBtn";
            this.SearchEffBtn.Size = new System.Drawing.Size(96, 23);
            this.SearchEffBtn.TabIndex = 15;
            this.SearchEffBtn.Text = "Search by Effect";
            this.SearchEffBtn.UseVisualStyleBackColor = true;
            this.SearchEffBtn.Click += new System.EventHandler(this.SearchEffBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 379);
            this.Controls.Add(this.SearchEffBtn);
            this.Controls.Add(this.ShowAllBtn);
            this.Controls.Add(this.SearchIngTB);
            this.Controls.Add(this.SearchIngBtn);
            this.Controls.Add(this.InfoLbl);
            this.Controls.Add(this.ValueLbl);
            this.Controls.Add(this.WeightLbl);
            this.Controls.Add(this.s_Value);
            this.Controls.Add(this.s_WeightLbl);
            this.Controls.Add(this.Eff4Lbl);
            this.Controls.Add(this.Eff3Lbl);
            this.Controls.Add(this.Eff2Lbl);
            this.Controls.Add(this.Eff1Lbl);
            this.Controls.Add(this.NameLbl);
            this.Controls.Add(this.IngLB);
            this.Name = "MainForm";
            this.Text = "Skyrim Alchemy Helper";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox IngLB;
        private System.Windows.Forms.Label NameLbl;
        private System.Windows.Forms.Label Eff1Lbl;
        private System.Windows.Forms.Label Eff2Lbl;
        private System.Windows.Forms.Label Eff3Lbl;
        private System.Windows.Forms.Label Eff4Lbl;
        private System.Windows.Forms.Label s_WeightLbl;
        private System.Windows.Forms.Label s_Value;
        private System.Windows.Forms.Label WeightLbl;
        private System.Windows.Forms.Label ValueLbl;
        private System.Windows.Forms.Label InfoLbl;
        private System.Windows.Forms.Button SearchIngBtn;
        private System.Windows.Forms.TextBox SearchIngTB;
        private System.Windows.Forms.Button ShowAllBtn;
        private System.Windows.Forms.Button SearchEffBtn;
    }
}

