namespace UI.UserControls
{
    partial class HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMovies = new System.Windows.Forms.Panel();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // panelMovies
            // 
            this.panelMovies.BackColor = System.Drawing.Color.Transparent;
            this.panelMovies.Location = new System.Drawing.Point(0, 137);
            this.panelMovies.Name = "panelMovies";
            this.panelMovies.Size = new System.Drawing.Size(1015, 300);
            this.panelMovies.TabIndex = 0;
            // 
            // genreComboBox
            // 
            this.genreComboBox.BackColor = System.Drawing.Color.Black;
            this.genreComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.genreComboBox.DropDownWidth = 150;
            this.genreComboBox.Font = new System.Drawing.Font("Cambria", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genreComboBox.ForeColor = System.Drawing.Color.Firebrick;
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.IntegralHeight = false;
            this.genreComboBox.Items.AddRange(new object[] {
            "All Movies",
            "Action",
            "Adventure",
            "Animation",
            "Comedy",
            "Crime",
            "Drama",
            "Family",
            "Fantasy",
            "Music",
            "Science Fiction",
            "Suspense"});
            this.genreComboBox.Location = new System.Drawing.Point(21, 18);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(176, 29);
            this.genreComboBox.TabIndex = 1;
            this.genreComboBox.SelectedIndexChanged += new System.EventHandler(this.genreComboBox_SelectedIndexChanged);
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.panelMovies);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(1015, 437);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMovies;
        private System.Windows.Forms.ComboBox genreComboBox;
    }
}
