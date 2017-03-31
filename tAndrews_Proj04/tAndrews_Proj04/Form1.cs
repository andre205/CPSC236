using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace tAndrews_proj04
{
    public partial class Form1 : Form
    {
        //BINDING LIST DEFINITION
        public BindingList<Movie> movies = new BindingList<Movie>();
        public BindingList<CD> cds = new BindingList<CD>();
        public BindingList<Book> books = new BindingList<Book>();

        public Form1()
        {
            LoadMovieList();
            LoadCDList();
            LoadBookList();



            InitializeComponent();
        }



        //ADD TO LIST
        //Check for text in all 3 text boxes, check year for int, create object with data
        private void buttonAddMovie_Click(object sender, EventArgs e)
        {
            if (textboxMovieTitle.Text != "")
            {
                if (textboxMovieYear.Text != "")
                {
                    if (textboxMovieGenre.Text != "")
                    {
                        int movieYearInt;
                        if (int.TryParse(textboxMovieYear.Text, out movieYearInt))
                        {
                            boxMovies.Items.Add(textboxMovieTitle.Text);

                            movies.Add(new Movie(textboxMovieTitle.Text, movieYearInt, textboxMovieGenre.Text));

                            //Clear error box
                            labelMovieError.Text = "";
                        }
                        else { labelMovieError.Text = "You did not enter a numerical year."; }
                    }
                    else { labelMovieError.Text = "You did not enter a genre."; }
                }
                else { labelMovieError.Text = "You did not enter a year."; }
            }
            else { labelMovieError.Text = "You did not enter a title."; }
        }

        private void buttonAddCD_Click(object sender, EventArgs e)
        {
            if (textboxCDTitle.Text != "")
            {
                if (textboxCDYear.Text != "")
                {
                    if (textboxCDGenre.Text != "")
                    {
                        int cdYearInt;
                        if (int.TryParse(textboxCDYear.Text, out cdYearInt))
                        {
                            boxCDs.Items.Add(textboxCDTitle.Text);

                            cds.Add(new CD(textboxCDTitle.Text, cdYearInt, textboxCDGenre.Text));

                            labelCDError.Text = "";
                        }
                        else { labelCDError.Text = "You did not enter a numerical year."; }
                    }
                    else { labelCDError.Text = "You did not enter a genre."; }
                }
                else { labelCDError.Text = "You did not enter a year."; }
            }
            else { labelCDError.Text = "You did not enter a title."; }
        }

        private void buttonAddBook_Click(object sender, EventArgs e)
        {
            if (textboxBookTitle.Text != "")
            {
                if (textboxBookYear.Text != "")
                {
                    if (textboxBookGenre.Text != "")
                    {
                        int bookYearInt;
                        if (int.TryParse(textboxBookYear.Text, out bookYearInt))
                        {
                            boxBooks.Items.Add(textboxBookTitle.Text);

                            books.Add(new Book(textboxBookTitle.Text, bookYearInt, textboxBookGenre.Text));

                            labelBookError.Text = "";
                        }
                        else { labelBookError.Text = "You did not enter a numerical year."; }
                    }
                    else { labelBookError.Text = "You did not enter a genre."; }
                }
                else { labelBookError.Text = "You did not enter a year."; }
            }
            else { labelBookError.Text = "You did not enter a title."; }
        }


        //VIEW DETAILS ON CLICK
        private void boxMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GET INDEX OF SELECTED, PRINT CORRESPONDING INFO
            int index = boxMovies.SelectedIndex;
            //Had to add this to avoid an indexing error
            if (index > -1)
            {
                textboxMovieDisplay.Text = "Title: " + movies[index].movieTitle;
                int yearint = movies[index].movieYear;
                textboxMovieDisplay2.Text = "Release Year: " + yearint.ToString();
                textboxMovieDisplay3.Text = "Genre: " + movies[index].movieGenre;
            }
        }

        private void boxCDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = boxCDs.SelectedIndex;
            if (index > -1)
            {
                textboxCDDisplay.Text = "Title: " + cds[index].cdTitle;
                int yearint = cds[index].cdYear;
                textboxCDDisplay2.Text = "Release Year: " + yearint.ToString();
                textboxCDDisplay3.Text = "Genre: " + cds[index].cdGenre;
            }
        }

        private void boxBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = boxBooks.SelectedIndex;
            if (index > -1)
            {
                textboxBookDisplay.Text = "Title: " + books[index].bookTitle;
                int yearint = books[index].bookYear;
                textboxBookDisplay2.Text = "Release Year: " + yearint.ToString();
                textboxBookDisplay3.Text = "Genre: " + books[index].bookGenre;
            }

        }


        //LOAD SAVE FILES
        //I modified these from your pokedex
        private void LoadMovieList()
        {
            if (File.Exists(@"movies.txt"))
            {
                using (StreamReader reader = new StreamReader("movies.txt"))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] mov = new string[3];
                        mov = line.Split(new char[] { '|' });
                        movies.Add(new Movie(mov[0], int.Parse(mov[1]), mov[2]));


                        //ADD THE TITLE TO THE MOVIES BOX ON SCREEN
                        //boxMovies.Items.Add(mov[0]);
                        //This line gives a null exception error so I commented it out for now. 
                        //Movies can still be added through the GUI, but do not load in properly from the file
                    }
                }

            }
        }

        private void LoadCDList()
        {
            if (File.Exists(@"cds.txt"))
            {
                using (StreamReader reader1 = new StreamReader("cds.txt"))
                {
                    string line;
                    while ((line = reader1.ReadLine()) != null)
                    {
                        string[] cda = new string[3];
                        cda = line.Split(new char[] { '|' });
                        cds.Add(new CD(cda[0], int.Parse(cda[1]), cda[2]));

                        //boxCDs.Items.Add(cda[0]);
                    }
                }

            }
        }

        private void LoadBookList()
        {
            if (File.Exists(@"books.txt"))
            {
                using (StreamReader reader2 = new StreamReader("books.txt"))
                {
                    string line;
                    while ((line = reader2.ReadLine()) != null)
                    {
                        string[] boo = new string[3];
                        boo = line.Split(new char[] { '|' });
                        books.Add(new Book(boo[0], int.Parse(boo[1]), boo[2]));

                        //boxBooks.Items.Add(boo[0]);
                    }
                }
            }
        }








        //WRITE SAVE FILES
        //I also modified these from your pokedex
        private void SaveMovieList()
        {
            if (File.Exists(@"movies.txt"))
            {
                using (StreamWriter writer = new StreamWriter("movies.txt"))
                {
                    foreach (Movie m in movies)
                    {
                        //Title|Year|Genre
                        writer.WriteLine(m.movieTitle + "|" + m.movieYear + "|" + m.movieGenre);
                    }
                }
            }
            else
            {
                File.Create("movies.txt");
                SaveMovieList();
            }
        }

        private void SaveCDList()
        {
            if (File.Exists(@"cds.txt"))
            {
                using (StreamWriter writer1 = new StreamWriter("cds.txt"))
                {
                    foreach (CD c in cds)
                    {
                        writer1.WriteLine(c.cdTitle + "|" + c.cdYear + "|" + c.cdGenre);
                    }
                }
            }
            else
            {
                File.Create("cds.txt");
                SaveCDList();
            }
        }

        private void SaveBookList()
        {
            if (File.Exists(@"books.txt"))
            {
                using (StreamWriter writer2 = new StreamWriter("books.txt"))
                {
                    foreach (Book b in books)
                    {
                        writer2.WriteLine(b.bookTitle + "|" + b.bookYear + "|" + b.bookGenre);
                    }
                }
            }
            else
            {
                File.Create("books.txt");
                SaveBookList();
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveMovieList();
            SaveCDList();
            SaveBookList();
        }





        //REMOVE FROM LIST
        private void buttonRemoveMovie_Click(object sender, EventArgs e)
        {
            boxMovies.Items.Remove(boxMovies.SelectedItem);
        }

        private void buttonRemoveCD_Click(object sender, EventArgs e)
        {
            boxCDs.Items.Remove(boxCDs.SelectedItem);
        }

        private void buttonRemoveBook_Click(object sender, EventArgs e)
        {
            boxBooks.Items.Remove(boxBooks.SelectedItem);
        }


    }

    //OBJECT DEFINITION
    public struct Movie
    {
        public String movieTitle;
        public int movieYear;
        public String movieGenre;

        public Movie(String t, int y, String g)
        {
            this.movieTitle = t;
            this.movieYear = y;
            this.movieGenre = g;
        }
    }

    public struct CD
    {
        public String cdTitle;
        public int cdYear;
        public String cdGenre;

        public CD(String t, int y, String g)
        {
            this.cdTitle = t;
            this.cdYear = y;
            this.cdGenre = g;
        }
    }

    public struct Book
    {
        public String bookTitle;
        public int bookYear;
        public String bookGenre;

        public Book(String t, int y, String g)
        {
            this.bookTitle = t;
            this.bookYear = y;
            this.bookGenre = g;
        }
    }

}
