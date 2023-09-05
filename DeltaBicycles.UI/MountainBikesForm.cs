using DeltaBicycles.Business;
using DeltaBicycles.Business.Enums;

namespace DeltaBicycles.UI
{
    public partial class MountainBikesForm : Form
    {
        private List<Bike> _listOfBikes;
        private int _originalBikeId = -1;
        private MountainBike? _mountainBike;
        private bool _ChangeType = false;
        private RoadBike? _myRoadBike;

        private bool _registerChanges = true;

        public bool RegisterChanges => _registerChanges;

        public MountainBikesForm(MountainBike? bike, List<Bike> listOfBikes)
        {
            InitializeComponent();
            _listOfBikes = listOfBikes;
            _mountainBike = bike;

            if (_mountainBike == null)
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;

                txtId.Text = Validator.SuggestedId(_listOfBikes);
            }
            else
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;

                _originalBikeId = _mountainBike.Id;
                txtId.Text = _mountainBike.Id.ToString();
                txtModel.Text = _mountainBike.Model;
                txtManufacturingYear.Text = _mountainBike.ManufacturingYear.ToString();
                cbColor.SelectedIndex = (int)_mountainBike.Color;
                cbSuspensionType.SelectedIndex = (int)_mountainBike.BikeSuspencion;
            }
        }

        public MountainBikesForm(Bike bike, List<Bike> listOfBikes, bool TypeChange)
        {
            InitializeComponent();
            _listOfBikes = listOfBikes;
            _ChangeType = TypeChange;
            _myRoadBike = (RoadBike)bike;

            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;


            _originalBikeId = bike.Id;
            txtId.Text = bike.Id.ToString();
            txtModel.Text = bike.Model;
            txtManufacturingYear.Text = bike.ManufacturingYear.ToString();
            cbColor.SelectedIndex = (int)bike.Color;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            int BikeId;

            try
            {
                BikeId = Convert.ToInt32(txtId.Text);
            }

            catch
            {
                BikeId = -1;
            }
            int year;

            try
            {
                year = Convert.ToInt32(txtManufacturingYear.Text);
            }
            catch 
            {
                year = -1;
            }

            if (BikeId != _originalBikeId && _listOfBikes.Any(s => s.Id == BikeId))
            {
                MessageBox.Show("ID is already in use");
                return;
            }

            _mountainBike = new MountainBike(BikeId, txtModel.Text, year,
                    (EColor)cbColor.SelectedIndex,
                    (ESuspensionType)cbSuspensionType.SelectedIndex);

            _mountainBike.GotInvalidNotification += _mountainBike_GotInvalidNotification;

            if (!Validator.CheckValidity(_mountainBike))
                return;


            _listOfBikes.Add(_mountainBike);
            _registerChanges = false;

            DialogResult = DialogResult.OK;
        }

        private void _mountainBike_GotInvalidNotification(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int BikeId;

            try
            {
                BikeId = Convert.ToInt32(txtId.Text);
            }

            catch 
            {
                BikeId = -1;
            }

            int year;

            try
            {
                year = Convert.ToInt32(txtManufacturingYear.Text);
            }
            catch 
            {
                year = -1;
            }

            if (BikeId != _originalBikeId && _listOfBikes.Any(s => s.Id == BikeId))
            {
                MessageBox.Show("ID is already in use");
                return;
            }
            
            var tempBike = new MountainBike(BikeId, txtModel.Text, year,
                (EColor)cbColor.SelectedIndex,
                (ESuspensionType)cbSuspensionType.SelectedIndex);

            tempBike.GotInvalidNotification += _mountainBike_GotInvalidNotification;

            if (!Validator.CheckValidity(tempBike))
                return;

            if (_ChangeType)
            {
                _listOfBikes.Remove(_myRoadBike!);
                _myRoadBike = null;
                _listOfBikes.Add(tempBike);
            }

            else
            {
                _mountainBike.Id = tempBike.Id;
                _mountainBike.Model = tempBike.Model;
                _mountainBike.ManufacturingYear = tempBike.ManufacturingYear ;
                _mountainBike.Color = tempBike.Color;
                _mountainBike.BikeSuspencion = tempBike.BikeSuspencion;
            }


            _registerChanges = false;
            DialogResult = DialogResult.OK;
        }
    }
}
