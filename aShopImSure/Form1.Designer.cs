namespace aShopImSure
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.reciptLabel = new System.Windows.Forms.Label();
            this.gooLabel = new System.Windows.Forms.Label();
            this.meatLabel = new System.Windows.Forms.Label();
            this.eggsLabel = new System.Windows.Forms.Label();
            this.gooInput = new System.Windows.Forms.TextBox();
            this.meatInput = new System.Windows.Forms.TextBox();
            this.eggsInput = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.subTotalLabel = new System.Windows.Forms.Label();
            this.taxLabel = new System.Windows.Forms.Label();
            this.totalLabel = new System.Windows.Forms.Label();
            this.subTotalOutput = new System.Windows.Forms.Label();
            this.taxOutput = new System.Windows.Forms.Label();
            this.totalOutput = new System.Windows.Forms.Label();
            this.lineLabel = new System.Windows.Forms.Label();
            this.tenderedLabel = new System.Windows.Forms.Label();
            this.changeButton = new System.Windows.Forms.Button();
            this.tenderedInput = new System.Windows.Forms.TextBox();
            this.changeLabel = new System.Windows.Forms.Label();
            this.changeOutput = new System.Windows.Forms.Label();
            this.reciptButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // reciptLabel
            // 
            this.reciptLabel.BackColor = System.Drawing.Color.LightGray;
            this.reciptLabel.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptLabel.Location = new System.Drawing.Point(429, 9);
            this.reciptLabel.Name = "reciptLabel";
            this.reciptLabel.Size = new System.Drawing.Size(261, 411);
            this.reciptLabel.TabIndex = 0;
            // 
            // gooLabel
            // 
            this.gooLabel.BackColor = System.Drawing.Color.Transparent;
            this.gooLabel.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gooLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.gooLabel.Location = new System.Drawing.Point(18, 23);
            this.gooLabel.Name = "gooLabel";
            this.gooLabel.Size = new System.Drawing.Size(163, 24);
            this.gooLabel.TabIndex = 2;
            this.gooLabel.Text = "Mysterious Goo";
            this.gooLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // meatLabel
            // 
            this.meatLabel.BackColor = System.Drawing.Color.Transparent;
            this.meatLabel.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.meatLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.meatLabel.Location = new System.Drawing.Point(18, 55);
            this.meatLabel.Name = "meatLabel";
            this.meatLabel.Size = new System.Drawing.Size(198, 24);
            this.meatLabel.TabIndex = 3;
            this.meatLabel.Text = "Some Sort Of Meat";
            this.meatLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // eggsLabel
            // 
            this.eggsLabel.BackColor = System.Drawing.Color.Transparent;
            this.eggsLabel.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eggsLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.eggsLabel.Location = new System.Drawing.Point(18, 88);
            this.eggsLabel.Name = "eggsLabel";
            this.eggsLabel.Size = new System.Drawing.Size(187, 24);
            this.eggsLabel.TabIndex = 4;
            this.eggsLabel.Text = "Questionable Eggs";
            this.eggsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // gooInput
            // 
            this.gooInput.Location = new System.Drawing.Point(276, 25);
            this.gooInput.Name = "gooInput";
            this.gooInput.Size = new System.Drawing.Size(100, 22);
            this.gooInput.TabIndex = 5;
            // 
            // meatInput
            // 
            this.meatInput.Location = new System.Drawing.Point(276, 60);
            this.meatInput.Name = "meatInput";
            this.meatInput.Size = new System.Drawing.Size(100, 22);
            this.meatInput.TabIndex = 6;
            // 
            // eggsInput
            // 
            this.eggsInput.Location = new System.Drawing.Point(276, 93);
            this.eggsInput.Name = "eggsInput";
            this.eggsInput.Size = new System.Drawing.Size(100, 22);
            this.eggsInput.TabIndex = 7;
            // 
            // calculateButton
            // 
            this.calculateButton.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.Location = new System.Drawing.Point(117, 135);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(196, 32);
            this.calculateButton.TabIndex = 8;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // subTotalLabel
            // 
            this.subTotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.subTotalLabel.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subTotalLabel.Location = new System.Drawing.Point(18, 180);
            this.subTotalLabel.Name = "subTotalLabel";
            this.subTotalLabel.Size = new System.Drawing.Size(163, 24);
            this.subTotalLabel.TabIndex = 9;
            this.subTotalLabel.Text = "Sub Total";
            this.subTotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // taxLabel
            // 
            this.taxLabel.BackColor = System.Drawing.Color.Transparent;
            this.taxLabel.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taxLabel.Location = new System.Drawing.Point(18, 214);
            this.taxLabel.Name = "taxLabel";
            this.taxLabel.Size = new System.Drawing.Size(163, 24);
            this.taxLabel.TabIndex = 10;
            this.taxLabel.Text = "Tax";
            this.taxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalLabel
            // 
            this.totalLabel.BackColor = System.Drawing.Color.Transparent;
            this.totalLabel.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalLabel.Location = new System.Drawing.Point(18, 247);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.Size = new System.Drawing.Size(163, 24);
            this.totalLabel.TabIndex = 11;
            this.totalLabel.Text = "Total";
            this.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subTotalOutput
            // 
            this.subTotalOutput.BackColor = System.Drawing.Color.Transparent;
            this.subTotalOutput.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subTotalOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.subTotalOutput.Location = new System.Drawing.Point(269, 180);
            this.subTotalOutput.Name = "subTotalOutput";
            this.subTotalOutput.Size = new System.Drawing.Size(154, 24);
            this.subTotalOutput.TabIndex = 12;
            this.subTotalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // taxOutput
            // 
            this.taxOutput.BackColor = System.Drawing.Color.Transparent;
            this.taxOutput.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taxOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.taxOutput.Location = new System.Drawing.Point(269, 214);
            this.taxOutput.Name = "taxOutput";
            this.taxOutput.Size = new System.Drawing.Size(154, 24);
            this.taxOutput.TabIndex = 13;
            this.taxOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // totalOutput
            // 
            this.totalOutput.BackColor = System.Drawing.Color.Transparent;
            this.totalOutput.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.totalOutput.Location = new System.Drawing.Point(269, 247);
            this.totalOutput.Name = "totalOutput";
            this.totalOutput.Size = new System.Drawing.Size(154, 24);
            this.totalOutput.TabIndex = 14;
            this.totalOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lineLabel
            // 
            this.lineLabel.BackColor = System.Drawing.Color.Black;
            this.lineLabel.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lineLabel.Location = new System.Drawing.Point(12, 280);
            this.lineLabel.Name = "lineLabel";
            this.lineLabel.Size = new System.Drawing.Size(400, 10);
            this.lineLabel.TabIndex = 16;
            this.lineLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tenderedLabel
            // 
            this.tenderedLabel.BackColor = System.Drawing.Color.Transparent;
            this.tenderedLabel.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tenderedLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tenderedLabel.Location = new System.Drawing.Point(18, 299);
            this.tenderedLabel.Name = "tenderedLabel";
            this.tenderedLabel.Size = new System.Drawing.Size(163, 24);
            this.tenderedLabel.TabIndex = 17;
            this.tenderedLabel.Text = "Tendered";
            this.tenderedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeButton
            // 
            this.changeButton.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeButton.Location = new System.Drawing.Point(117, 344);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(196, 32);
            this.changeButton.TabIndex = 18;
            this.changeButton.Text = "Calculate Change";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // tenderedInput
            // 
            this.tenderedInput.Location = new System.Drawing.Point(292, 304);
            this.tenderedInput.Name = "tenderedInput";
            this.tenderedInput.Size = new System.Drawing.Size(100, 22);
            this.tenderedInput.TabIndex = 19;
            // 
            // changeLabel
            // 
            this.changeLabel.BackColor = System.Drawing.Color.Transparent;
            this.changeLabel.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeLabel.Location = new System.Drawing.Point(18, 396);
            this.changeLabel.Name = "changeLabel";
            this.changeLabel.Size = new System.Drawing.Size(163, 24);
            this.changeLabel.TabIndex = 20;
            this.changeLabel.Text = "Change";
            this.changeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // changeOutput
            // 
            this.changeOutput.BackColor = System.Drawing.Color.Transparent;
            this.changeOutput.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeOutput.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeOutput.Location = new System.Drawing.Point(229, 396);
            this.changeOutput.Name = "changeOutput";
            this.changeOutput.Size = new System.Drawing.Size(163, 24);
            this.changeOutput.TabIndex = 21;
            this.changeOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // reciptButton
            // 
            this.reciptButton.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reciptButton.Location = new System.Drawing.Point(117, 431);
            this.reciptButton.Name = "reciptButton";
            this.reciptButton.Size = new System.Drawing.Size(196, 32);
            this.reciptButton.TabIndex = 22;
            this.reciptButton.Text = "Print Recipt";
            this.reciptButton.UseVisualStyleBackColor = true;
            this.reciptButton.Click += new System.EventHandler(this.reciptButton_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.Font = new System.Drawing.Font("Baskerville Old Face", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newOrderButton.Location = new System.Drawing.Point(468, 431);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(196, 32);
            this.newOrderButton.TabIndex = 23;
            this.newOrderButton.Text = "NewOrder";
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(700, 475);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.reciptButton);
            this.Controls.Add(this.changeOutput);
            this.Controls.Add(this.changeLabel);
            this.Controls.Add(this.tenderedInput);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.tenderedLabel);
            this.Controls.Add(this.lineLabel);
            this.Controls.Add(this.totalOutput);
            this.Controls.Add(this.taxOutput);
            this.Controls.Add(this.subTotalOutput);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.taxLabel);
            this.Controls.Add(this.subTotalLabel);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.eggsInput);
            this.Controls.Add(this.meatInput);
            this.Controls.Add(this.gooInput);
            this.Controls.Add(this.eggsLabel);
            this.Controls.Add(this.meatLabel);
            this.Controls.Add(this.gooLabel);
            this.Controls.Add(this.reciptLabel);
            this.Font = new System.Drawing.Font("Baskerville Old Face", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Some Shop Probably";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reciptLabel;
        private System.Windows.Forms.Label gooLabel;
        private System.Windows.Forms.Label meatLabel;
        private System.Windows.Forms.Label eggsLabel;
        private System.Windows.Forms.TextBox gooInput;
        private System.Windows.Forms.TextBox meatInput;
        private System.Windows.Forms.TextBox eggsInput;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label subTotalLabel;
        private System.Windows.Forms.Label taxLabel;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label subTotalOutput;
        private System.Windows.Forms.Label taxOutput;
        private System.Windows.Forms.Label totalOutput;
        private System.Windows.Forms.Label lineLabel;
        private System.Windows.Forms.Label tenderedLabel;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TextBox tenderedInput;
        private System.Windows.Forms.Label changeLabel;
        private System.Windows.Forms.Label changeOutput;
        private System.Windows.Forms.Button reciptButton;
        private System.Windows.Forms.Button newOrderButton;
    }
}

