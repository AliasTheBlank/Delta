using System.Xml.Serialization;
using DeltaBicycles.Business.Delegates;
using DeltaBicycles.Business.Enums;
using DeltaBicycles.Business.Interface;

namespace DeltaBicycles.Business
{
    [Serializable]
    [XmlInclude(typeof(MountainBike))]
    [XmlInclude(typeof(RoadBike))]
    public abstract class Bike : IValidatable
    {
        private int _id;
        private string _model = "";
        private int _manufacturingYear;
        private EColor _color;
        private string _invalidMessage;

        public event Notify GotInvalidNotification;

        public int Id { get => _id; set => _id = value; }
        public string Model { get => _model; set => _model = value; }
        public EColor Color { get => _color; set => _color = value; }
        public int ManufacturingYear { get => _manufacturingYear; set => _manufacturingYear = value; }
        public string InvalidMessage 
        { 
            get => _invalidMessage;
            set => _invalidMessage = value;
        }
        protected Bike()
        {
            _id = 0;
            _model = "";
            _manufacturingYear = 0;
            _color = EColor.Undefined;
        }

        protected Bike(int id) : this()
        {
            _id = id;
        }

        protected Bike(int id, string model) : this(id)
        {
            _model = model;
        }

        protected Bike(int id, string model, int manufacturingYear) : this(id, model)
        {
            _manufacturingYear = manufacturingYear;
        }

        protected Bike(int id, string model, int manufacturingYear, EColor colour) : this(id, model, manufacturingYear)
        {
            _color = colour;
        }

        public virtual string AllFields()
        {
           return $"Id: {_id}, Model: {_model}, Manufacturing Year: {_manufacturingYear}, Colour: {_color}";
        }

        public virtual bool IsValid()
        {
            if (_id < 1)
            {
                CallGotInvalidNotification("Please enter a valid Id");
                return false;
            }
            else if (_model == "")
            {
                CallGotInvalidNotification("Please inform a model");
                return false;
            }
            else if (!Validator.ValidateModel(_model))
            {
                CallGotInvalidNotification("Model should contain 5 characters (numbers or letters)");
                return false;
            }
            else if (_color == EColor.Undefined)
            {
                CallGotInvalidNotification("Please select a color");
                return false;
            }
            else if (_manufacturingYear > 2022 || _manufacturingYear < 0)
            {
                CallGotInvalidNotification("Please enter a valid year (Numerical)");
                return false;
            }

            return true;
        }

        protected void CallGotInvalidNotification(string Message)
        {
            _invalidMessage = Message;
            GotInvalidNotification(Message);
        }
    }
}
