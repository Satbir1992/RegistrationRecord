
namespace RegistrationRecord
{
    partial class RegistrationRecord
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.TextBoxNumber = new System.Windows.Forms.TextBox();
            this.ButtonLinearSearch = new System.Windows.Forms.Button();
            this.ButtonBinarySearch = new System.Windows.Forms.Button();
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonModify = new System.Windows.Forms.Button();
            this.ButtonTag = new System.Windows.Forms.Button();
            this.ButtonReset = new System.Windows.Forms.Button();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.VehiclePlateDisplay = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vehicle Plate Details";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TextBoxNumber
            // 
            this.TextBoxNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxNumber.Location = new System.Drawing.Point(184, 42);
            this.TextBoxNumber.MaxLength = 8;
            this.TextBoxNumber.Name = "TextBoxNumber";
            this.TextBoxNumber.Size = new System.Drawing.Size(117, 26);
            this.TextBoxNumber.TabIndex = 2;
            this.toolTip1.SetToolTip(this.TextBoxNumber, "Enter Vehicle Plate Number");
            this.TextBoxNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxNumber_KeyPress);
            this.TextBoxNumber.Validating += new System.ComponentModel.CancelEventHandler(this.TextBoxNumber_Validating);
            // 
            // ButtonLinearSearch
            // 
            this.ButtonLinearSearch.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonLinearSearch.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLinearSearch.Location = new System.Drawing.Point(317, 42);
            this.ButtonLinearSearch.Name = "ButtonLinearSearch";
            this.ButtonLinearSearch.Size = new System.Drawing.Size(108, 34);
            this.ButtonLinearSearch.TabIndex = 3;
            this.ButtonLinearSearch.Text = "Linear Search";
            this.toolTip1.SetToolTip(this.ButtonLinearSearch, "Click to Search Rego Number");
            this.ButtonLinearSearch.UseVisualStyleBackColor = false;
            this.ButtonLinearSearch.Click += new System.EventHandler(this.ButtonLinearSearch_Click);
            // 
            // ButtonBinarySearch
            // 
            this.ButtonBinarySearch.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonBinarySearch.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonBinarySearch.Location = new System.Drawing.Point(431, 42);
            this.ButtonBinarySearch.Name = "ButtonBinarySearch";
            this.ButtonBinarySearch.Size = new System.Drawing.Size(108, 34);
            this.ButtonBinarySearch.TabIndex = 4;
            this.ButtonBinarySearch.Text = "Binary Search";
            this.toolTip1.SetToolTip(this.ButtonBinarySearch, "Click to Search Rego Number");
            this.ButtonBinarySearch.UseVisualStyleBackColor = false;
            this.ButtonBinarySearch.Click += new System.EventHandler(this.ButtonBinarySearch_Click);
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonEnter.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEnter.Location = new System.Drawing.Point(184, 98);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(117, 34);
            this.ButtonEnter.TabIndex = 5;
            this.ButtonEnter.Text = "Enter";
            this.toolTip1.SetToolTip(this.ButtonEnter, "Click to Enter Vehicle");
            this.ButtonEnter.UseVisualStyleBackColor = false;
            this.ButtonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonExit.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonExit.Location = new System.Drawing.Point(184, 157);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(117, 34);
            this.ButtonExit.TabIndex = 6;
            this.ButtonExit.Text = "Exit";
            this.toolTip1.SetToolTip(this.ButtonExit, "Click to Exit Vehicle");
            this.ButtonExit.UseVisualStyleBackColor = false;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonModify
            // 
            this.ButtonModify.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonModify.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonModify.Location = new System.Drawing.Point(184, 218);
            this.ButtonModify.Name = "ButtonModify";
            this.ButtonModify.Size = new System.Drawing.Size(117, 34);
            this.ButtonModify.TabIndex = 7;
            this.ButtonModify.Text = "Modify";
            this.toolTip1.SetToolTip(this.ButtonModify, "Click to Change Vehicle Rego Number");
            this.ButtonModify.UseVisualStyleBackColor = false;
            this.ButtonModify.Click += new System.EventHandler(this.ButtonModify_Click);
            // 
            // ButtonTag
            // 
            this.ButtonTag.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonTag.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonTag.Location = new System.Drawing.Point(184, 278);
            this.ButtonTag.Name = "ButtonTag";
            this.ButtonTag.Size = new System.Drawing.Size(117, 34);
            this.ButtonTag.TabIndex = 8;
            this.ButtonTag.Text = "Tag";
            this.toolTip1.SetToolTip(this.ButtonTag, "Click to Mark Vehicle Rego Number");
            this.ButtonTag.UseVisualStyleBackColor = false;
            this.ButtonTag.Click += new System.EventHandler(this.ButtonTag_Click);
            // 
            // ButtonReset
            // 
            this.ButtonReset.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonReset.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonReset.Location = new System.Drawing.Point(184, 335);
            this.ButtonReset.Name = "ButtonReset";
            this.ButtonReset.Size = new System.Drawing.Size(117, 34);
            this.ButtonReset.TabIndex = 9;
            this.ButtonReset.Text = "Reset";
            this.toolTip1.SetToolTip(this.ButtonReset, "Click to Clear all vehicle numbers from list");
            this.ButtonReset.UseVisualStyleBackColor = false;
            this.ButtonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonOpen.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOpen.Location = new System.Drawing.Point(355, 128);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(117, 34);
            this.ButtonOpen.TabIndex = 10;
            this.ButtonOpen.Text = "Open";
            this.toolTip1.SetToolTip(this.ButtonOpen, "Click to Open the Previous Record");
            this.ButtonOpen.UseVisualStyleBackColor = false;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ButtonSave.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSave.Location = new System.Drawing.Point(355, 197);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(117, 34);
            this.ButtonSave.TabIndex = 11;
            this.ButtonSave.Text = "Save";
            this.toolTip1.SetToolTip(this.ButtonSave, "Click to Save the Record");
            this.ButtonSave.UseVisualStyleBackColor = false;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 433);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(541, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel1.Text = "Message";
            // 
            // VehiclePlateDisplay
            // 
            this.VehiclePlateDisplay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VehiclePlateDisplay.FormattingEnabled = true;
            this.VehiclePlateDisplay.ItemHeight = 19;
            this.VehiclePlateDisplay.Location = new System.Drawing.Point(36, 42);
            this.VehiclePlateDisplay.Name = "VehiclePlateDisplay";
            this.VehiclePlateDisplay.Size = new System.Drawing.Size(130, 346);
            this.VehiclePlateDisplay.TabIndex = 13;
            this.toolTip1.SetToolTip(this.VehiclePlateDisplay, "Vehicle Number DIsplay List");
            this.VehiclePlateDisplay.Click += new System.EventHandler(this.VehiclePlateDisplay_Click);
            this.VehiclePlateDisplay.SelectedIndexChanged += new System.EventHandler(this.VehiclePlateDisplay_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "Vehicle Plate Screen";
            // 
            // RegistrationRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(541, 455);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.VehiclePlateDisplay);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.ButtonReset);
            this.Controls.Add(this.ButtonTag);
            this.Controls.Add(this.ButtonModify);
            this.Controls.Add(this.ButtonExit);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.ButtonBinarySearch);
            this.Controls.Add(this.ButtonLinearSearch);
            this.Controls.Add(this.TextBoxNumber);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "RegistrationRecord";
            this.Text = "Vehicle Registration Management";
            this.Load += new System.EventHandler(this.RegistrationRecord_Load);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegistrationRecord_MouseMove);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TextBoxNumber;
        private System.Windows.Forms.Button ButtonLinearSearch;
        private System.Windows.Forms.Button ButtonBinarySearch;
        private System.Windows.Forms.Button ButtonEnter;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonModify;
        private System.Windows.Forms.Button ButtonTag;
        private System.Windows.Forms.Button ButtonReset;
        private System.Windows.Forms.Button ButtonOpen;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ListBox VehiclePlateDisplay;
        private System.Windows.Forms.Label label2;
    }
}

