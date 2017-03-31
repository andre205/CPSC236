namespace tAndrews_proj04
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
            this.boxMovies = new System.Windows.Forms.ListBox();
            this.buttonAddMovie = new System.Windows.Forms.Button();
            this.textboxMovieTitle = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textboxMovieYear = new System.Windows.Forms.TextBox();
            this.labelYear = new System.Windows.Forms.Label();
            this.textboxMovieGenre = new System.Windows.Forms.TextBox();
            this.labelGenre = new System.Windows.Forms.Label();
            this.labelMovieBox = new System.Windows.Forms.Label();
            this.buttonRemoveMovie = new System.Windows.Forms.Button();
            this.boxCDs = new System.Windows.Forms.ListBox();
            this.labelCDRecord = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textboxCDGenre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textboxCDYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textboxCDTitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textboxBookGenre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textboxBookYear = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textboxBookTitle = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.boxBooks = new System.Windows.Forms.ListBox();
            this.buttonRemoveCD = new System.Windows.Forms.Button();
            this.buttonRemoveBook = new System.Windows.Forms.Button();
            this.buttonAddCD = new System.Windows.Forms.Button();
            this.buttonAddBook = new System.Windows.Forms.Button();
            this.labelMovieError = new System.Windows.Forms.Label();
            this.labelCDError = new System.Windows.Forms.Label();
            this.labelBookError = new System.Windows.Forms.Label();
            this.textboxMovieDisplay = new System.Windows.Forms.TextBox();
            this.textboxCDDisplay = new System.Windows.Forms.TextBox();
            this.textboxBookDisplay = new System.Windows.Forms.TextBox();
            this.textboxMovieDisplay2 = new System.Windows.Forms.TextBox();
            this.textboxMovieDisplay3 = new System.Windows.Forms.TextBox();
            this.textboxCDDisplay2 = new System.Windows.Forms.TextBox();
            this.textboxCDDisplay3 = new System.Windows.Forms.TextBox();
            this.textboxBookDisplay2 = new System.Windows.Forms.TextBox();
            this.textboxBookDisplay3 = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // boxMovies
            // 
            this.boxMovies.FormattingEnabled = true;
            this.boxMovies.ItemHeight = 25;
            this.boxMovies.Location = new System.Drawing.Point(278, 54);
            this.boxMovies.Name = "boxMovies";
            this.boxMovies.Size = new System.Drawing.Size(309, 554);
            this.boxMovies.TabIndex = 0;
            this.boxMovies.SelectedIndexChanged += new System.EventHandler(this.boxMovies_SelectedIndexChanged);
            // 
            // buttonAddMovie
            // 
            this.buttonAddMovie.Location = new System.Drawing.Point(17, 327);
            this.buttonAddMovie.Name = "buttonAddMovie";
            this.buttonAddMovie.Size = new System.Drawing.Size(181, 45);
            this.buttonAddMovie.TabIndex = 1;
            this.buttonAddMovie.Text = "Add Movie";
            this.buttonAddMovie.UseVisualStyleBackColor = true;
            this.buttonAddMovie.Click += new System.EventHandler(this.buttonAddMovie_Click);
            // 
            // textboxMovieTitle
            // 
            this.textboxMovieTitle.Location = new System.Drawing.Point(17, 82);
            this.textboxMovieTitle.Name = "textboxMovieTitle";
            this.textboxMovieTitle.Size = new System.Drawing.Size(193, 31);
            this.textboxMovieTitle.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(12, 54);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(152, 25);
            this.labelTitle.TabIndex = 3;
            this.labelTitle.Text = "Enter the Title:";
            // 
            // textboxMovieYear
            // 
            this.textboxMovieYear.Location = new System.Drawing.Point(17, 168);
            this.textboxMovieYear.Name = "textboxMovieYear";
            this.textboxMovieYear.Size = new System.Drawing.Size(193, 31);
            this.textboxMovieYear.TabIndex = 4;
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Location = new System.Drawing.Point(12, 140);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(242, 25);
            this.labelYear.TabIndex = 5;
            this.labelYear.Text = "Enter the Release Year:";
            // 
            // textboxMovieGenre
            // 
            this.textboxMovieGenre.Location = new System.Drawing.Point(17, 252);
            this.textboxMovieGenre.Name = "textboxMovieGenre";
            this.textboxMovieGenre.Size = new System.Drawing.Size(193, 31);
            this.textboxMovieGenre.TabIndex = 6;
            // 
            // labelGenre
            // 
            this.labelGenre.AutoSize = true;
            this.labelGenre.Location = new System.Drawing.Point(12, 224);
            this.labelGenre.Name = "labelGenre";
            this.labelGenre.Size = new System.Drawing.Size(170, 25);
            this.labelGenre.TabIndex = 7;
            this.labelGenre.Text = "Enter the Genre:";
            // 
            // labelMovieBox
            // 
            this.labelMovieBox.AutoSize = true;
            this.labelMovieBox.Location = new System.Drawing.Point(320, 9);
            this.labelMovieBox.Name = "labelMovieBox";
            this.labelMovieBox.Size = new System.Drawing.Size(212, 25);
            this.labelMovieBox.TabIndex = 8;
            this.labelMovieBox.Text = "- Movies on Record -";
            // 
            // buttonRemoveMovie
            // 
            this.buttonRemoveMovie.Location = new System.Drawing.Point(17, 559);
            this.buttonRemoveMovie.Name = "buttonRemoveMovie";
            this.buttonRemoveMovie.Size = new System.Drawing.Size(181, 49);
            this.buttonRemoveMovie.TabIndex = 9;
            this.buttonRemoveMovie.Text = "Remove Movie";
            this.buttonRemoveMovie.UseVisualStyleBackColor = true;
            this.buttonRemoveMovie.Click += new System.EventHandler(this.buttonRemoveMovie_Click);
            // 
            // boxCDs
            // 
            this.boxCDs.FormattingEnabled = true;
            this.boxCDs.ItemHeight = 25;
            this.boxCDs.Location = new System.Drawing.Point(877, 54);
            this.boxCDs.Name = "boxCDs";
            this.boxCDs.Size = new System.Drawing.Size(309, 554);
            this.boxCDs.TabIndex = 10;
            this.boxCDs.SelectedIndexChanged += new System.EventHandler(this.boxCDs_SelectedIndexChanged);
            // 
            // labelCDRecord
            // 
            this.labelCDRecord.AutoSize = true;
            this.labelCDRecord.Location = new System.Drawing.Point(935, 9);
            this.labelCDRecord.Name = "labelCDRecord";
            this.labelCDRecord.Size = new System.Drawing.Size(184, 25);
            this.labelCDRecord.TabIndex = 11;
            this.labelCDRecord.Text = "- CDs on Record -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(620, 224);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Enter the Genre:";
            // 
            // textboxCDGenre
            // 
            this.textboxCDGenre.Location = new System.Drawing.Point(625, 252);
            this.textboxCDGenre.Name = "textboxCDGenre";
            this.textboxCDGenre.Size = new System.Drawing.Size(193, 31);
            this.textboxCDGenre.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(620, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Enter the Release Year:";
            // 
            // textboxCDYear
            // 
            this.textboxCDYear.Location = new System.Drawing.Point(625, 168);
            this.textboxCDYear.Name = "textboxCDYear";
            this.textboxCDYear.Size = new System.Drawing.Size(193, 31);
            this.textboxCDYear.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(620, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "Enter the Title:";
            // 
            // textboxCDTitle
            // 
            this.textboxCDTitle.Location = new System.Drawing.Point(625, 82);
            this.textboxCDTitle.Name = "textboxCDTitle";
            this.textboxCDTitle.Size = new System.Drawing.Size(193, 31);
            this.textboxCDTitle.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(1242, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 25);
            this.label4.TabIndex = 25;
            this.label4.Text = "Enter the Genre:";
            // 
            // textboxBookGenre
            // 
            this.textboxBookGenre.Location = new System.Drawing.Point(1247, 252);
            this.textboxBookGenre.Name = "textboxBookGenre";
            this.textboxBookGenre.Size = new System.Drawing.Size(193, 31);
            this.textboxBookGenre.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1242, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(242, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "Enter the Release Year:";
            // 
            // textboxBookYear
            // 
            this.textboxBookYear.Location = new System.Drawing.Point(1247, 168);
            this.textboxBookYear.Name = "textboxBookYear";
            this.textboxBookYear.Size = new System.Drawing.Size(193, 31);
            this.textboxBookYear.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1242, 54);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 25);
            this.label6.TabIndex = 21;
            this.label6.Text = "Enter the Title:";
            // 
            // textboxBookTitle
            // 
            this.textboxBookTitle.Location = new System.Drawing.Point(1247, 82);
            this.textboxBookTitle.Name = "textboxBookTitle";
            this.textboxBookTitle.Size = new System.Drawing.Size(193, 31);
            this.textboxBookTitle.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(1555, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(203, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "- Books on Record -";
            // 
            // boxBooks
            // 
            this.boxBooks.FormattingEnabled = true;
            this.boxBooks.ItemHeight = 25;
            this.boxBooks.Location = new System.Drawing.Point(1499, 54);
            this.boxBooks.Name = "boxBooks";
            this.boxBooks.Size = new System.Drawing.Size(309, 554);
            this.boxBooks.TabIndex = 18;
            this.boxBooks.SelectedIndexChanged += new System.EventHandler(this.boxBooks_SelectedIndexChanged);
            // 
            // buttonRemoveCD
            // 
            this.buttonRemoveCD.Location = new System.Drawing.Point(625, 559);
            this.buttonRemoveCD.Name = "buttonRemoveCD";
            this.buttonRemoveCD.Size = new System.Drawing.Size(181, 49);
            this.buttonRemoveCD.TabIndex = 26;
            this.buttonRemoveCD.Text = "Remove CD";
            this.buttonRemoveCD.UseVisualStyleBackColor = true;
            this.buttonRemoveCD.Click += new System.EventHandler(this.buttonRemoveCD_Click);
            // 
            // buttonRemoveBook
            // 
            this.buttonRemoveBook.Location = new System.Drawing.Point(1247, 559);
            this.buttonRemoveBook.Name = "buttonRemoveBook";
            this.buttonRemoveBook.Size = new System.Drawing.Size(181, 49);
            this.buttonRemoveBook.TabIndex = 27;
            this.buttonRemoveBook.Text = "Remove Book";
            this.buttonRemoveBook.UseVisualStyleBackColor = true;
            this.buttonRemoveBook.Click += new System.EventHandler(this.buttonRemoveBook_Click);
            // 
            // buttonAddCD
            // 
            this.buttonAddCD.Location = new System.Drawing.Point(625, 327);
            this.buttonAddCD.Name = "buttonAddCD";
            this.buttonAddCD.Size = new System.Drawing.Size(181, 45);
            this.buttonAddCD.TabIndex = 28;
            this.buttonAddCD.Text = "Add CD";
            this.buttonAddCD.UseVisualStyleBackColor = true;
            this.buttonAddCD.Click += new System.EventHandler(this.buttonAddCD_Click);
            // 
            // buttonAddBook
            // 
            this.buttonAddBook.Location = new System.Drawing.Point(1247, 327);
            this.buttonAddBook.Name = "buttonAddBook";
            this.buttonAddBook.Size = new System.Drawing.Size(181, 45);
            this.buttonAddBook.TabIndex = 29;
            this.buttonAddBook.Text = "Add Book";
            this.buttonAddBook.UseVisualStyleBackColor = true;
            this.buttonAddBook.Click += new System.EventHandler(this.buttonAddBook_Click);
            // 
            // labelMovieError
            // 
            this.labelMovieError.AutoSize = true;
            this.labelMovieError.Location = new System.Drawing.Point(12, 630);
            this.labelMovieError.Name = "labelMovieError";
            this.labelMovieError.Size = new System.Drawing.Size(0, 25);
            this.labelMovieError.TabIndex = 30;
            // 
            // labelCDError
            // 
            this.labelCDError.AutoSize = true;
            this.labelCDError.Location = new System.Drawing.Point(620, 630);
            this.labelCDError.Name = "labelCDError";
            this.labelCDError.Size = new System.Drawing.Size(0, 25);
            this.labelCDError.TabIndex = 31;
            // 
            // labelBookError
            // 
            this.labelBookError.AutoSize = true;
            this.labelBookError.Location = new System.Drawing.Point(1242, 630);
            this.labelBookError.Name = "labelBookError";
            this.labelBookError.Size = new System.Drawing.Size(0, 25);
            this.labelBookError.TabIndex = 32;
            // 
            // textboxMovieDisplay
            // 
            this.textboxMovieDisplay.Location = new System.Drawing.Point(278, 683);
            this.textboxMovieDisplay.Name = "textboxMovieDisplay";
            this.textboxMovieDisplay.Size = new System.Drawing.Size(309, 31);
            this.textboxMovieDisplay.TabIndex = 33;
            // 
            // textboxCDDisplay
            // 
            this.textboxCDDisplay.Location = new System.Drawing.Point(877, 683);
            this.textboxCDDisplay.Name = "textboxCDDisplay";
            this.textboxCDDisplay.Size = new System.Drawing.Size(309, 31);
            this.textboxCDDisplay.TabIndex = 34;
            // 
            // textboxBookDisplay
            // 
            this.textboxBookDisplay.Location = new System.Drawing.Point(1499, 683);
            this.textboxBookDisplay.Name = "textboxBookDisplay";
            this.textboxBookDisplay.Size = new System.Drawing.Size(309, 31);
            this.textboxBookDisplay.TabIndex = 35;
            // 
            // textboxMovieDisplay2
            // 
            this.textboxMovieDisplay2.Location = new System.Drawing.Point(278, 736);
            this.textboxMovieDisplay2.Name = "textboxMovieDisplay2";
            this.textboxMovieDisplay2.Size = new System.Drawing.Size(309, 31);
            this.textboxMovieDisplay2.TabIndex = 36;
            // 
            // textboxMovieDisplay3
            // 
            this.textboxMovieDisplay3.Location = new System.Drawing.Point(278, 789);
            this.textboxMovieDisplay3.Name = "textboxMovieDisplay3";
            this.textboxMovieDisplay3.Size = new System.Drawing.Size(309, 31);
            this.textboxMovieDisplay3.TabIndex = 37;
            // 
            // textboxCDDisplay2
            // 
            this.textboxCDDisplay2.Location = new System.Drawing.Point(877, 736);
            this.textboxCDDisplay2.Name = "textboxCDDisplay2";
            this.textboxCDDisplay2.Size = new System.Drawing.Size(309, 31);
            this.textboxCDDisplay2.TabIndex = 38;
            // 
            // textboxCDDisplay3
            // 
            this.textboxCDDisplay3.Location = new System.Drawing.Point(877, 789);
            this.textboxCDDisplay3.Name = "textboxCDDisplay3";
            this.textboxCDDisplay3.Size = new System.Drawing.Size(309, 31);
            this.textboxCDDisplay3.TabIndex = 39;
            // 
            // textboxBookDisplay2
            // 
            this.textboxBookDisplay2.Location = new System.Drawing.Point(1499, 736);
            this.textboxBookDisplay2.Name = "textboxBookDisplay2";
            this.textboxBookDisplay2.Size = new System.Drawing.Size(309, 31);
            this.textboxBookDisplay2.TabIndex = 40;
            // 
            // textboxBookDisplay3
            // 
            this.textboxBookDisplay3.Location = new System.Drawing.Point(1499, 789);
            this.textboxBookDisplay3.Name = "textboxBookDisplay3";
            this.textboxBookDisplay3.Size = new System.Drawing.Size(309, 31);
            this.textboxBookDisplay3.TabIndex = 41;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(17, 730);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(181, 43);
            this.buttonSave.TabIndex = 42;
            this.buttonSave.Text = "Save All Data";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 955);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textboxBookDisplay3);
            this.Controls.Add(this.textboxBookDisplay2);
            this.Controls.Add(this.textboxCDDisplay3);
            this.Controls.Add(this.textboxCDDisplay2);
            this.Controls.Add(this.textboxMovieDisplay3);
            this.Controls.Add(this.textboxMovieDisplay2);
            this.Controls.Add(this.textboxBookDisplay);
            this.Controls.Add(this.textboxCDDisplay);
            this.Controls.Add(this.textboxMovieDisplay);
            this.Controls.Add(this.labelBookError);
            this.Controls.Add(this.labelCDError);
            this.Controls.Add(this.labelMovieError);
            this.Controls.Add(this.buttonAddBook);
            this.Controls.Add(this.buttonAddCD);
            this.Controls.Add(this.buttonRemoveBook);
            this.Controls.Add(this.buttonRemoveCD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textboxBookGenre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textboxBookYear);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textboxBookTitle);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.boxBooks);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textboxCDGenre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textboxCDYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textboxCDTitle);
            this.Controls.Add(this.labelCDRecord);
            this.Controls.Add(this.boxCDs);
            this.Controls.Add(this.buttonRemoveMovie);
            this.Controls.Add(this.labelMovieBox);
            this.Controls.Add(this.labelGenre);
            this.Controls.Add(this.textboxMovieGenre);
            this.Controls.Add(this.labelYear);
            this.Controls.Add(this.textboxMovieYear);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.textboxMovieTitle);
            this.Controls.Add(this.buttonAddMovie);
            this.Controls.Add(this.boxMovies);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox boxMovies;
        private System.Windows.Forms.Button buttonAddMovie;
        private System.Windows.Forms.TextBox textboxMovieTitle;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox textboxMovieYear;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.TextBox textboxMovieGenre;
        private System.Windows.Forms.Label labelGenre;
        private System.Windows.Forms.Label labelMovieBox;
        private System.Windows.Forms.Button buttonRemoveMovie;
        private System.Windows.Forms.ListBox boxCDs;
        private System.Windows.Forms.Label labelCDRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textboxCDGenre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textboxCDYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textboxCDTitle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textboxBookGenre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textboxBookYear;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textboxBookTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox boxBooks;
        private System.Windows.Forms.Button buttonRemoveCD;
        private System.Windows.Forms.Button buttonRemoveBook;
        private System.Windows.Forms.Button buttonAddCD;
        private System.Windows.Forms.Button buttonAddBook;
        private System.Windows.Forms.Label labelMovieError;
        private System.Windows.Forms.Label labelCDError;
        private System.Windows.Forms.Label labelBookError;
        private System.Windows.Forms.TextBox textboxMovieDisplay;
        private System.Windows.Forms.TextBox textboxCDDisplay;
        private System.Windows.Forms.TextBox textboxBookDisplay;
        private System.Windows.Forms.TextBox textboxMovieDisplay2;
        private System.Windows.Forms.TextBox textboxMovieDisplay3;
        private System.Windows.Forms.TextBox textboxCDDisplay2;
        private System.Windows.Forms.TextBox textboxCDDisplay3;
        private System.Windows.Forms.TextBox textboxBookDisplay2;
        private System.Windows.Forms.TextBox textboxBookDisplay3;
        private System.Windows.Forms.Button buttonSave;
    }
}

