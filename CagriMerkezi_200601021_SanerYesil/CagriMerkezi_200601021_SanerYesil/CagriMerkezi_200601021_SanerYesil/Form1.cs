namespace CagriMerkezi_200601021_SanerYesil
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CustomerQueue custQueue = new CustomerQueue();

        int x;
        int y;
        int z;
        string firstAssignment;
        string secondAssignment; 
        private void btnCall_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(typeTxt.Text) == 1)
            {
                custQueue.AddCommercial();
                custQueue.CommercialOutput();
                ListViewItem item = new ListViewItem(custQueue.comArray[x]);
                comListview.Items.Add(item);
                x++;

            }
            else if (Convert.ToInt32(typeTxt.Text) == 2)
            {
                custQueue.AddPersonal();
                custQueue.PersonalOutput();
                ListViewItem item = new ListViewItem(custQueue.perArray[y]);
                perListview.Items.Add(item);
                y++;
            }
            else
            {
                MessageBox.Show("Girdi�iniz de�er ge�ersiz, l�tfen ge�erli bir de�er giriniz.");
            }
        }

        private void firstComOpBtn_Click(object sender, EventArgs e)
        {
            if (comInfo1lbl.Text == "-")
            {
                comInfo1lbl.Text = custQueue.CommercialCallAssignment();
                comListview.Items.Remove(comListview.Items[0]);
            }
            else if (comInfo1lbl.Text == "Temsilci M�sait...")
            {
                comInfo1lbl.Text = custQueue.CommercialCallAssignment();
                comListview.Items.Remove(comListview.Items[0]);
            }
            else
            {
                MessageBox.Show("Temsilci ba�ka �a�r�da...");
            }
        }

        private void secondComOpBtn_Click(object sender, EventArgs e)
        {
            if (comInfolbl2.Text == "-")
            {
                comInfolbl2.Text = custQueue.CommercialCallAssignment();
                comListview.Items.Remove(comListview.Items[0]);
            }
            else if (comInfolbl2.Text == "Temsilci M�sait...")
            {
                comInfolbl2.Text = custQueue.CommercialCallAssignment();
                comListview.Items.Remove(comListview.Items[0]);
            }
            else
            {
                MessageBox.Show("Temsilci ba�ka �a�r�da...");
            }
        }

        private void firstPerOpBtn_Click(object sender, EventArgs e)
        {
            if (perInfolbl1.Text == "-")
            {
                perInfolbl1.Text = custQueue.PersonalCallAssignment();
                perListview.Items.Remove(perListview.Items[0]);
            }
            else if (perInfolbl1.Text == "Temsilci M�sait...")
            {
                perInfolbl1.Text = custQueue.PersonalCallAssignment();
                perListview.Items.Remove(perListview.Items[0]);
            }
            else
            {
                MessageBox.Show("Temsilci ba�ka �a�r�da...");
            }
        }

        private void secondPerOpBtn_Click(object sender, EventArgs e)
        {
            if (perInfolbl2.Text == "-")
            {
                perInfolbl2.Text = custQueue.PersonalCallAssignment();
                perListview.Items.Remove(perListview.Items[0]);
            }
            else if (perInfolbl2.Text == "Temsilci M�sait...")
            {
                perInfolbl2.Text = custQueue.PersonalCallAssignment();
                perListview.Items.Remove(perListview.Items[0]);
            }
            else
            {
                MessageBox.Show("Temsilci ba�ka �a�r�da...");
            }
        }

        private void firstEndComCallBtn_Click(object sender, EventArgs e)
        {
            ListViewItem prevCalls = new ListViewItem("Ticari M��teri " + comInfo1lbl.Text + "\n" + " NOT: " + comNote.Text);
            this.prevCallslv.Items.Add(prevCalls);
            comInfo1lbl.Text = "Temsilci M�sait...";
            comNote.Clear();
        }

        private void firstEndPerCallBtn_Click(object sender, EventArgs e)
        {
            ListViewItem prevCalls = new ListViewItem("Bireysel M��teri " + perInfolbl1.Text + "\n" + " NOT: " + perNote.Text);
            prevCallslv.Items.Add(prevCalls);
            perInfolbl1.Text = "Temsilci M�sait...";
            perNote.Clear();
        }

        private void secondEndPerCallBtn_Click(object sender, EventArgs e)
        {
            ListViewItem prevCalls = new ListViewItem("Bireysel M��teri " + perInfolbl2.Text + "\n" + " NOT: " + perNote.Text);
            prevCallslv.Items.Add(prevCalls);
            perInfolbl2.Text = "Temsilci M�sait...";
            perNote.Clear();
        }

        private void secondEndComCallBtn_Click(object sender, EventArgs e)
        {
            ListViewItem prevCalls = new ListViewItem("Ticari M��teri " + comInfolbl2.Text + "\n" + " NOT: " + comNote.Text);
            prevCallslv.Items.Add(prevCalls);
            comInfolbl2.Text = "Temsilci M�sait...";
            comNote.Clear();
        }
    }
}