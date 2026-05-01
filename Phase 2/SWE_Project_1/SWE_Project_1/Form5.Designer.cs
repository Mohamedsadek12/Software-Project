
namespace SWE_Project_1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.button_Generate_CR = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label_Airline_name = new System.Windows.Forms.Label();
            this.comboBox_Airline_name = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button_Generate_CR
            // 
            this.button_Generate_CR.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_Generate_CR.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Generate_CR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Generate_CR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Generate_CR.Location = new System.Drawing.Point(655, 135);
            this.button_Generate_CR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Generate_CR.Name = "button_Generate_CR";
            this.button_Generate_CR.Size = new System.Drawing.Size(702, 61);
            this.button_Generate_CR.TabIndex = 27;
            this.button_Generate_CR.Text = "Generate Report";
            this.button_Generate_CR.UseVisualStyleBackColor = false;
            this.button_Generate_CR.Click += new System.EventHandler(this.button_Generate_CR_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(-2, 227);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1962, 1143);
            this.crystalReportViewer1.TabIndex = 28;
            // 
            // label_Airline_name
            // 
            this.label_Airline_name.AutoSize = true;
            this.label_Airline_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Airline_name.Location = new System.Drawing.Point(647, 54);
            this.label_Airline_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_Airline_name.Name = "label_Airline_name";
            this.label_Airline_name.Size = new System.Drawing.Size(178, 32);
            this.label_Airline_name.TabIndex = 30;
            this.label_Airline_name.Text = "Airline Name";
            this.label_Airline_name.Click += new System.EventHandler(this.label1_Click);
            // 
            // comboBox_Airline_name
            // 
            this.comboBox_Airline_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.857142F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_Airline_name.FormattingEnabled = true;
            this.comboBox_Airline_name.Location = new System.Drawing.Point(920, 50);
            this.comboBox_Airline_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_Airline_name.Name = "comboBox_Airline_name";
            this.comboBox_Airline_name.Size = new System.Drawing.Size(437, 37);
            this.comboBox_Airline_name.TabIndex = 29;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1963, 1369);
            this.Controls.Add(this.label_Airline_name);
            this.Controls.Add(this.comboBox_Airline_name);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.button_Generate_CR);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form5";
            this.Text = "AirLine Report";
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Generate_CR;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label_Airline_name;
        private System.Windows.Forms.ComboBox comboBox_Airline_name;
    }
}