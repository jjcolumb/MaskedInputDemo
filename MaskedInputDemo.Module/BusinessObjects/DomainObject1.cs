using DevExpress.Data.Filtering;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.Xpo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MaskedInputDemo.Module.BusinessObjects
{
    [DefaultClassOptions]
    public class DomainObject1 : BaseObject
    { 
        public DomainObject1(Session session)
            : base(session)
        {
        }
        public override void AfterConstruction()
        {
            base.AfterConstruction();
            // Place your initialization code here (https://documentation.devexpress.com/eXpressAppFramework/CustomDocument112834.aspx).
        }

        string email;
        string date;
        decimal price;
        string telephone;

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        //[ModelDefault("PropertyEditorType", "SampleSolution.Module.Win.PropertyEditors.CustomStringEditor")
        public string Telephone
        {
            get => telephone;
            set => SetPropertyValue(nameof(Telephone), ref telephone, value);
        }
       
        public decimal Price
        {
            get => price;
            set => SetPropertyValue(nameof(Price), ref price, value);
        }

        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Date
        {
            get => date;
            set => SetPropertyValue(nameof(Date), ref date, value);
        }
        
        [Size(SizeAttribute.DefaultStringMappingFieldSize)]
        public string Email
        {
            get => email;
            set => SetPropertyValue(nameof(Email), ref email, value);
        }
    }
}