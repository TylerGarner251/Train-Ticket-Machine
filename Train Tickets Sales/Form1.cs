using System.Xml.Schema;

namespace Train_Tickets_Sales
{
    public partial class MainForm : Form
    {
        string Destination = "";
        string WellFair = "";
        double Discount = 0;
        string Discount2 = "";
        double Value = 0;
        double Total = 0;
        string Age = "";
        public MainForm()
        {
            InitializeComponent();
        }
        private void Reset()
        {
            Destination = "";
            TextDisplay.Text = "Welcome Sarre Transport";
            WellFair = "";
            Age = "";
            Discount = 0;
            Total = 0;
            Value = 0;
            AshfordButton.Show();
            DoverButton.Show();
            LondonButton.Show();
            StandardButton.Hide();
            FirstClassButton.Hide();
            Age2Button.Hide();
            Age16Button.Hide();
            Age65Button.Hide();
            DetailsButton.Hide();
            DestinationLabel.Hide();
            UpgradeLabel.Hide();
            AgeLabel.Hide();
            TotalLabel.Hide();
            PayButton.Hide();
            pictureBox1.Hide();
            PrintingLabel.Hide();
            CancelButton.Show();
            NoRailcard.Hide();
        }

        private void TextDisplay_TextChanged(object sender, EventArgs e)
        {
        }

        private void AshfordButton_Click(object sender, EventArgs e)
        {
            if (Destination == "")
            {
                Destination = "Ashford";
                Value = 8.90;
                TextDisplay.Text = Destination;
                AshfordButton.Hide();
                DoverButton.Hide();
                LondonButton.Hide();
                StandardButton.Show();
                FirstClassButton.Show();

            }
        }
        private void DoverButton_Click(object sender, EventArgs e)
        {
            if (Destination == "")
            {
                Destination = "Dover";
                Value = 9.40;
                TextDisplay.Text = Destination;
                AshfordButton.Hide();
                DoverButton.Hide();
                LondonButton.Hide();
                StandardButton.Show();
                FirstClassButton.Show();
            }

        }
        private void LondonButton_Click(object sender, EventArgs e)
        {
            if (Destination == "")
            {
                Destination = "London";
                Value = 37.00;
                TextDisplay.Text = Destination;
                AshfordButton.Hide();
                DoverButton.Hide();
                LondonButton.Hide();
                StandardButton.Show();
                FirstClassButton.Show();
            }

        }
        private void CancelButton_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void StandardButton_Click(object sender, EventArgs e)
        {
            WellFair = "Standard";
            TextDisplay.Text = WellFair;
            StandardButton.Hide();
            FirstClassButton.Hide();
            Age2Button.Show();
            Age16Button.Show();
            Age65Button.Show();
            NoRailcard.Show();
        }

        private void FirstClassButton_Click(object sender, EventArgs e)
        {
            WellFair = "First Class";
            TextDisplay.Text = WellFair;
            if (Destination == "Ashford")
            {
                Value = 13.30;
            }
            if (Destination == "Dover")
            {
                Value = 14.90;
            }
            if (Destination == "London")
            {
                Value = 63.00;
            }
            StandardButton.Hide();
            FirstClassButton.Hide();
            Age2Button.Show();
            Age16Button.Show();
            Age65Button.Show();
            NoRailcard.Show();


        }

        private void Age2Button_Click(object sender, EventArgs e)
        {
            Discount = 100;
            Discount2 = "100%";
            TextDisplay.Text = "Age 0-2 | FREE";
            Age = "0-2";
            Total = Value - Value;
            StandardButton.Hide();
            FirstClassButton.Hide();
            Age2Button.Hide();
            Age16Button.Hide();
            Age65Button.Hide();
            NoRailcard.Hide();
            DetailsButton.Show();
        }

        private void Age16Button_Click(object sender, EventArgs e)
        {
            Discount = 0.1;
            Discount2 = "10%";
            double Total2 = Value * Discount;
            Total = Value - Total2;
            Age = "3-16";
            TextDisplay.Text = "Age 3-16 | 10%";
            StandardButton.Hide();
            FirstClassButton.Hide();
            Age2Button.Hide();
            Age16Button.Hide();
            Age65Button.Hide();
            NoRailcard.Hide();
            DetailsButton.Show();
        }

        private void Age65Button_Click(object sender, EventArgs e)
        {
            Discount = 0.15;
            Discount2 = "15%";
            double Total2 = Value * Discount;
            Total = Value - Total2;
            Age = "65+";
            TextDisplay.Text = "Age 65+ | 15%";
            StandardButton.Hide();
            FirstClassButton.Hide();
            Age2Button.Hide();
            Age16Button.Hide();
            Age65Button.Hide();
            NoRailcard.Hide();
            DetailsButton.Show();

        }
        private void NoRailcard_Click(object sender, EventArgs e)
        {
            Total = Value;
            Age = "No Railcard";
            Discount2 = "0%";
            TextDisplay.Text = "No RailCard";
            StandardButton.Hide();
            FirstClassButton.Hide();
            Age2Button.Hide();
            Age16Button.Hide();
            Age65Button.Hide();
            NoRailcard.Hide();
            DetailsButton.Show();
        }
        private void DetailsButton_Click(object sender, EventArgs e)
        {
            DetailsButton.Hide();
            DestinationLabel.Show();
            UpgradeLabel.Show();
            AgeLabel.Show();
            TotalLabel.Show();
            PayButton.Show();
            DestinationLabel.Text = "Destination: " + Destination;
            UpgradeLabel.Text = "Seating: " + WellFair;
            AgeLabel.Text = "Age: " + Age + "| Discount: " + Discount2;
            TotalLabel.Text = "Total: " + "£" + Total.ToString("#.##");
            TextDisplay.Text = "Please Pay to receive ticket";
            
        }
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;

            // Console.WriteLine("start wait timer");
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                // Console.WriteLine("stop wait timer");
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void UpgradeLabel_Click(object sender, EventArgs e)
        {

        }

        private void AgeLabel_Click(object sender, EventArgs e)
        {

        }

        private void TotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void PayButton_Click(object sender, EventArgs e)
        {
            TextDisplay.Text = "Payment Accepted";
            PayButton.Hide();
            pictureBox1.Show();
            PrintingLabel.Show();
            CancelButton.Hide();
            wait(4000);
            Reset();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PrintingLabel_Click(object sender, EventArgs e)
        {

        }

        private void TextDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}