using DeltaBicycles.Business;
using DeltaBicycles.Business.Enums;

namespace DeltaBicycles.UI
{
    public partial class RoadBikesForm : Form
    {
        private List<Bike> _listOfBikes;
        private int _originalBikeId = -1;
        private RoadBike? _roadBike;
        private bool _ChangeType = false;
        private MountainBike? myMountainBike;

        private bool _registerChanges = true;

        public bool RegisterChanges => _registerChanges;

        public RoadBikesForm(RoadBike? bike, List<Bike> listOfBikes)
        {
            InitializeComponent();
            _listOfBikes = listOfBikes;
            _roadBike = bike;

            if (_roadBike == null)
            {
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                txtId.Text = Validator.SuggestedId(_listOfBikes);
            }
            else
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = true;

                _originalBikeId = _roadBike.Id;
                txtId.Text = _roadBike.Id.ToString();
                txtModel.Text = _roadBike.Model;
                txtManufacturingYear.Text = _roadBike.ManufacturingYear.ToString();
                cbColor.SelectedIndex = (int)_roadBike.Color;
                cbTireType.SelectedIndex = (int)_roadBike.TireType;
            }
        }

        public RoadBikesForm(Bike bike, List<Bike> listOfBikes, bool TypeChange)
        {
            InitializeComponent();
            _listOfBikes = listOfBikes;
            _ChangeType = TypeChange;
            myMountainBike = (MountainBike)bike;

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

            _roadBike = new RoadBike(BikeId, txtModel.Text, year,
                    (EColor)cbColor.SelectedIndex,
                    (ETireType)cbTireType.SelectedIndex);

            _roadBike.GotInvalidNotification += _roadBike_GotInvalidNotification;
            
            if (!Validator.CheckValidity(_roadBike))
                return;


            _listOfBikes.Add(_roadBike);
            _registerChanges = false;

            DialogResult = DialogResult.OK;
        }

        private void _roadBike_GotInvalidNotification(string message)
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

            var tempBike = new RoadBike(BikeId, txtModel.Text, year,
                    (EColor)cbColor.SelectedIndex,
                    (ETireType)cbTireType.SelectedIndex);

            tempBike.GotInvalidNotification += _roadBike_GotInvalidNotification;

            if (!Validator.CheckValidity(tempBike))
                return;
            

            if (_ChangeType)
            {
                _listOfBikes.Remove(myMountainBike!);
                myMountainBike = null;
                _listOfBikes.Add(tempBike);
            }

            else
            {
                _roadBike.Id = tempBike.Id;
                _roadBike.Model = tempBike.Model;
                _roadBike.ManufacturingYear = tempBike.ManufacturingYear ;
                _roadBike.Color = tempBike.Color;
                _roadBike.TireType = tempBike.TireType;
            }


            _registerChanges = false;

            DialogResult = DialogResult.OK;
        }
    }
}
