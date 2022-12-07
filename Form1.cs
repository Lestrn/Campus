namespace Campus
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Campus> campuses = new List<Campus>(5);

        private void AddCampusBtn_Click(object sender, EventArgs e)
        {
            bool isParsed = false;
            isParsed = uint.TryParse(AmountOfRoomsTextBox.Text, out uint amountOfRooms);
            isParsed = uint.TryParse(AmountOfPersonalTextBox.Text, out uint amountOfPersonal);
            isParsed = uint.TryParse(AmountOfStudentsTextBox.Text, out uint amountOfStudents);
            isParsed = decimal.TryParse(RevenuePerMonthTextBox.Text, out decimal revenuePerMonth);
            if (!isParsed)
            {
                MessageBox.Show("Numbers werent found in expected text boxes :(");
                return;
            }
            bool stringIsNotValid;
            stringIsNotValid = String.IsNullOrEmpty(UniversityNameTextBox.Text);
            stringIsNotValid = String.IsNullOrEmpty(AdressTextBox.Text);
            if (stringIsNotValid)
            {
                MessageBox.Show("Some text boxes were empty :(");
                return;
            }
            campuses.Add(new Campus(UniversityNameTextBox.Text, AdressTextBox.Text, amountOfRooms, amountOfPersonal, amountOfStudents, revenuePerMonth));
            UpdateComboBox();
            MessageBox.Show("Success!");
        }
        private void UpdateComboBox()
        {
            SavedCampusesComboBox.Items.Clear();
            foreach (var campus in campuses)
            {
                SavedCampusesComboBox.Items.Add(campus);
            }
            SavedCampusesComboBox.Text = "";
        }
        public bool TryGetCampusFromCheckBox(out Campus? campus) 
        {
            campus = null;
            Campus clonedCampus;
            campus = (Campus)SavedCampusesComboBox.SelectedItem;
            if (campus == null)
            {
                MessageBox.Show("Campus wasnt selected! ");
                return false;
            }
            return true;
        }
        private void CloneCampusBtn_Click(object sender, EventArgs e)
        {
            bool gotCampus = TryGetCampusFromCheckBox(out Campus campus);
            if (!gotCampus)
            {
                return;
            }
            campuses.Add(campus);
            UpdateComboBox();
            MessageBox.Show("Success!");
        }

        private void AddRoomsBtn_Click(object sender, EventArgs e)
        {
            GeneralChanges(AddRoomsTextBox);

        }

        private void RemoveStudentsBtn_Click(object sender, EventArgs e)
        {
            GeneralChanges(AddOrRemoveStudentsTextBox, false, false);
        }
        private void AddStudentBtn_Click(object sender, EventArgs e)
        {
            GeneralChanges(AddOrRemoveStudentsTextBox, false);
        }
        public void GeneralChanges(TextBox textBox,bool rooms = true, bool add = true)
        {
            bool gotCampus = TryGetCampusFromCheckBox(out Campus campus);
            if (!gotCampus)
            {
                return;
            }
            bool isParsed = uint.TryParse(textBox.Text, out uint amountToAddOrRemove);
            if (!isParsed)
            {
                MessageBox.Show("Unsigned Integer Expected");
                return;
            }
            if (rooms)
            {
                campus.AddRooms(amountToAddOrRemove);
                return;
            }
            try
            {
                campus.SettlementOrEvictionOfStudents(amountToAddOrRemove, add);
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            MessageBox.Show("Success!");
        }

        private void CalculateRevenueBtn_Click(object sender, EventArgs e)
        {
            bool gotCampus = TryGetCampusFromCheckBox(out Campus campus);
            if (!gotCampus)
            {
                return;
            }
            string type = RevenuePeriodComboBox.SelectedItem.ToString();
            bool isParsed = Enum.TryParse(typeof(PeriodType), type, out object parsedObject);
            if (!isParsed)
            {
                MessageBox.Show("correct type wasnt selected");
            }
            PeriodType periodType = (PeriodType)parsedObject;
            MessageBox.Show($"Total revenue: {campus.CalculateRevenue(periodType)}\n{periodType}");
        }

        private void ShowInfoBtn_Click(object sender, EventArgs e)
        {
            bool gotCampus = TryGetCampusFromCheckBox(out Campus campus);
            if (!gotCampus)
            {
                return;
            }
            MessageBox.Show(campus.ToString());
        }

        private void AddDinningRoomBtn_Click(object sender, EventArgs e)
        {
            bool gotCampus = TryGetCampusFromCheckBox(out Campus campus);
            if (!gotCampus)
            {
                return;
            }
            campus.AddDiningroom();
            MessageBox.Show("Success!");
        }

        private void RemoveCampusBtn_Click(object sender, EventArgs e)
        {
            bool gotCampus = TryGetCampusFromCheckBox(out Campus campus);
            if (!gotCampus)
            {
                return;
            }
            campuses.Remove(campus);
            UpdateComboBox();
            MessageBox.Show("Success!");

        }
    }
}