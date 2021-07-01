
namespace TrackerUI
{
    partial class CreateTeamForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.addTeamMemberButton = new System.Windows.Forms.Button();
            this.selectTeamMemberDropdown = new System.Windows.Forms.ComboBox();
            this.selectTeamMemberLabel = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.createMemberButton = new System.Windows.Forms.Button();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deletedSelectedMemberButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(66, 121);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(509, 43);
            this.teamNameValue.TabIndex = 14;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.teamNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.teamNameLabel.Location = new System.Drawing.Point(54, 73);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(192, 45);
            this.teamNameLabel.TabIndex = 13;
            this.teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.headerLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.headerLabel.Location = new System.Drawing.Point(29, 10);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(272, 62);
            this.headerLabel.TabIndex = 12;
            this.headerLabel.Text = "Create Team";
            // 
            // addTeamMemberButton
            // 
            this.addTeamMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addTeamMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addTeamMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addTeamMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addTeamMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addTeamMemberButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.addTeamMemberButton.Location = new System.Drawing.Point(203, 297);
            this.addTeamMemberButton.Name = "addTeamMemberButton";
            this.addTeamMemberButton.Size = new System.Drawing.Size(198, 53);
            this.addTeamMemberButton.TabIndex = 20;
            this.addTeamMemberButton.Text = "Add Team Member";
            this.addTeamMemberButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMemberDropdown
            // 
            this.selectTeamMemberDropdown.FormattingEnabled = true;
            this.selectTeamMemberDropdown.Location = new System.Drawing.Point(66, 236);
            this.selectTeamMemberDropdown.Name = "selectTeamMemberDropdown";
            this.selectTeamMemberDropdown.Size = new System.Drawing.Size(509, 45);
            this.selectTeamMemberDropdown.TabIndex = 19;
            // 
            // selectTeamMemberLabel
            // 
            this.selectTeamMemberLabel.AutoSize = true;
            this.selectTeamMemberLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectTeamMemberLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.selectTeamMemberLabel.Location = new System.Drawing.Point(54, 176);
            this.selectTeamMemberLabel.Name = "selectTeamMemberLabel";
            this.selectTeamMemberLabel.Size = new System.Drawing.Size(322, 45);
            this.selectTeamMemberLabel.TabIndex = 18;
            this.selectTeamMemberLabel.Text = "Select Team Member";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.createMemberButton);
            this.groupBox1.Controls.Add(this.cellphoneValue);
            this.groupBox1.Controls.Add(this.cellphoneLabel);
            this.groupBox1.Controls.Add(this.emailValue);
            this.groupBox1.Controls.Add(this.emailLabel);
            this.groupBox1.Controls.Add(this.lastNameValue);
            this.groupBox1.Controls.Add(this.lastNameLabel);
            this.groupBox1.Controls.Add(this.firstNameValue);
            this.groupBox1.Controls.Add(this.firstNameLabel);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.groupBox1.Location = new System.Drawing.Point(54, 356);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 405);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Member";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(183, 63);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(335, 43);
            this.firstNameValue.TabIndex = 11;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.firstNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.firstNameLabel.Location = new System.Drawing.Point(10, 60);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(176, 45);
            this.firstNameLabel.TabIndex = 10;
            this.firstNameLabel.Text = "First Name";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(179, 137);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(335, 43);
            this.lastNameValue.TabIndex = 13;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lastNameLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.lastNameLabel.Location = new System.Drawing.Point(11, 134);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(174, 45);
            this.lastNameLabel.TabIndex = 12;
            this.lastNameLabel.Text = "Last Name";
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(179, 200);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(335, 43);
            this.emailValue.TabIndex = 15;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.emailLabel.Location = new System.Drawing.Point(11, 197);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(98, 45);
            this.emailLabel.TabIndex = 14;
            this.emailLabel.Text = "Email";
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Location = new System.Drawing.Point(179, 265);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(335, 43);
            this.cellphoneValue.TabIndex = 17;
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cellphoneLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.cellphoneLabel.Location = new System.Drawing.Point(11, 262);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(174, 45);
            this.cellphoneLabel.TabIndex = 16;
            this.cellphoneLabel.Text = "Cell Phone";
            // 
            // createMemberButton
            // 
            this.createMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.createMemberButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.createMemberButton.Location = new System.Drawing.Point(84, 332);
            this.createMemberButton.Name = "createMemberButton";
            this.createMemberButton.Size = new System.Drawing.Size(328, 53);
            this.createMemberButton.TabIndex = 22;
            this.createMemberButton.Text = " Add New Members";
            this.createMemberButton.UseVisualStyleBackColor = true;
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 37;
            this.teamMembersListBox.Location = new System.Drawing.Point(647, 56);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(579, 557);
            this.teamMembersListBox.TabIndex = 22;
            // 
            // deletedSelectedMemberButton
            // 
            this.deletedSelectedMemberButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deletedSelectedMemberButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deletedSelectedMemberButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deletedSelectedMemberButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletedSelectedMemberButton.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.deletedSelectedMemberButton.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.deletedSelectedMemberButton.Location = new System.Drawing.Point(732, 635);
            this.deletedSelectedMemberButton.Name = "deletedSelectedMemberButton";
            this.deletedSelectedMemberButton.Size = new System.Drawing.Size(431, 106);
            this.deletedSelectedMemberButton.TabIndex = 23;
            this.deletedSelectedMemberButton.Text = "Delete Selected Member";
            this.deletedSelectedMemberButton.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.button1.Location = new System.Drawing.Point(467, 409);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 53);
            this.button1.TabIndex = 24;
            this.button1.Text = " Add New Members";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1262, 870);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.deletedSelectedMemberButton);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.addTeamMemberButton);
            this.Controls.Add(this.selectTeamMemberDropdown);
            this.Controls.Add(this.selectTeamMemberLabel);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button addTeamMemberButton;
        private System.Windows.Forms.ComboBox selectTeamMemberDropdown;
        private System.Windows.Forms.Label selectTeamMemberLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button createMemberButton;
        private System.Windows.Forms.TextBox cellphoneValue;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button deletedSelectedMemberButton;
        private System.Windows.Forms.Button button1;
    }
}