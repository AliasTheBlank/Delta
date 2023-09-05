using DeltaBicycles.Business.Enums;

namespace DeltaBicycles.Business
{
    
    public class MountainBike : Bike
    {
        
        private ESuspensionType _suspencion;

        public ESuspensionType BikeSuspencion { get => _suspencion; set => _suspencion = value; }

        #region Constructor
        public MountainBike() : base()
        {

        }
        
        public MountainBike(int id) : base(id)
        {

        }

        public MountainBike(int id, string model) : base(id, model)
        {

        }

        public MountainBike(int id, string model, int manufacturingYear) : base(id, model, manufacturingYear)
        {

        }

        public MountainBike(int id, string model, int manufacturingYear, EColor colour) : base(id, model, manufacturingYear, colour)
        {

        }

        public MountainBike(int id, string model, int manufacturingYear, EColor colour, ESuspensionType suspencion) : base (id, model, manufacturingYear, colour)
        {
            this._suspencion = suspencion;
        }
#endregion

        public override string AllFields()
        {
            return "Mountain Bike: " + base.AllFields() + $", Suspencion Type: {_suspencion}";
        }

        public override bool IsValid()
        {
            if (!base.IsValid())
            {
                return false;
            }

            else if (_suspencion == ESuspensionType.Undefined)
            {
                CallGotInvalidNotification("Please select a shape type");
                return false;
            }

            return true;
        }
    }
}
