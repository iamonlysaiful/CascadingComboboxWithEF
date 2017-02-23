namespace CascadingDropdown
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
            this.ldiv = new System.Windows.Forms.Label();
            this.lDis = new System.Windows.Forms.Label();
            this.cCountry = new System.Windows.Forms.ComboBox();
            this.cState = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cCity = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ldiv
            // 
            this.ldiv.AutoSize = true;
            this.ldiv.Location = new System.Drawing.Point(22, 21);
            this.ldiv.Name = "ldiv";
            this.ldiv.Size = new System.Drawing.Size(49, 13);
            this.ldiv.TabIndex = 0;
            this.ldiv.Text = "Country :";
            // 
            // lDis
            // 
            this.lDis.AutoSize = true;
            this.lDis.Location = new System.Drawing.Point(22, 75);
            this.lDis.Name = "lDis";
            this.lDis.Size = new System.Drawing.Size(38, 13);
            this.lDis.TabIndex = 0;
            this.lDis.Text = "State :";
            // 
            // cCountry
            // 
            this.cCountry.FormattingEnabled = true;
            this.cCountry.Location = new System.Drawing.Point(92, 18);
            this.cCountry.Name = "cCountry";
            this.cCountry.Size = new System.Drawing.Size(121, 21);
            this.cCountry.TabIndex = 1;
            this.cCountry.SelectedIndexChanged += new System.EventHandler(this.cCountry_SelectedIndexChanged);
            // 
            // cState
            // 
            this.cState.FormattingEnabled = true;
            this.cState.Items.AddRange(new object[] {
            "-- Select --"});
            this.cState.Location = new System.Drawing.Point(92, 67);
            this.cState.Name = "cState";
            this.cState.Size = new System.Drawing.Size(121, 21);
            this.cState.TabIndex = 1;
            this.cState.SelectedIndexChanged += new System.EventHandler(this.cState_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "City :";
            // 
            // cCity
            // 
            this.cCity.FormattingEnabled = true;
            this.cCity.Location = new System.Drawing.Point(92, 117);
            this.cCity.Name = "cCity";
            this.cCity.Size = new System.Drawing.Size(121, 21);
            this.cCity.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 163);
            this.Controls.Add(this.cCity);
            this.Controls.Add(this.cState);
            this.Controls.Add(this.cCountry);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lDis);
            this.Controls.Add(this.ldiv);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ldiv;
        private System.Windows.Forms.Label lDis;
        private System.Windows.Forms.ComboBox cCountry;
        private System.Windows.Forms.ComboBox cState;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cCity;
    }
}

