using System.Data;
using DeltaBicycles.Business;
using DeltaBicycles.Data;

namespace DeltaBicycles.UI
{
    public partial class MainForm : Form
    {
        private List<Bike> _listOfBikes = DeltaXmlData.Load();
        private Dictionary<int, int> dictionaryOfIndexes = new Dictionary<int, int>();
        private bool _allChangesSave = true;

        public MainForm()
        {
            InitializeComponent();
            RefreshList();
        }

        private void btnAddRB_Click(object sender, EventArgs e)
        {
            //_addOrUpdate = true;
            var frmRoadBike = new RoadBikesForm(null,  _listOfBikes);
            frmRoadBike.ShowDialog();
            RefreshList();
            _allChangesSave = frmRoadBike.RegisterChanges;
        }

        private void btnUpdateRB_Click(object sender, EventArgs e)
        {
            if (lvBikes.FocusedItem == null)
            {
                MessageBox.Show("Please select a bike in the list view!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Bike myBike = _listOfBikes[lvBikes.FocusedItem.Index];

            if (myBike is MountainBike)
            {
                var answer = MessageBox.Show("You want to update a MountainBike as a RoadBike, Are you sure you want to do this?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.No)
                    return;
                else
                {
                    var frmRoadBike = new RoadBikesForm(myBike, _listOfBikes, true);
                    frmRoadBike.ShowDialog();
                    RefreshList();
                    _allChangesSave = frmRoadBike.RegisterChanges;
                }
                //MessageBox.Show("You want to update a MountainBike as a RoadBike", "Warning",
                //    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            else
            {
                var myRoadBike = (RoadBike)myBike;
                var frmRoadBike = new RoadBikesForm(myRoadBike, _listOfBikes);
                frmRoadBike.ShowDialog();
                RefreshList();
                _allChangesSave = frmRoadBike.RegisterChanges;
            }
        }

        private void btnAddMB_Click(object sender, EventArgs e)
        {
            //_addOrUpdate = true;
            var frmMountainBike = new MountainBikesForm(null, _listOfBikes);
            frmMountainBike.ShowDialog();
            RefreshList();
            _allChangesSave = frmMountainBike.RegisterChanges;
        }

        private void btnUpdateMB_Click(object sender, EventArgs e)
        {
            if (lvBikes.FocusedItem == null)
            {
                MessageBox.Show("Please select a bike in the list view!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Bike myBike = _listOfBikes[lvBikes.FocusedItem.Index];

            if (myBike is RoadBike)
            {
                var answer = MessageBox.Show("You want to update a RoadBike as a Mountain Bike, Are you sure you want to do this?", "Warning",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (answer == DialogResult.No)
                    return;
                else
                {
                    var frmMountainBike = new MountainBikesForm(myBike, _listOfBikes, true);
                    frmMountainBike.ShowDialog();
                    RefreshList();
                    _allChangesSave = frmMountainBike.RegisterChanges;
                }
                return;
            }

            else
            {
                var myMountainBike = (MountainBike)myBike;
                var frmMountainBike = new MountainBikesForm(myMountainBike, _listOfBikes);
                frmMountainBike.ShowDialog();
                RefreshList();
                _allChangesSave = frmMountainBike.RegisterChanges;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Validator.ValidId(txtSB.Text))
            {
                Int32.TryParse(txtSB.Text, out int storedID);
                Bike? bike = _listOfBikes.FirstOrDefault(s => s!.Id == storedID, null);


                if (bike is not null)
                {
                    MessageBox.Show(bike.AllFields().Replace(", ", Environment.NewLine), "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                
                else
                {
                    MessageBox.Show("Id not found", "Error 404",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            else
            {
                MessageBox.Show("Non valid ID", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void btnRemoveById_Click(object sender, EventArgs e)
        {
            if (Validator.ValidId(txtSB.Text))
            {
                int.TryParse(txtSB.Text, out int storedID);

                foreach (var bike in _listOfBikes)
                {
                    if (storedID == bike.Id)
                    {

                        var answer = MessageBox.Show("Do you really want to delete this bike",
                                         "Confirmation", MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
                        if (answer == DialogResult.Yes)
                        {
                            _listOfBikes.Remove(bike);
                            RefreshList();
                            _allChangesSave = false;
                            txtSB.Text = "";
                        }
                        return;
                    }
                }
                MessageBox.Show("Id not found", "Error 404",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else 
            {
                MessageBox.Show("Non valid ID", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int GetIndexFromDictionary()
        {
            int listBoxIndex = lvBikes.FocusedItem.Index;
            if (listBoxIndex < 0)
                return -1;
            return dictionaryOfIndexes[listBoxIndex];
        }
        private void RefreshList()
        {
            _listOfBikes = _listOfBikes.OrderBy(o => o.Id).ToList();
            lvBikes.Items.Clear();
            dictionaryOfIndexes.Clear();

            int listCounter = 0;
            foreach (var bike in _listOfBikes)
            {
                bool add = false;

                if (rbAll.Checked)
                {
                    add = true;
                }
                if (rbRoadBike.Checked && bike is RoadBike)
                {
                    add = true;
                }
                if (rbMountainBike.Checked && bike is MountainBike)
                {
                    add = true; 
                }

                if (add)
                {
                    var listViewItem = new ListViewItem(bike.AllFields());
                    dictionaryOfIndexes.Add(lvBikes.Items.Count, listCounter);
                    lvBikes.Items.Add(listViewItem);
                }
                listCounter++;
            }
        }

        private void rbAll_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void rbRoadBike_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void rbMountainBike_CheckedChanged(object sender, EventArgs e)
        {
            RefreshList();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var answer = MessageBox.Show("Do you really want to save the list of bikes?",
                                         "Confirmation", MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                DeltaXmlData.Save(_listOfBikes);
                _allChangesSave = true;
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_allChangesSave)
            {
                var answer = MessageBox.Show("Do you want to close the application without saving your previous changes?",
                                           "Warning", MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Warning);
                if (answer == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
            
            else 
            {
                var answer = MessageBox.Show("Do you really want to exit the application?",
                                           "Confirmation", MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
                if (answer == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void btnRemoveByIndex_Click(object sender, EventArgs e)
        {
            int index = GetIndexFromDictionary();
            if (index < 0)
            {
                MessageBox.Show("Please select a skateboard to remove");
                return;
            }

            var result = MessageBox.Show("Do you really want to remove?",
                                         "Confirmation",
                                         MessageBoxButtons.YesNo,
                                         MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                return;

            _listOfBikes.RemoveAt(index);
            lvBikes.Items.RemoveAt(lvBikes.FocusedItem.Index);
            _allChangesSave = false;
        }
    }
}



//_listOfBikes = _listOfBikes.OrderBy(o => o.Id).ToList();