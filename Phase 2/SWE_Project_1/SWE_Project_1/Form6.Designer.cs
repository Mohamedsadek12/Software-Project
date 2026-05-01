
namespace SWE_Project_1
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.label_payment_status = new System.Windows.Forms.Label();
            this.button_Generate_CR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(882, 73);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(406, 32);
            this.comboBox1.TabIndex = 0;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 239);
            this.crystalReportViewer1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1959, 1134);
            this.crystalReportViewer1.TabIndex = 1;
            this.crystalReportViewer1.ToolPanelWidth = 367;
            // 
            // label_payment_status
            // 
            this.label_payment_status.AutoSize = true;
            this.label_payment_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_payment_status.Location = new System.Drawing.Point(580, 73);
            this.label_payment_status.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label_payment_status.Name = "label_payment_status";
            this.label_payment_status.Size = new System.Drawing.Size(215, 32);
            this.label_payment_status.TabIndex = 3;
            this.label_payment_status.Text = "Payment Status";
            this.label_payment_status.Click += new System.EventHandler(this.label_payment_status_Click);
            // 
            // button_Generate_CR
            // 
            this.button_Generate_CR.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_Generate_CR.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Generate_CR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.14286F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Generate_CR.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_Generate_CR.Location = new System.Drawing.Point(586, 137);
            this.button_Generate_CR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_Generate_CR.Name = "button_Generate_CR";
            this.button_Generate_CR.Size = new System.Drawing.Size(702, 61);
            this.button_Generate_CR.TabIndex = 28;
            this.button_Generate_CR.Text = "Generate Report";
            this.button_Generate_CR.UseVisualStyleBackColor = false;
            this.button_Generate_CR.Click += new System.EventHandler(this.button_Generate_CR_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1963, 1369);
            this.Controls.Add(this.button_Generate_CR);
            this.Controls.Add(this.label_payment_status);
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.comboBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form6";
            this.Text = "Payment Info";
            this.Load += new System.EventHandler(this.Form6_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label label_payment_status;
        private System.Windows.Forms.Button button_Generate_CR;
    }
}