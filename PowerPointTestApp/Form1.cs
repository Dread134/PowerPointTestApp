using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PowerPointTestApp
{
    public partial class Form1 : Form
    {

        public Button newTab1;
        public Button delTab1;
        public RichTextBox rtBox;
        public TextBox title;
        private TabPage myTabPage;
        private TabControl tabControl1;


        public Form1()
        {
            /// Slide Creation
            tabControl1 = new TabControl();
            myTabPage = new TabPage("Slide " + (tabControl1.TabCount + 1).ToString());
            tabControl1.TabPages.Add(myTabPage);

            /// Text box for info on tabs
            rtBox = new RichTextBox();
            rtBox.Location = new Point(5, 80);
            rtBox.Size = new Size(485, 390);
            rtBox.Text = "Put your information here";
            rtBox.Font = new Font("Times New Roman", 12);
            myTabPage.Controls.Add(rtBox);

            title = new TextBox();
            title.Location = new Point(5, 5);
            title.Size = new Size(485, 70);
            title.Font = new Font("Times New Roman", 42, FontStyle.Underline);
            title.Text = "Title";
            myTabPage.Controls.Add(title);


            tabControl1.Location = new Point(100, 20);
            tabControl1.Size = new Size(500, 500);

            ClientSize = new Size(300, 300);
            Controls.Add(tabControl1);

            
            





            /// New tab button
            newTab1 = new Button();
            newTab1.Size = new Size(80, 40);
            newTab1.Location = new Point(10, 20);
            newTab1.Text = "Add Tab";
            Controls.Add(newTab1);
            newTab1.Click += new EventHandler(newTab1_Click);

            /// Delete selected Tab
            delTab1 = new Button();
            delTab1.Size = new Size(80, 40);
            delTab1.Location = new Point(10, 70);
            delTab1.Text = "DELETE Tab";
            Controls.Add(delTab1);
            delTab1.Click += new EventHandler(delTab1_Click);

            InitializeComponent();
        }

        /// Create New Tabs
        private void newTab1_Click(object sender, EventArgs e)
        {
            rtBox = new RichTextBox();
            rtBox.Location = new Point(5, 80);
            rtBox.Size = new Size(485, 390);
            rtBox.Font = new Font("Times New Roman", 12);
            rtBox.Text = "Put your information here";
            myTabPage = new TabPage("Slide " + (tabControl1.TabCount + 1).ToString());
            tabControl1.Controls.Add(myTabPage);

            title = new TextBox();
            title.Location = new Point(5, 5);
            title.Size = new Size(485, 70);
            title.Font = new Font("Times New Roman", 42, FontStyle.Underline);
            title.Text = "Title";
            myTabPage.Controls.Add(title);

            myTabPage.Controls.Add(rtBox);

        }

        /// Delete selected tab
        private void delTab1_Click(object sender, EventArgs e)
        {
            /// Check if deleting the tab will cause a null variable and prevent it
            if (tabControl1.TabCount == 0)
            {
                MessageBox.Show("No Tabs To Delete.");
            }
            else
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
        }
    }
}
