
namespace HairSalonCSharp
{
    partial class Form_Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_Start = new System.Windows.Forms.Button();
            this.listBox_Customers = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label_HairCurrentComposition = new System.Windows.Forms.Label();
            this.pictureBox_HairCurrentPhoto = new System.Windows.Forms.PictureBox();
            this.panel_HairCurrentColor = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.label_HairCurrentColor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_HairCurrentLength = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label_HairDesiredComposition = new System.Windows.Forms.Label();
            this.panel_HairDesiredColor = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label_HairDesiredColor = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label_HairDesiredLength = new System.Windows.Forms.Label();
            this.pictureBox_HairDesiredPhoto = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_Id = new System.Windows.Forms.Label();
            this.label_Age = new System.Windows.Forms.Label();
            this.label_Gender = new System.Windows.Forms.Label();
            this.label_Name = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label_Mood = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label_SpecialAffection = new System.Windows.Forms.Label();
            this.button_RollDice = new System.Windows.Forms.Button();
            this.label_Dice1 = new System.Windows.Forms.Label();
            this.label_Dice2 = new System.Windows.Forms.Label();
            this.label_DiceSum = new System.Windows.Forms.Label();
            this.label_AffectionText = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HairCurrentPhoto)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HairDesiredPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(653, 38);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(106, 71);
            this.button_Start.TabIndex = 0;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // listBox_Customers
            // 
            this.listBox_Customers.Font = new System.Drawing.Font("Museo Sans 300", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox_Customers.FormattingEnabled = true;
            this.listBox_Customers.ItemHeight = 19;
            this.listBox_Customers.Location = new System.Drawing.Point(15, 25);
            this.listBox_Customers.Name = "listBox_Customers";
            this.listBox_Customers.Size = new System.Drawing.Size(216, 118);
            this.listBox_Customers.TabIndex = 5;
            this.listBox_Customers.SelectedIndexChanged += new System.EventHandler(this.listBox_Customers_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Customer List:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label_HairCurrentComposition);
            this.groupBox1.Controls.Add(this.pictureBox_HairCurrentPhoto);
            this.groupBox1.Controls.Add(this.panel_HairCurrentColor);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label_HairCurrentColor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label_HairCurrentLength);
            this.groupBox1.Location = new System.Drawing.Point(15, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 157);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Current State";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 61);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 13);
            this.label9.TabIndex = 41;
            this.label9.Text = "Composition:";
            // 
            // label_HairCurrentComposition
            // 
            this.label_HairCurrentComposition.AutoSize = true;
            this.label_HairCurrentComposition.Location = new System.Drawing.Point(77, 61);
            this.label_HairCurrentComposition.Name = "label_HairCurrentComposition";
            this.label_HairCurrentComposition.Size = new System.Drawing.Size(145, 13);
            this.label_HairCurrentComposition.TabIndex = 40;
            this.label_HairCurrentComposition.Text = "label_HairCurrentComposition";
            // 
            // pictureBox_HairCurrentPhoto
            // 
            this.pictureBox_HairCurrentPhoto.Location = new System.Drawing.Point(238, 16);
            this.pictureBox_HairCurrentPhoto.Name = "pictureBox_HairCurrentPhoto";
            this.pictureBox_HairCurrentPhoto.Size = new System.Drawing.Size(130, 126);
            this.pictureBox_HairCurrentPhoto.TabIndex = 39;
            this.pictureBox_HairCurrentPhoto.TabStop = false;
            // 
            // panel_HairCurrentColor
            // 
            this.panel_HairCurrentColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel_HairCurrentColor.Location = new System.Drawing.Point(80, 42);
            this.panel_HairCurrentColor.Name = "panel_HairCurrentColor";
            this.panel_HairCurrentColor.Size = new System.Drawing.Size(34, 13);
            this.panel_HairCurrentColor.TabIndex = 38;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 42);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Color:";
            // 
            // label_HairCurrentColor
            // 
            this.label_HairCurrentColor.AutoSize = true;
            this.label_HairCurrentColor.Location = new System.Drawing.Point(120, 42);
            this.label_HairCurrentColor.Name = "label_HairCurrentColor";
            this.label_HairCurrentColor.Size = new System.Drawing.Size(112, 13);
            this.label_HairCurrentColor.TabIndex = 36;
            this.label_HairCurrentColor.Text = "label_HairCurrentColor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Length:";
            // 
            // label_HairCurrentLength
            // 
            this.label_HairCurrentLength.AutoSize = true;
            this.label_HairCurrentLength.Location = new System.Drawing.Point(77, 22);
            this.label_HairCurrentLength.Name = "label_HairCurrentLength";
            this.label_HairCurrentLength.Size = new System.Drawing.Size(121, 13);
            this.label_HairCurrentLength.TabIndex = 34;
            this.label_HairCurrentLength.Text = "label_HairCurrentLength";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label_HairDesiredComposition);
            this.groupBox2.Controls.Add(this.panel_HairDesiredColor);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label_HairDesiredColor);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label_HairDesiredLength);
            this.groupBox2.Controls.Add(this.pictureBox_HairDesiredPhoto);
            this.groupBox2.Location = new System.Drawing.Point(403, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(382, 157);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Target State";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(67, 13);
            this.label11.TabIndex = 45;
            this.label11.Text = "Composition:";
            // 
            // label_HairDesiredComposition
            // 
            this.label_HairDesiredComposition.AutoSize = true;
            this.label_HairDesiredComposition.Location = new System.Drawing.Point(77, 61);
            this.label_HairDesiredComposition.Name = "label_HairDesiredComposition";
            this.label_HairDesiredComposition.Size = new System.Drawing.Size(147, 13);
            this.label_HairDesiredComposition.TabIndex = 44;
            this.label_HairDesiredComposition.Text = "label_HairDesiredComposition";
            // 
            // panel_HairDesiredColor
            // 
            this.panel_HairDesiredColor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.panel_HairDesiredColor.Location = new System.Drawing.Point(80, 42);
            this.panel_HairDesiredColor.Name = "panel_HairDesiredColor";
            this.panel_HairDesiredColor.Size = new System.Drawing.Size(34, 13);
            this.panel_HairDesiredColor.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Hair Color:";
            // 
            // label_HairDesiredColor
            // 
            this.label_HairDesiredColor.AutoSize = true;
            this.label_HairDesiredColor.Location = new System.Drawing.Point(120, 42);
            this.label_HairDesiredColor.Name = "label_HairDesiredColor";
            this.label_HairDesiredColor.Size = new System.Drawing.Size(114, 13);
            this.label_HairDesiredColor.TabIndex = 41;
            this.label_HairDesiredColor.Text = "label_HairDesiredColor";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(65, 13);
            this.label10.TabIndex = 40;
            this.label10.Text = "Hair Length:";
            // 
            // label_HairDesiredLength
            // 
            this.label_HairDesiredLength.AutoSize = true;
            this.label_HairDesiredLength.Location = new System.Drawing.Point(77, 22);
            this.label_HairDesiredLength.Name = "label_HairDesiredLength";
            this.label_HairDesiredLength.Size = new System.Drawing.Size(123, 13);
            this.label_HairDesiredLength.TabIndex = 39;
            this.label_HairDesiredLength.Text = "label_HairDesiredLength";
            // 
            // pictureBox_HairDesiredPhoto
            // 
            this.pictureBox_HairDesiredPhoto.Location = new System.Drawing.Point(240, 16);
            this.pictureBox_HairDesiredPhoto.Name = "pictureBox_HairDesiredPhoto";
            this.pictureBox_HairDesiredPhoto.Size = new System.Drawing.Size(130, 126);
            this.pictureBox_HairDesiredPhoto.TabIndex = 18;
            this.pictureBox_HairDesiredPhoto.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(255, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 54;
            this.label5.Text = "Gender:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(255, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 17);
            this.label4.TabIndex = 53;
            this.label4.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Age:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(255, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 17);
            this.label2.TabIndex = 51;
            this.label2.Text = "ID:";
            // 
            // label_Id
            // 
            this.label_Id.AutoSize = true;
            this.label_Id.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Id.Location = new System.Drawing.Point(326, 25);
            this.label_Id.Name = "label_Id";
            this.label_Id.Size = new System.Drawing.Size(57, 17);
            this.label_Id.TabIndex = 50;
            this.label_Id.Text = "label_Id";
            // 
            // label_Age
            // 
            this.label_Age.AutoSize = true;
            this.label_Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Age.Location = new System.Drawing.Point(326, 92);
            this.label_Age.Name = "label_Age";
            this.label_Age.Size = new System.Drawing.Size(71, 17);
            this.label_Age.TabIndex = 49;
            this.label_Age.Text = "label_Age";
            // 
            // label_Gender
            // 
            this.label_Gender.AutoSize = true;
            this.label_Gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Gender.Location = new System.Drawing.Point(326, 69);
            this.label_Gender.Name = "label_Gender";
            this.label_Gender.Size = new System.Drawing.Size(94, 17);
            this.label_Gender.TabIndex = 48;
            this.label_Gender.Text = "label_Gender";
            // 
            // label_Name
            // 
            this.label_Name.AutoSize = true;
            this.label_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Name.Location = new System.Drawing.Point(326, 47);
            this.label_Name.Name = "label_Name";
            this.label_Name.Size = new System.Drawing.Size(83, 17);
            this.label_Name.TabIndex = 47;
            this.label_Name.Text = "label_Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(255, 116);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(52, 17);
            this.label12.TabIndex = 56;
            this.label12.Text = "Mood:";
            // 
            // label_Mood
            // 
            this.label_Mood.AutoSize = true;
            this.label_Mood.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Mood.Location = new System.Drawing.Point(326, 116);
            this.label_Mood.Name = "label_Mood";
            this.label_Mood.Size = new System.Drawing.Size(81, 17);
            this.label_Mood.TabIndex = 55;
            this.label_Mood.Text = "label_Mood";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(480, 25);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 17);
            this.label13.TabIndex = 58;
            this.label13.Text = "Special:";
            // 
            // label_SpecialAffection
            // 
            this.label_SpecialAffection.AutoSize = true;
            this.label_SpecialAffection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SpecialAffection.Location = new System.Drawing.Point(480, 47);
            this.label_SpecialAffection.Name = "label_SpecialAffection";
            this.label_SpecialAffection.Size = new System.Drawing.Size(147, 17);
            this.label_SpecialAffection.TabIndex = 57;
            this.label_SpecialAffection.Text = "label_SpecialAffection";
            // 
            // button_RollDice
            // 
            this.button_RollDice.Location = new System.Drawing.Point(253, 316);
            this.button_RollDice.Name = "button_RollDice";
            this.button_RollDice.Size = new System.Drawing.Size(106, 43);
            this.button_RollDice.TabIndex = 59;
            this.button_RollDice.Text = "Roll";
            this.button_RollDice.UseVisualStyleBackColor = true;
            this.button_RollDice.Click += new System.EventHandler(this.button_RollDice_Click);
            // 
            // label_Dice1
            // 
            this.label_Dice1.AutoSize = true;
            this.label_Dice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dice1.Location = new System.Drawing.Point(46, 327);
            this.label_Dice1.Name = "label_Dice1";
            this.label_Dice1.Size = new System.Drawing.Size(16, 18);
            this.label_Dice1.TabIndex = 42;
            this.label_Dice1.Text = "0";
            // 
            // label_Dice2
            // 
            this.label_Dice2.AutoSize = true;
            this.label_Dice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Dice2.Location = new System.Drawing.Point(105, 327);
            this.label_Dice2.Name = "label_Dice2";
            this.label_Dice2.Size = new System.Drawing.Size(16, 18);
            this.label_Dice2.TabIndex = 60;
            this.label_Dice2.Text = "8";
            // 
            // label_DiceSum
            // 
            this.label_DiceSum.AutoSize = true;
            this.label_DiceSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_DiceSum.Location = new System.Drawing.Point(157, 327);
            this.label_DiceSum.Name = "label_DiceSum";
            this.label_DiceSum.Size = new System.Drawing.Size(32, 24);
            this.label_DiceSum.TabIndex = 61;
            this.label_DiceSum.Text = "99";
            // 
            // label_AffectionText
            // 
            this.label_AffectionText.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_AffectionText.Location = new System.Drawing.Point(385, 316);
            this.label_AffectionText.Name = "label_AffectionText";
            this.label_AffectionText.Size = new System.Drawing.Size(388, 43);
            this.label_AffectionText.TabIndex = 62;
            this.label_AffectionText.Text = "99";
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 375);
            this.Controls.Add(this.label_AffectionText);
            this.Controls.Add(this.label_DiceSum);
            this.Controls.Add(this.label_Dice2);
            this.Controls.Add(this.label_Dice1);
            this.Controls.Add(this.button_RollDice);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label_SpecialAffection);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label_Mood);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_Id);
            this.Controls.Add(this.label_Age);
            this.Controls.Add(this.label_Gender);
            this.Controls.Add(this.label_Name);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Customers);
            this.Controls.Add(this.button_Start);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hair Salon C#";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HairCurrentPhoto)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_HairDesiredPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.ListBox listBox_Customers;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_HairCurrentLength;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox_HairDesiredPhoto;
        private System.Windows.Forms.Label label_HairCurrentColor;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel_HairCurrentColor;
        private System.Windows.Forms.Panel panel_HairDesiredColor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_HairDesiredColor;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label_HairDesiredLength;
        private System.Windows.Forms.PictureBox pictureBox_HairCurrentPhoto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_Id;
        private System.Windows.Forms.Label label_Age;
        private System.Windows.Forms.Label label_Gender;
        private System.Windows.Forms.Label label_Name;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_HairCurrentComposition;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label_HairDesiredComposition;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label_Mood;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label_SpecialAffection;
        private System.Windows.Forms.Button button_RollDice;
        private System.Windows.Forms.Label label_Dice1;
        private System.Windows.Forms.Label label_Dice2;
        private System.Windows.Forms.Label label_DiceSum;
        private System.Windows.Forms.Label label_AffectionText;
    }
}

