using DeltaBicycles.Business.Enums;

namespace DeltaBicycles.Business
{
    public class RoadBike : Bike
    { 
        private ETireType _tireType;

        public ETireType TireType { get => _tireType; set => _tireType = value; }

        

        #region Constructor
        public RoadBike() : base()
        {

        }
        public RoadBike(int id) : base(id)
        {

        }

        public RoadBike(int id, string model) : base(id, model)
        {

        }

        public RoadBike(int id, string model, int manufacturingYear) : base(id, model, manufacturingYear)
        {

        }

        public RoadBike(int id, string model, int manufacturingYear, EColor colour) : base(id, model, manufacturingYear, colour)
        {

        }

        public RoadBike(int id, string model, int manufacturingYear, EColor colour, ETireType TireType) : base(id, model, manufacturingYear, colour)
        {
            this._tireType = TireType;
        }
        #endregion

        public override string AllFields()
        {
            return "Road Bike: " + base.AllFields() + $", Tire type: {_tireType}";
        }

        public override bool IsValid()
        {
            if (!base.IsValid())
            {
                return false;
            }

            else if (_tireType == ETireType.Undefined)
            {
                CallGotInvalidNotification("Please select a tire type");
                return false;
            }

            return true;
        }
    }
}
