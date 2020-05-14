namespace WindowsForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.personNameInput = new System.Windows.Forms.TextBox();
            this.dataGridViewPersons = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.filterButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.personAgeInput = new System.Windows.Forms.NumericUpDown();
            this.ageFilterInput = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personAgeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageFilterInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personas";
            // 
            // addButton
            // 
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.Location = new System.Drawing.Point(485, 405);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(162, 44);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Agregar";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // personNameInput
            // 
            this.personNameInput.Location = new System.Drawing.Point(196, 386);
            this.personNameInput.Name = "personNameInput";
            this.personNameInput.Size = new System.Drawing.Size(261, 26);
            this.personNameInput.TabIndex = 2;
            // 
            // dataGridViewPersons
            // 
            this.dataGridViewPersons.AllowUserToAddRows = false;
            this.dataGridViewPersons.AllowUserToDeleteRows = false;
            this.dataGridViewPersons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPersons.Location = new System.Drawing.Point(51, 86);
            this.dataGridViewPersons.Name = "dataGridViewPersons";
            this.dataGridViewPersons.ReadOnly = true;
            this.dataGridViewPersons.RowTemplate.Height = 28;
            this.dataGridViewPersons.Size = new System.Drawing.Size(587, 244);
            this.dataGridViewPersons.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 389);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese un nombre";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(679, 86);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(162, 86);
            this.deleteButton.TabIndex = 5;
            this.deleteButton.Text = "Eliminar seleccionado";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(866, 86);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(162, 86);
            this.editButton.TabIndex = 6;
            this.editButton.Text = "Editar seleccionado";
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.Location = new System.Drawing.Point(866, 269);
            this.filterButton.Name = "filterButton";
            this.filterButton.Size = new System.Drawing.Size(162, 61);
            this.filterButton.TabIndex = 7;
            this.filterButton.Text = "Filtrar por edad";
            this.filterButton.UseVisualStyleBackColor = true;
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 429);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ingrese una edad";
            // 
            // personAgeInput
            // 
            this.personAgeInput.Location = new System.Drawing.Point(196, 427);
            this.personAgeInput.Name = "personAgeInput";
            this.personAgeInput.Size = new System.Drawing.Size(120, 26);
            this.personAgeInput.TabIndex = 9;
            this.personAgeInput.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // ageFilterInput
            // 
            this.ageFilterInput.Location = new System.Drawing.Point(740, 287);
            this.ageFilterInput.Name = "ageFilterInput";
            this.ageFilterInput.Size = new System.Drawing.Size(120, 26);
            this.ageFilterInput.TabIndex = 10;
            this.ageFilterInput.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 461);
            this.Controls.Add(this.ageFilterInput);
            this.Controls.Add(this.personAgeInput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filterButton);
            this.Controls.Add(this.editButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewPersons);
            this.Controls.Add(this.personNameInput);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPersons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personAgeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ageFilterInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.TextBox personNameInput;
        private System.Windows.Forms.DataGridView dataGridViewPersons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button filterButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown personAgeInput;
        private System.Windows.Forms.NumericUpDown ageFilterInput;
    }
}

