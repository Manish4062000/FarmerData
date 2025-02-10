namespace FarmerDataStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var addRequestDTO = new
            {
                rmcid = 123,          // Replace with actual data
                Farmerid = 456,       // Replace with actual data
                date = DateOnly.Parse("2024-12-02"), // Replace with actual date
                time = TimeOnly.Parse("12:30"), // Replace with actual time
                KioskId = 789,        // Replace with actual data
                weight = 45.6         // Replace with actual weight
            };
        }
    }
}
